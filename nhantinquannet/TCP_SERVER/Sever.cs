using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTcp;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TCP_SERVER
{
    public partial class Sever : Form
    {
        public Sever()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        
        private void Start_Btn_Click(object sender, EventArgs e)
        {
            server.Start();
            Info_TxtBox.Text += $"Server Started...{Environment.NewLine}";
            Start_Btn.Enabled = false;
            Send_Btn.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            IPHostEntry IPH;
            string My_IP = "";
            IPH = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in IPH.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    My_IP = ip.ToString();
                }
            }
            IP_TxtBox.Text = My_IP.ToString() + ":9000";
            Send_Btn.Enabled = false;
            server = new SimpleTcpServer(IP_TxtBox.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;

        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Info_TxtBox.Text += $"{SystemInformation.ComputerName}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Info_TxtBox.Text += $"{e.IpPort} Disconnected. {Environment.NewLine}";
                Client_IP_List.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
             {
                Info_TxtBox.Text += $"{Environment.UserName + " - " + SystemInformation.ComputerName + ""} Connected from {e.IpPort}{Environment.NewLine}";
                 Client_IP_List.Items.Add(e.IpPort);
             });
        }

        private void Send_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (server.IsListening)
                {
                    if (!string.IsNullOrEmpty(Msg_TxtBox.Text) && Client_IP_List.SelectedItem != null)
                    {
                        server.Send(Client_IP_List.SelectedItem.ToString(), Msg_TxtBox.Text);
                        Info_TxtBox.Text += $"Server: {Msg_TxtBox.Text} ( {Client_IP_List.SelectedItem} ) {Environment.NewLine}";
                        Msg_TxtBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
