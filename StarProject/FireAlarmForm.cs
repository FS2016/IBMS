using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.Xml;
using System.IO.Ports;
using System.Text.RegularExpressions;
using HUSSDKDemo;

namespace FireAlarm
{
    public partial class FireAlarmForm : Form
    {

        CookieContainer cookies = new CookieContainer();
        String BaseUrl;
        Boolean ObixOK = false;
        String ObixAddress;
        int ObixPort;
        String ObixUserName;
        String ObixPassword;
        String dbStr;
        String videoStr;
        int ObixSleepTime;

        //消防报警变量
        private SerialPort comm = new SerialPort();
        private StringBuilder builder = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。
        private long received_count = 0;//接收计数
        private long send_count = 0;//发送计数

        public FireAlarmForm()
        {

            InitializeComponent();
            //区域及点位查出guid
            //   SDataHepler.getGuid("111", "2222");
            //容器初始化完成后调用连接方法
            MainDialog_Load();

            openOperate("COM2");
        }

        /**
         *初始化应用配置 
         * */
        private void MainDialog_Load()
        {
            IniFiles ConfigFile = new IniFiles("Config.ini");

            ObixAddress = ConfigFile.ReadString("OBIX", "Address", "192.168.1.113");
            ObixPort = ConfigFile.ReadInteger("OBIX", "Port", 82);
            ObixUserName = ConfigFile.ReadString("OBIX", "UserName", "admin");
            ObixPassword = ConfigFile.ReadString("OBIX", "Password", "");
            ObixSleepTime = ConfigFile.ReadInteger("OBIX", "SleepTime", 5000);
            //视屏对应的文件夹
            videoStr = ConfigFile.ReadString("OBIX", "videoStr", "S1");
            //访问项目地址
            BaseUrl = String.Format("http://{0}:{1}/", ObixAddress, ObixPort);
            //数据库地址
            dbStr = ConfigFile.ReadString("MYSQL", "dbStr", "Database=test;Data Source=127.0.0.1;User Id=root;Password=root;pooling=false;CharSet=utf8;port=3306");
            //与obix建立连接 需放开注释
            connectServer();
            //   String area = "Fire";
            // String point = "F1";
            /**
             * area 区域
             * point 点位
             * 
             *    emergencyActive 开启
                  emergencyInactive 关闭
                  emergencyAuto 复位
             * 
             * */
            // String op = "emergencyActive";
            // getPonitInfo();
            //改变状态方法 需放开注释
            //  sendChange(area, point, op);
            //测试定时任务
            // testTimer();

            //消防
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);


            //初始化SerialPort对象
            comm.NewLine = "\r\n";
            comm.RtsEnable = true;//根据实际情况吧。

            //添加事件注册
            comm.DataReceived += comm_DataReceived;

        }
        /**
         * 1、定时任务扫描视所有视频点当
         * 发现有一个视频点状态为true，
         * 查询数据库找到对应的视频id
         * 2、将该文件夹下的所有视频点状态置为false
         * */
        private void findVideoIsTrue()
        {
            String Log;
            String FolderUrl;
            String PointName;

            FolderUrl = String.Format("{0}obix/config/{1}", BaseUrl, videoStr);

            NewXmlControl FolderXml = new NewXmlControl(HttpHelper.SendDataByGET(FolderUrl, "", ref cookies));

            XmlNodeList RefList = FolderXml.objXmlDoc.GetElementsByTagName("ref");
            foreach (XmlNode RefPoint in RefList)
            {
                int i = 0;
                XmlElement RefItem = (XmlElement)RefPoint;
                PointName = RefItem.GetAttribute("name");
                String RefHref = RefItem.GetAttribute("href");
                String RefIs = RefItem.GetAttribute("is");
                String status = RefItem.GetAttribute("display");

                if (PointName != null && "true {overridden} @ 1".Equals(status) && i == 0)
                {
                    i = 1;
                    //此处调用弹出视频方法，查询对应视频点的guid
                    Console.WriteLine(PointName + "====" + status);
                    //查询改点对应的guid
                    // String guid = "";// DataHepler.getGuidByPoint(PointName, dbStr);
                    String guid = "";
                    //区域及点位查出guid
                    SDataHepler.getGuid("111", "2222");
                    if (guid != null && guid == "")
                    {
                        //调用 打开视频方法
                        Console.WriteLine("打开视频方法!");
                        Form_PlayVideo form_PlayVideo = new Form_PlayVideo();
                        form_PlayVideo.startSingleVideo(guid);
                        //将视频点为true的点位置为false
                        sendChange(videoStr, PointName, "emergencyInactive");
                    }
                    else
                    {
                        Console.WriteLine("请检查点位 " + PointName + " 对应的字典表数据！");
                    }

                    Log = String.Format("探测到新数据点 [ {0} ]，加载成功！", PointName);
                    AddLog(UserDefine.LOG_LEVEL_1, UserDefine.SUCCESS_LOG, UserDefine.OBIX_LOG, Log);
                }
            }
        }


        /**
         * 测试查询及插入方法
         * 
         * */
        public void getPonitInfo()
        {
            // FireInfo info = DataHepler.getInfoByTerm("term", dbStr);
            // Console.WriteLine("编号:" + info.Id + "|term:" + info.Term + "|DESC:" + info.Desc + "|P:" + info.Point);
            FireInfo fireInfo = new FireInfo();
            fireInfo.Term = "哈哈";
            fireInfo.Desc = "描述";
            fireInfo.Area = "区域";
            fireInfo.Point = "点位";
            //是否还需存火灾报警信息
            // DataHepler.addFireInfoHis(videoStr, fireInfo);
        }



        /**
         * 与远程机建立连接
         * 
         * 
         * **/
        private void connectServer()
        {
            BaseUrl = String.Format("http://{0}:{1}/", ObixAddress, ObixPort);
            String LoginUrl = BaseUrl + "Login";
            String ObixUrl = BaseUrl + "obix";

            byte[] bytes = Encoding.Default.GetBytes(ObixUserName + ":" + ObixPassword);
            String LoginParam = "token=" + Convert.ToBase64String(bytes);

            String Result = HttpHelper.SendDataByPost(LoginUrl, LoginParam, ref cookies);

            if (Result.Length > 0)
            {
                Console.WriteLine("Niagara连接成功！");
                Result = HttpHelper.SendDataByGET(ObixUrl, "", ref cookies);
                if (Result.Substring(0, 5).CompareTo("<?xml") == 0)
                {
                    ObixOK = true;
                    Console.WriteLine("Niagara登陆成功！");
                }
                else
                {
                    ObixOK = false;
                    Console.WriteLine("Niagara登陆失败，请检查用户账号或确认是否配置有Obix网络！");
                }
            }
            else
            {
                ObixOK = false;
                Console.WriteLine("Niagara连接失败，请检查IP地址或路由设置！");
            }


            if (ObixOK)
            {
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Enabled = true;
                timer.Interval = ObixSleepTime;//执行间隔时间,单位为毫秒
                timer.Start();
                timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_Elapsed);

            }

        }




        //发送修改操作
        /** 消防报警
         * area 区域
         * point 点位
         * op 操作
        *
         *  emergencyActive 开启
            emergencyInactive 关闭
            emergencyAuto 复位
         *
         * 
         * */
        public void sendChange(String area, String point, String op)
        {
            // 给该点发送emergencyAuto指令，复位
            String PointUrl;
            PointUrl = String.Format("{0}obix/config/{1}/{2}/{3}/", BaseUrl, area, point, op);
            String AutoParam = "<obj href=\"obix:Nil\" null=\"true\"/>";
            HttpHelper.SendDataByPost(PointUrl, AutoParam, ref cookies);
        }





        //定时任务
        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //找到对应的视频点打开视频
            findVideoIsTrue();
            // 得到 hour minute second  如果等于某个值就开始执行某个程序。
            int intHour = e.SignalTime.Hour;
            int intMinute = e.SignalTime.Minute;
            int intSecond = e.SignalTime.Second;
            // Console.WriteLine("扫描视频点任务！");

        }


        private void AddLog(int LogLevel, int LogType, int LogFrom, String LogMsg)
        {
            Console.WriteLine(LogMsg);
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // 设置隐藏
            this.Visible = false;

        }

        //串口通信
        void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = comm.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            received_count += n;//增加接收计数
            comm.Read(buf, 0, n);//读取缓冲数据
            builder.Clear();//清除字符串构造器的内容
            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke((EventHandler)(delegate
            {
                //判断是否是显示为16进制
                if (checkBoxHexView.Checked)
                {
                    //依次的拼接出16进制字符串
                    foreach (byte b in buf)
                    {
                        builder.Append(b.ToString("X2") + " ");
                    }
                }
                else
                {
                    //直接按ASCII规则转换成字符串
                    builder.Append(Encoding.ASCII.GetString(buf));
                }
                //追加的形式添加到文本框末端，并滚动到最后。
                this.txGet.AppendText(builder.ToString());
                //MessageBox.Show(builder.ToString());
                Console.WriteLine(builder.ToString());
                DataHandle dataHandle = new DataHandle();
                dataHandle.dataBagParse(builder.ToString());
                //修改接收计数
                labelGetCount.Text = "Get:" + received_count.ToString();
            }));
        }

        //******************函数调用时触发**************************************//
        public void openOperate(string portName)
        {
            comm.PortName = portName;
            comm.BaudRate = int.Parse("9600");
            try
            {
                comm.Open();
            }
            catch (Exception ex)
            {
                //捕获到异常信息，创建一个新的comm对象，之前的不能用了。
                comm = new SerialPort();
                //现实异常信息给客户。
                MessageBox.Show(ex.Message);
            }
            // }
            //设置按钮的状态
            buttonOpenClose.Text = comm.IsOpen ? "Close" : "Open";
            buttonSend.Enabled = comm.IsOpen;
        }

        //******************点击按钮时触发*********************************//
        private void buttonOpenClose_Click(object sender, EventArgs e)
        {
            //根据当前串口对象，来判断操作
            // if (comm.IsOpen)
            // {
            //打开时点击，则关闭串口
            //   comm.Close();
            // }
            // else
            //  {
            //关闭时点击，则设置好端口，波特率后打开
            comm.PortName = "COM3";
            comm.BaudRate = int.Parse("9600");
            try
            {
                comm.Open();
            }
            catch (Exception ex)
            {
                //捕获到异常信息，创建一个新的comm对象，之前的不能用了。
                comm = new SerialPort();
                //现实异常信息给客户。
                MessageBox.Show(ex.Message);
            }
            // }
            //设置按钮的状态
            buttonOpenClose.Text = comm.IsOpen ? "Close" : "Open";
            buttonSend.Enabled = comm.IsOpen;

        }

        //动态的修改获取文本框是否支持自动换行。


        private void buttonSend_Click(object sender, EventArgs e)
        {
            //定义一个变量，记录发送了几个字节
            int n = 0;
            //16进制发送
            if (checkBoxHexSend.Checked)
            {
                //我们不管规则了。如果写错了一些，我们允许的，只用正则得到有效的十六进制数
                MatchCollection mc = Regex.Matches(txSend.Text, @"(?i)[\da-f]{2}");
                List<byte> buf = new List<byte>();//填充到这个临时列表中
                //依次添加到列表中
                foreach (Match m in mc)
                {
                    buf.Add(byte.Parse(m.Value));
                }
                //转换列表为数组后发送
                comm.Write(buf.ToArray(), 0, buf.Count);
                //记录发送的字节数
                n = buf.Count;
            }
            else//ascii编码直接发送
            {
                //包含换行符
                if (checkBoxNewlineSend.Checked)
                {
                    comm.WriteLine(txSend.Text);
                    n = txSend.Text.Length + 2;
                }
                else//不包含换行符
                {
                    comm.Write(txSend.Text);
                    n = txSend.Text.Length;
                }
            }
            send_count += n;//累加发送字节数
            labelSendCount.Text = "Send:" + send_count.ToString();//更新界面

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //复位接受和发送的字节数计数器并更新界面。
            send_count = received_count = 0;
            labelGetCount.Text = "Get:0";
            labelSendCount.Text = "Send:0";
        }


        private void txGet_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenClose_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBoxHexView_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNewlineSend_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHexSend_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSendCount_Click(object sender, EventArgs e)
        {

        }



    }
}
