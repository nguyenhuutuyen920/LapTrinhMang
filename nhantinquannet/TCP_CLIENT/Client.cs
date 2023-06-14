using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTcp;
using System.Windows.Forms;

namespace TCP_CLIENT
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;
        private void Send_Btn_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                client.Send(Msg_TxtBox.Text);
                Info_TxtBox.Text += $"Me: {Msg_TxtBox.Text}{Environment.NewLine}";
                Msg_TxtBox.Text = string.Empty;
            }
        }

        private void Connect_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                client = new(IP_TxtBox.Text);
                client.Events.Connected += Events_Connected;
                client.Events.Disconnected += Events_Disconnected;
                client.Events.DataReceived += Events_DataReceived;
                Send_Btn.Enabled = false;
                try
                {
                    client.Connect();
                    //Send_Btn.Enabled = true;
                    Connect_Btn.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valid server ip with ports", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Send_Btn.Enabled = false;
            Connect_Btn.Enabled = false;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Info_TxtBox.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Info_TxtBox.Text += $"Server Disconnected.{Environment.NewLine}";
                Connect_Btn.Enabled = true;
            });
        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Info_TxtBox.Text += $"Server Connected.{Environment.NewLine}";
            });
        }

        private void IP_TxtBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (IP_TxtBox.Text == "Enter server IP")
            {
                IP_TxtBox.Text = string.Empty;
            }
        }
        private void IP_TxtBox_MouseLeave(object sender, EventArgs e)
        {
            if (IP_TxtBox.Text == string.Empty)
            {
                IP_TxtBox.Text = "Enter server IP";
            }
        }

        private void IP_TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (IP_TxtBox.Text == "Enter server IP" || IP_TxtBox.Text == string.Empty)
            {
                Connect_Btn.Enabled = false;
            }
            else
            {
                Connect_Btn.Enabled = true;
            }
        }

        private void Msg_TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (Msg_TxtBox.Text == string.Empty)
            {
                Send_Btn.Enabled = false;
            }
            else
            {
                Send_Btn.Enabled = true;
            }
        }
    }
}
