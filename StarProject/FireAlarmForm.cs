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

        public FireAlarmForm()
        {

            InitializeComponent();
            //区域及点位查出guid
            //   SDataHepler.getGuid("111", "2222");
            //容器初始化完成后调用连接方法
            MainDialog_Load();
        }

        /**
         *初始化应用配置 
         * */
        private void MainDialog_Load()
        {
            IniFiles ConfigFile = new IniFiles("Config.ini");

            ObixAddress = ConfigFile.ReadString("OBIX", "Address", "192.168.1.101");
            ObixPort = ConfigFile.ReadInteger("OBIX", "Port", 82);
            ObixUserName = ConfigFile.ReadString("OBIX", "UserName", "admin");
            ObixPassword = ConfigFile.ReadString("OBIX", "Password", "");
            ObixSleepTime = ConfigFile.ReadInteger("OBIX", "SleepTime", 30000);
            //视屏对应的文件夹
            videoStr = ConfigFile.ReadString("OBIX", "videoStr", "S1");
            //访问项目地址
            BaseUrl = String.Format("http://{0}:{1}/", ObixAddress, ObixPort);
            //数据库地址
            //dbStr = ConfigFile.ReadString("MYSQL", "dbStr", "Database=test;Data Source=127.0.0.1;User Id=root;Password=root;pooling=false;CharSet=utf8;port=3306");
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
            bool flag = true;
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
                    //String guid = "";
                    //区域及点位查出guid
                    String guid = SDataHepler.getGuid(null, PointName);
                    if (guid != null && guid != "" && flag)
                    {
                        //将视频点为true的点位置为false
                        sendChange(videoStr, PointName, "emergencyInactive");
                        //调用 打开视频方法
                        Console.WriteLine(PointName+"打开视频方法!");
                        Form_PlayVideo form_PlayVideo = new Form_PlayVideo();
                        form_PlayVideo.startSingleVideo(guid);
                        flag = false;
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

    }
}
