using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HUSSDKDemo;

namespace ProwatchListener
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 保存连接的所有用户
        /// </summary>
        private List<User> userList = new List<User>();

        /// <summary>
        /// 使用本机IP地址
        /// </summary>
        IPAddress localAddress;

        /// <summary>
        /// 监听端口
        /// </summary>
        private const int port = 2894;
        private TcpListener myTcpListener;

        /// <summary>
        /// 是否正常退出所有接收线程
        /// </summary>
        bool isNormalExit = false;

        public MainForm()
        {
            InitializeComponent();
            listBoxStatus.HorizontalScrollbar = true;
//             IPAddress[] addrIP = Dns.GetHostAddresses(Dns.GetHostName());
//             localAddress = addrIP[0];
//            localAddress = new IPAddress(new byte[]{10,15,16,200});10.15.16.208
            localAddress = new IPAddress(new byte[] { 127, 0, 0, 1 });
            buttonStop.Enabled = false;
            start_listen();

        }

        private void start_listen() {
            myTcpListener = new TcpListener(localAddress, port);
            myTcpListener.Start();
            AddItemToListBox(String.Format("开始在{0}:{1}上监听客户连接", localAddress, port));
            //创建一个线程监听客户端连接请求
            Thread myThread = new Thread(ListenClientConnect);
            myThread.Start();
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;
        }

        /// <summary>
        /// 开始监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            myTcpListener = new TcpListener(localAddress, port);
            myTcpListener.Start();
            AddItemToListBox(String.Format("开始在{0}:{1}上监听客户连接",localAddress,port));
            //创建一个线程监听客户端连接请求
            Thread myThread = new Thread(ListenClientConnect);
            myThread.Start();
            buttonStop.Enabled=true;
            buttonStart.Enabled = false;

        }

        /// <summary>
        /// 接收客户端连接
        /// </summary>
        private void ListenClientConnect()
        {
            TcpClient newClient = null;
            while (true)
            {
                try
                {
                    newClient = myTcpListener.AcceptTcpClient();
                }
                catch 
                {
                    break;
                }

                User user = new User(newClient);
                Thread threadReceive = new Thread(ReceiveData);
                threadReceive.Start(user);
                userList.Add(user);
                AddItemToListBox(String.Format("{0}进入",newClient.Client.RemoteEndPoint));
                AddItemToListBox(String.Format("当前连接数{0}", userList.Count));
            }
        }
        /// <summary>
        /// 处理接收的客户端数据
        /// </summary>
        /// <param name="userState"></param>
        private void ReceiveData(object userState)
        {
            User user = (User)userState;
            TcpClient client = user.client;
            while (isNormalExit == false)
            {
                string receiveString = null;
                try
                {
                    //从网络流中读出字符串,此方法会自动判断字符串长度前缀
                    receiveString = user.br.ReadString();
                }
                catch (System.Exception ex)
                {
                    if (isNormalExit==false)
                    {
                        AddItemToListBox(String.Format("与{0}失去联系,已终止接收该用户信息", client.Client.RemoteEndPoint));
                        RemoveUser(user);
                    }
                    break;
                }
                
                AddItemToListBox(String.Format("来自{0}:{1}", client.Client.RemoteEndPoint, receiveString));
                switch(receiveString)
                {
                    case "Login":
                        //user.userName = splitString[1];
                        SendToAllClient(user, receiveString);
                        break;
                    default:
                        AddItemToListBox("接收到信息：" + receiveString);
                       Form_LiveView form_LiveView= new Form_LiveView();
                       form_LiveView.startSingleVideo(receiveString);
                        Console.WriteLine("接收到信息：" + receiveString);
                        break;
                }
            }

            
        }

        /// <summary>
        /// 发送message给user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        private void SendToClient(User user, string message)
        {

        }

        /// <summary>
        /// 发送信息给所有用户
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        private void SendToAllClient(User user, string message)
        {

        }

        /// <summary>
        /// 移除用户
        /// </summary>
        private void RemoveUser(User user)
        {
            userList.Remove(user);
            user.Close();
            AddItemToListBox(String.Format("当前连接用户数{0}", userList.Count));
        }

        private delegate void AddItemToListBoxDelegate(string str);
        /// <summary>
        /// 在listbox中追加状态信息
        /// </summary>
        /// <param name="str"></param>
        private void AddItemToListBox(string str)
        {
            if (listBoxStatus.InvokeRequired)
            {
                AddItemToListBoxDelegate d = AddItemToListBox;
                listBoxStatus.Invoke(d,str);
            } 
            else
            {
                listBoxStatus.Items.Add(str);
                listBoxStatus.SelectedIndex = listBoxStatus.Items.Count - 1;
                listBoxStatus.ClearSelected();
            }
        }

        /// <summary>
        /// 停止监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            AddItemToListBox("开始停止服务，并依次退出用户");
            isNormalExit = true;
            for (int i = userList.Count - 1; i >= 0;i-- )
            {
                RemoveUser(userList[i]);
            }

            //通过停止监听让myListener.AcceptTcpClient()产生异常退出监听线程
            myTcpListener.Stop();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        /// <summary>
        /// 关闭窗口时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myTcpListener != null)
            {
                buttonStop.PerformClick();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // 设置隐藏
            this.Visible = false;

        }


        
    }
}
