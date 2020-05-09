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
    /// サーバ接続リスナーインターフェース
    /// </summary>
    public interface ServerConnectionListener
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="server"></param>
        /// <param name="address"></param>
        void OnConnectClient(Server server, string address);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="server"></param>
        /// <param name="data"></param>
        void OnDataReceiving(Server server, byte[] data);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="server"></param>
        /// <param name="data"></param>
        void OnFileReceived(Server server, byte[] data);
    }

    /// <summary>
    /// サーバ側の接続管理クラス
    /// </summary>
    public class Server
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Server()
        {
            ServerConnectionListeners = new List<ServerConnectionListener>();
        }

        /// <summary>
        /// サーバー接続リスナー
        /// </summary>
        public List<ServerConnectionListener> ServerConnectionListeners { get; private set; }

        /// <summary>
        /// タイムアウト時間
        /// </summary>
        public int TimeoutMillisec { get; private set; } = 100000;

        /// <summary>
        /// リスナーを追加
        /// </summary>
        /// <param name="listener"></param>
        public void AddListener(ServerConnectionListener listener)
        {
            ServerConnectionListeners.Add(listener);
        }

        /// <summary>
        /// リスナーを削除
        /// </summary>
        /// <param name="listener"></param>
        public void RemoveListener(ServerConnectionListener listener)
        {
            ServerConnectionListeners.Remove(listener);
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
                var ipAddress = IPAddress.Parse(ip);
                var listener = new System.Net.Sockets.TcpListener(ipAddress, port);
                listener.Start();
                var task = Task.Run(() => listen(listener));
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
        /// <param name="listener"></param>
        private void listen(System.Net.Sockets.TcpListener listener)
        {
            var client = listener.AcceptTcpClient();

            using (var ns = client.GetStream())
            {
                ns.ReadTimeout = ns.WriteTimeout = TimeoutMillisec;

                bool disconnected = false;
                do
                {
                    // クライアントからのメッセージを受信
                    using (var rms = new MemoryStream())
                    {
                        ns.Read(rms.ToArray(), 0, (int)rms.Length);

                        BinaryFormatter rbf = new BinaryFormatter();
                        FTPMessageData rMessageData = (FTPMessageData)rbf.Deserialize(ns);

                        switch(rMessageData.Type)
                        {
                            case FTPMessageType.TypeHandShake:
                                foreach (var listeners in ServerConnectionListeners)
                                {
                                    listeners.OnConnectClient(this, rMessageData.Message);
                                }
                                using (var sms = new MemoryStream())
                                {
                                    var sMessageData = new FTPMessageData(FTPMessageType.TypeHandShake);
                                    sMessageData.Message = Dns.GetHostName();
                                    BinaryFormatter bf = new BinaryFormatter();
                                    bf.Serialize(sms, sMessageData);
                                    ns.Write(sms.ToArray(), 0, (int)sms.Length);
                                }
                                break;
                        }
                    }
                }
                while (!disconnected);
            }
        }
    }
}
