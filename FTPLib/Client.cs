using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FTPLib
{
    /// <summary>
    /// クライアント接続リスナーインターフェース
    /// </summary>
    public interface ClientConnectionListener
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        void OnConnectServer(Client client, string address);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="server"></param>
        /// <param name="data"></param>
        void OnDataReceiving(Client client, byte[] data);
    }

    /// <summary>
    /// クライアント側の接続管理クラス
    /// </summary>
    public class Client
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Client()
        {
            ClientConnectionListeners = new List<ClientConnectionListener>();
        }

        /// <summary>
        /// クライアント接続リスナー
        /// </summary>
        public List<ClientConnectionListener> ClientConnectionListeners { get; private set; }

        /// <summary>
        /// タイムアウト時間
        /// </summary>
        public int TimeoutMillisec { get; private set; } = 10000;

        /// <summary>
        /// リスナーを追加
        /// </summary>
        /// <param name="listener"></param>
        public void AddListener(ClientConnectionListener listener)
        {
            ClientConnectionListeners.Add(listener);
        }

        /// <summary>
        /// リスナーを削除
        /// </summary>
        /// <param name="listener"></param>
        public void RemoveListener(ClientConnectionListener listener)
        {
            ClientConnectionListeners.Remove(listener);
        }

        /// <summary>
        /// 接続を開始
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        public bool Start(string ip, int port)
        {
            try
            {
                var client = new System.Net.Sockets.TcpClient(ip, port);
                var task = Task.Run(() => listen(client));
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        private void listen(System.Net.Sockets.TcpClient client)
        {
            using (var ns = client.GetStream())
            {
                ns.ReadTimeout = ns.WriteTimeout = TimeoutMillisec;

                using (var ms = new MemoryStream())
                {
                    var ftpMessageData = new FTPMessageData(FTPMessageType.TypeHandShake);
                    ftpMessageData.Message = Dns.GetHostName();
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, ftpMessageData);
                    ns.Write(ms.ToArray(), 0, (int)ms.Length);
                }

                bool disconnected = false;
                do
                {
                    // サーバからのメッセージを受信
                    using (var ms = new MemoryStream())
                    {
                        ns.Read(ms.ToArray(), 0, (int)ms.Length);

                        BinaryFormatter bf = new BinaryFormatter();
                        var ftpMessageData = (FTPMessageData)bf.Deserialize(ns);

                        switch (ftpMessageData.Type)
                        {
                            case FTPMessageType.TypeHandShake:
                                foreach (var listeners in ClientConnectionListeners)
                                {
                                    listeners.OnConnectServer(this, ftpMessageData.Message);
                                }
                                break;
                        }
                    }
                }
                while (!disconnected);

            }
            client.Close();
        }
    }
}
