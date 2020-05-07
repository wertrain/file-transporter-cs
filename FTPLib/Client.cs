using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FTPLib
{
    public interface ClientConnectionListener
    {
        void OnConnectServer(string address);
    }

    public class Client
    {
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

        private void listen(System.Net.Sockets.TcpClient client)
        {
            //NetworkStreamを取得する
            System.Net.Sockets.NetworkStream ns = client.GetStream();
            
            //読み取り、書き込みのタイムアウトを10秒にする
            //デフォルトはInfiniteで、タイムアウトしない
            //(.NET Framework 2.0以上が必要)
            ns.ReadTimeout = 10000;
            ns.WriteTimeout = 10000;

            // ホスト名を取得する
            string hostname = Dns.GetHostName();

            // ホスト名からIPアドレスを取得する
            IPAddress[] adrList = Dns.GetHostAddresses(hostname);

            //サーバーにデータを送信する
            //文字列をByte型配列に変換
            Encoding enc = Encoding.UTF8;
            byte[] sendBytes = enc.GetBytes(adrList[0].ToString() + '\n');
            //データを送信する
            ns.Write(sendBytes, 0, sendBytes.Length);

            //サーバーから送られたデータを受信する
            var ms = new MemoryStream();
            byte[] resBytes = new byte[256];
            int resSize = 0;
            do
            {
                //データの一部を受信する
                resSize = ns.Read(resBytes, 0, resBytes.Length);
                //Readが0を返した時はサーバーが切断したと判断
                if (resSize == 0)
                {
                    Console.WriteLine("サーバーが切断しました。");
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

            //閉じる
            ns.Close();
            client.Close();
            Console.WriteLine("切断しました。");
        }
    }
}
