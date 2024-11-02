using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;

namespace pro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CancellationTokenSource cts = new CancellationTokenSource();

        private Socket tcp_client;

        private void connectPLC_Click(object sender, EventArgs e)
        {
            if (connectPLC.Text == "连接")
            {
                try
                {
                    // 关闭旧的连接（如果有）
                    tcp_client?.Close();
                    // 创建新的Socket实例
                    tcp_client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    EndPoint ep = new IPEndPoint(IPAddress.Parse(plcaddr.Text), Convert.ToInt32(plcport.Text));
                    tcp_client.Connect(ep);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误: " + ex.ToString());
                    return;
                }
                MessageBox.Show("连接成功");
                connectPLC.Text = "断开";
                connectPLC.BackColor = System.Drawing.Color.OrangeRed;

                // 创建新的CancellationTokenSource实例
                cts = new CancellationTokenSource();
                Task.Run(new Action(() =>
                {
                    get_Plc_data();
                }), cts.Token);
            }
            else
            {
                // 关闭连接并取消任务
                if (tcp_client != null)
                {
                    tcp_client.Close();
                }
                cts.Cancel();
                MessageBox.Show("已关闭连接");
                connectPLC.Text = "连接";
                connectPLC.BackColor = System.Drawing.Color.Silver;
            }
        }

        private void get_Plc_data()
        {
            int len = -1;
            while (!cts.IsCancellationRequested && tcp_client != null && tcp_client.Connected)
            {
                byte[] data = new byte[1024 * 5];
                try
                {
                    len = tcp_client.Receive(data, SocketFlags.None);
                }
                catch (Exception)
                {
                    
                    break;
                }
                if (len >= 0)
                {
                    byte[] ret = ByteArrayLib.GetByteArrayFromByteArray(data, 0, len);
                    Invoke(new Action(() =>
                    {
                        foreach (Control c in this.tabPage1.Controls)
                        {
                            if (c is recvShow rs)
                            {
                                switch (rs.DataType)
                                {
                                    case DataType.Byte:
                                        rs.VarString = ByteLib.GetByteFromByteArray(data,rs.Start).ToString();
                                        break;
                                    case DataType.Bool:
                                        rs.VarString = BitLib.GetBitFromByteArray(data, rs.Start, rs.Offset).ToString();
                                        break;
                                    case DataType.Short:
                                        rs.VarString = ShortLib.GetShortFromByteArray(data, rs.Start).ToString();
                                        break;
                                    case DataType.UShort:
                                        rs.VarString = UShortLib.GetUShortFromByteArray(data, rs.Start).ToString();
                                        break;
                                    case DataType.Int:
                                        rs.VarString = IntLib.GetIntFromByteArray(data, rs.Start).ToString();
                                        break;
                                    case DataType.UInt:
                                        rs.VarString = UIntLib.GetUIntFromByteArray(data, rs.Start).ToString();
                                        break;
                                    case DataType.Float:
                                        rs.VarString = FloatLib.GetFloatFromByteArray(data, rs.Start).ToString();
                                        break;
                                    case DataType.Double:
                                        rs.VarString = DoubleLib.GetDoubleFromByteArray(data, rs.Start).ToString();
                                        break;
                                    default:
                                        break;

                                }
                            }
                        }
                    }));
                }
            }
        }

        /*********************************************************************/

        private Socket tcp_server;

        private void openServer_Click(object sender, EventArgs e)
        {
            if (openServer.Text == "打开")
            {
                try
                {
                    tcp_server?.Close();
                    tcp_server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    EndPoint ep = new IPEndPoint(IPAddress.Parse(localaddr.Text), Convert.ToInt32(localport.Text));
                    tcp_server.Bind(ep);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误:"+ex.Message);
                    return;
                }
                MessageBox.Show("已打开服务");
                openServer.Text = "关闭";
                openServer.BackColor = System.Drawing.Color.OrangeRed;

                tcp_server.Listen(5); // 开启监听  最大同时5个客户端连接
                Task.Run(new Action(() =>
                {
                    ListeningConn();
                }));


            }
            else
            {
                tcp_server?.Close();
                MessageBox.Show("已关闭服务");
                openServer.Text = "打开";
                openServer.BackColor = System.Drawing.Color.Silver;
            }
        }
        private byte[] sendBuf;
        private List<Socket> lis = new List<Socket>();
        private void ListeningConn()
        {
            while (true)
            {
                try
                {
                    Socket tcpCli = tcp_server.Accept();
                    lis.Add(tcpCli);
                    Task.Run(new Action(() =>
                    {
                        recvFromPLCData(tcpCli);// 传递客户端连接,区分服务
                    }));
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        private void recvFromPLCData(Socket tcpCli)
        {
            while (true)
            {
                int len = -1;
                byte[] data = new byte[1024 * 5];
                try
                {
                    len = tcpCli.Receive(data, SocketFlags.None);
                }
                catch (Exception)
                {
                    break;
                }
                if (len >= 0)
                {
                    Console.WriteLine($"收到的字节数:{len}");
                    byte[] ret = ByteArrayLib.GetByteArrayFromByteArray(data, 0, len);
                    sendBuf = ByteArrayLib.GetByteArrayFromByteArray(data, 16, len);
                    Invoke(new Action(() =>
                    {
                        foreach (Control c in this.tabPage2.Controls)
                        {
                            if (c is recvShow rs)
                            {
                                switch (rs.DataType)
                                {
                                    case DataType.Byte:
                                        rs.VarString = ByteLib.GetByteFromByteArray(data, rs.Start).ToString();
                                        break;
                                    case DataType.Bool:
                                        rs.VarString = BitLib.GetBitFromByteArray(data, rs.Start, rs.Offset).ToString();
                                        break;
                                    case DataType.Short:
                                        rs.VarString = ShortLib.GetShortFromByteArray(data, rs.Start).ToString();
                                        break;
                                    case DataType.UShort:
                                        rs.VarString = UShortLib.GetUShortFromByteArray(data, rs.Start).ToString();
                                        break;
                                    case DataType.Int:
                                        rs.VarString = IntLib.GetIntFromByteArray(data, rs.Start).ToString();
                                        break;
                                    case DataType.UInt:
                                        rs.VarString = UIntLib.GetUIntFromByteArray(data, rs.Start).ToString();
                                        break;
                                    case DataType.Float:
                                        rs.VarString = FloatLib.GetFloatFromByteArray(data, rs.Start).ToString();
                                        break;
                                    case DataType.Double:
                                        rs.VarString = DoubleLib.GetDoubleFromByteArray(data, rs.Start).ToString();
                                        break;
                                    default:
                                        break;

                                }
                            }
                        }
                    }));
                }

            }
        }
        private int sendCount;
        private void writeToplc_Click(object sender, EventArgs e)
        {
            float val = Convert.ToSingle(sendDat.Text); 
            byte[] setBuf = ByteArrayLib.SetByteArray(sendBuf, val, 0, 0);
            sendCount = lis[0].Send(setBuf);
            Console.WriteLine(sendCount);
            
        }
    }
}