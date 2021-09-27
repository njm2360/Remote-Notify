using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SmallBasic.Library;

namespace ESP_Notifycation
{
    public partial class NotificationApp : Form
    {
        public bool flag = false;
        public bool lightpos = false;
        public bool lightneg = false;
        public string ip, port,temprature,huminoid,presure,lux;
        public int lastlux, nowlux;
        public int wdttimer = 0;

        private System.Net.Sockets.UdpClient udpClient = null;

        public NotificationApp()
        {
            InitializeComponent();
        }

        private void wdt_Tick(object sender, EventArgs e)
        {
            wdttimer++;
            if(wdttimer > 5)
            {
                StatusText.Text = "WDTタイムアウト";
                this.TopMost = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Disconnect.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            radioButton1.Checked = true;
            threshold.Value = 100;
            lastlux = decimal.ToInt32(threshold.Value);
            StatusText.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            System.Net.Sockets.UdpClient udp =(System.Net.Sockets.UdpClient)ar.AsyncState;

            System.Net.IPEndPoint remoteEP = null;
            byte[] rcvBytes;
            try
            {
                rcvBytes = udp.EndReceive(ar, ref remoteEP);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                Console.WriteLine("受信エラー({0}/{1})",
                    ex.Message, ex.ErrorCode);
                return;
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine("Socketは閉じられています。");
                return;
            }

            string rcvMsg = System.Text.Encoding.UTF8.GetString(rcvBytes);

            if (rcvMsg.Substring(0, 1) == "T")
            {
                temprature = rcvMsg.Substring(2);
            }
            if (rcvMsg.Substring(0, 1) == "H")
            {
                huminoid = rcvMsg.Substring(2) + "%";
            }
            if (rcvMsg.Substring(0, 1) == "P")
            {
                presure = rcvMsg.Substring(2);
            }
            if (rcvMsg.Substring(0, 1) == "L")
            {
                lux = rcvMsg.Substring(2);
                nowlux = int.Parse(lux);
                if (radioButton1.Checked == true)
                {
                    //neg edge
                    if(lastlux > threshold.Value && nowlux < threshold.Value)
                    {
                        lightneg = true;
                    }
                    lastlux = nowlux;
                }
                else
                {
                    //pos edge
                    if (lastlux < threshold.Value && nowlux > threshold.Value)
                    {
                        lightpos = true;
                    }
                    lastlux = nowlux;
                }
            }
            if (rcvMsg == "DETECT")
            {
                flag = true;
            }
            wdttimer = 0;
            port = remoteEP.Port.ToString();
            ip = remoteEP.Address.ToString();
            

            string displayMsg = string.Format("From[{0}:{1}] > {2}", remoteEP.Address, remoteEP.Port, rcvMsg);

            richTextBox1.BeginInvoke(new Action<string>(ShowReceivedString), displayMsg);
            udp.BeginReceive(ReceiveCallback, udp);
        }


        private void ShowReceivedString(string str)
        {
            serverip.Text = ip;
            serverport.Text = port;
            temp.Text = temprature;
            hum.Text = huminoid;
            pres.Text = presure;
            light.Text = lux;
            DateTime dateTime = DateTime.Now;
            String datetime = dateTime.ToString("HH:mm:ss  > ");
            if (recieveenable.Checked == true)
            {
                richTextBox1.Text = datetime + str + "\r\n" + richTextBox1.Text;
            }
            if (flag)
            {
                
                flag = false;
                StatusText.Text = "動きベクトル検出";
                log.Text = datetime + "動きベクトル検出" + "\r\n" + log.Text;
                this.TopMost = true;
            }
            else
            {
            }
            if (lightneg)
            {
                lightneg = false;
                StatusText.Text = "明るさが閾値より低下";
                log.Text = datetime + "明るさが閾値より低下" + "\r\n" + log.Text;

                this.TopMost = true;
            }
            if (lightpos)
            {
                lightpos = false;
                StatusText.Text = "明るさが閾値より上昇";
                log.Text = datetime + "明るさが閾値より上昇" + "\r\n" + log.Text;

                this.TopMost = true;
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            wdt.Enabled = true;
            if (udpClient != null)
            {
                return;
            }
            Connect.Enabled = false;
            try {
                System.Net.IPEndPoint localEP = new System.Net.IPEndPoint(
                System.Net.IPAddress.Any, int.Parse(PCport.Text));
                udpClient = new System.Net.Sockets.UdpClient(localEP);

                udpClient.BeginReceive(ReceiveCallback, udpClient);
                ConnectStatus.Text = "接続";
                Disconnect.Enabled = true;
            }
            catch(FormatException exception)
            {
                Connect.Enabled = true;
                Disconnect.Enabled = false;
                ConnectStatus.Text = "未接続";
                MessageBox.Show("ポート番号エラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void Disconnect_Click(object sender, EventArgs e)
        {
            this.Close();
            if (udpClient != null)
            {
                udpClient.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatusText.Text = "正常";
            this.TopMost =false;
        }

        
    }
}
