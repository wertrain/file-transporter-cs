using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTPLib;

namespace FTPR
{
    public partial class FormMain : Form, ServerConnectionListener, ClientConnectionListener
    {
        /// <summary>
        /// 
        /// </summary>
        private string LocalHostAddress { get; set; } = "127.0.0.1";

        /// <summary>
        /// 
        /// </summary>
        private int PrimaryPort { get; set; } = 4567;

        /// <summary>
        /// 
        /// </summary>
        private int SecondaryPort { get; set; } = 7891;


        public FormMain()
        {
            InitializeComponent();

            _server = new FTPLib.Server();
            _server.AddListener(this);

            toolStripStatusLabelConnectionState.Text = "サーバの開始に失敗しました";
            int[] ports = { PrimaryPort, SecondaryPort };
            foreach (var port in ports)
            {
                if (_server.Start(LocalHostAddress, port))
                {
                    toolStripStatusLabelConnectionState.Text = "サーバ [" + port + "]";
                    break;
                }
            }
        }

        private void toolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItemUpdateClientList_Click(object sender, EventArgs e)
        {
            _client = new Client();
            _client.AddListener(this);

            if (!_client.Start(LocalHostAddress, PrimaryPort))
            {
                MessageBox.Show("エラー", "クライアントの起動に失敗しました");
            }
        }

        public void OnDataReceiving(Server server, byte[] data)
        {
            MessageBox.Show("受信");
            //throw new NotImplementedException();
        }

        public void OnFileReceived(Server server, byte[] data)
        {
            throw new NotImplementedException();
        }

        public void OnConnectClient(Server server, string address)
        {

            Invoke((MethodInvoker)(() =>
            {
                var item = new ListViewItem(address);
                var subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = address;
                item.SubItems.Add(subItem);
                listViewClients.Items.Add(item);
            }));
        }

        public void OnDataReceiving(Client client, byte[] data)
        {
            MessageBox.Show("送り返された");
        }

        public void OnConnectServer(Client client, string address)
        {
            Invoke((MethodInvoker)(() =>
            {
                var item = new ListViewItem(address);
                var subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = address;
                item.SubItems.Add(subItem);
                item.Checked = false;
                listViewClients.Items.Add(item);
            }));
        }

        Server _server;
        Client _client;
    }
}
