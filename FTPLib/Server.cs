using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FTPLib
{
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

    public class Server
    {
        public Server()
        {
            ServerConnectionListeners = new List<ServerConnectionListener>();
        }

        /// <summary>
        /// サーバー接続リスナー
        /// </summary>
        public List<ServerConnectionListener> ServerConnectionListeners { get; private set; }

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

        private void listen(System.Net.Sockets.TcpListener listener)
        {
            var client = listener.AcceptTcpClient();

            System.Net.Sockets.NetworkStream ns = client.GetStream();

            ns.ReadTimeout = 10000;
            ns.WriteTimeout = 10000;

            //クライアントから送られたデータを受信する
            Encoding enc = Encoding.UTF8;
            bool disconnected = false;
            var ms = new MemoryStream();
            byte[] resBytes = new byte[256];
            int resSize = 0;
            //FTPLib.FTPMessageData data;
            do
            {
                //var size = sizeof(FTPLib.FTPMessageData);
                //データの一部を受信する
                resSize = ns.Read(resBytes, 0, resBytes.Length);
                //Readが0を返した時はクライアントが切断したと判断
                if (resSize == 0)
                {
                    disconnected = true;
                    Console.WriteLine("クライアントが切断しました。");
                    break;
                }
                //受信したデータを蓄積する
                ms.Write(resBytes, 0, resSize);
                //まだ読み取れるデータがあるか、データの最後が\nでない時は、
                // 受信を続ける
            } while (ns.DataAvailable || resBytes[resSize - 1] != '\n');

            //受信したデータを文字列に変換
            string resMsg = enc.GetString(ms.GetBuffer(), 0, (int)ms.Length);
            ms.Close();
            //末尾の\nを削除
            resMsg = resMsg.TrimEnd('\n');
            Console.WriteLine(resMsg);

            foreach (var listeners in ServerConnectionListeners)
            {
                listeners.OnConnectClient(this, resMsg);
            }

            if (!disconnected)
            {
                //クライアントにデータを送信する
                //クライアントに送信する文字列を作成
                string sendMsg = resMsg.Length.ToString();
                //文字列をByte型配列に変換
                byte[] sendBytes = enc.GetBytes(sendMsg + '\n');
                //データを送信する
                ns.Write(sendBytes, 0, sendBytes.Length);
                Console.WriteLine(sendMsg);
            }

            //閉じる
            ns.Close();
            client.Close();
            Console.WriteLine("クライアントとの接続を閉じました。");

            //リスナを閉じる
            listener.Stop();
            Console.WriteLine("Listenerを閉じました。");
        }

        private void receiving(System.Net.Sockets.TcpListener listener)
        {
            var client = listener.AcceptTcpClient();

            System.Net.Sockets.NetworkStream ns = client.GetStream();

            ns.ReadTimeout = 10000;
            ns.WriteTimeout = 10000;

            //クライアントから送られたデータを受信する

            bool disconnected = false;
            var ms = new MemoryStream();
            byte[] resBytes = new byte[1024 * 1024 * 8];
            int resSize = 0;
            do
            {
                //データの一部を受信する
                resSize = ns.Read(resBytes, 0, resBytes.Length);
                //Readが0を返した時はクライアントが切断したと判断
                if (resSize == 0)
                {
                    disconnected = true;
                    Console.WriteLine("クライアントが切断しました。");
                    break;
                }
                //受信したデータを蓄積する
                ms.Write(resBytes, 0, resSize);
                //まだ読み取れるデータがあるか、データの最後が\nでない時は、
                // 受信を続ける
            } while (ns.DataAvailable || resBytes[resSize - 1] != '\n');

            //受信したデータを文字列に変換
            Encoding enc = Encoding.UTF8;
            string resMsg = enc.GetString(ms.GetBuffer(), 0, (int)ms.Length);
            ms.Close();
            //末尾の\nを削除
            resMsg = resMsg.TrimEnd('\n');
            Console.WriteLine(resMsg);

            foreach (var listeners in ServerConnectionListeners)
            {
                listeners.OnConnectClient(this, resMsg);
            }

            if (!disconnected)
            {
                //クライアントにデータを送信する
                //クライアントに送信する文字列を作成
                string sendMsg = resMsg.Length.ToString();
                //文字列をByte型配列に変換
                byte[] sendBytes = enc.GetBytes(sendMsg + '\n');
                //データを送信する
                ns.Write(sendBytes, 0, sendBytes.Length);
                Console.WriteLine(sendMsg);
            }

            //閉じる
            ns.Close();
            client.Close();
            Console.WriteLine("クライアントとの接続を閉じました。");

            //リスナを閉じる
            listener.Stop();
            Console.WriteLine("Listenerを閉じました。");
        }
    }
}
