using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HUS.Client.Lib.DataModel.BO;
using HUS.MS.LogRecordManager;
using HUS.Client.Lib.SDK;
using CommonFactory;
using VideoDownloader;
using HUS.Client.Lib.InterComm.EC;
using System.Threading;

namespace HUSSDKDemo
{
    public partial class Form_SDKDemo : Form
    {
        private HUS.Client.Lib.SDK.Environment m_aEnvironment;
        private DeviceManagement m_aDeviceManagement;
        private Dictionary<string, Downloader.StoreTask> m_downloadTask = new Dictionary<string, Downloader.StoreTask>();

        // 直播窗口对象
        Form_LiveView m_aLiveViewForm;
        // 日志查询窗口对象
        Form_QueryLog m_aQueryLogForm;
        // NVR查询播放窗口对象
        Form_NVRVideo m_aNVRVideoForm;
        // DVR查询播放窗口对象
        Form_DVRVideo m_aDVRVideoForm;
        // 本地文件播放窗口对象
        Form_LocalVideo m_aLocalVideoForm;
        // 事件处理窗口对象
        Form_HandleAlarm m_aHandleAlarmForm;

        private delegate void AlarmTriggeredHandle(object message);
        private delegate void EventChangedHandle(object message);
        private delegate void StatusChangedHandle(object message);
        private delegate void AlarmStatusChangeHandle(object message);
        private delegate void OnFilePlayHandle(string strFile);

        public Form_SDKDemo()
        {
            InitializeComponent();
            button_LogIn_Click();
        }

        private void Form_SDKDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 主窗口关闭前进行SDK释放操作
            UninitSDK();
        }

        // 添加设备消息处理函数
        void SDKDemo_DeviceAdded(object sender, HUS.Client.Lib.DataModel.ChildEntityAddedEventArgs e)
        {
            string strLog = String.Format("EntityAdded: {0}", e.AddedChild.Name);
        }

        // 删除设备消息处理函数
        void SDKDemo_DeviceDeleted(object sender, EventArgs e)
        {
            ViewEntity entity = sender as ViewEntity;
            if (entity != null && entity.Device != null)
            {
                string strLog = String.Format("EntityDeleted: {0}", entity.Device.Name);
            }
        }

        // 报警触发消息处理函数
        void SDKDemo_AlarmTriggered(object message)
        {
            if (this.InvokeRequired && !this.IsDisposed)
            {
                // 避免非主线程跟窗口控件交互造成的报错
                AlarmTriggeredHandle sh = new AlarmTriggeredHandle(this.SDKDemo_AlarmTriggered);
                this.Invoke(sh, new object[] { message });
            }
            else
            {
                // 转换成消息格式
                HUS.Client.Lib.InterComm.EC.Message mg = message as HUS.Client.Lib.InterComm.EC.Message;

                string strLog = String.Format("AlarmTriggered-Device:{0},Type:{1},Level:{2},FirstTime:{3},Count:{4},LastTime:{5},Detail:{6},ECName:{7}\r\n",
                    mg.SenderName, mg.Type, mg.Level, mg.FirstTime, mg.Count, mg.Time, mg.Detail, mg.ECServerName);

                // 交给事件处理窗口进行处理
                if (m_aHandleAlarmForm != null)
                {
                    DeviceBase db = DeviceManagement.GetInstance().GetDeviceById(new Guid(mg.SenderID));
//                     if (db is StreamerBase)
                    {
                        m_aHandleAlarmForm.AlarmTriggered(message);
                    }
                }
            }
        }

        // 事件触发消息处理函数
        void SDKDemo_EventChanged(object message)
        {
            if (this.InvokeRequired)
            {
                // 避免非主线程跟窗口控件交互造成的报错
                EventChangedHandle sh = new EventChangedHandle(this.SDKDemo_EventChanged);
                this.Invoke(sh, new object[] { message });
            }
            else
            {
                // 转换成消息格式
                HUS.Client.Lib.InterComm.EC.Message mg = message as HUS.Client.Lib.InterComm.EC.Message;

                // 事件列表中的事件多于100个，移除最后一个，避免显示的事件过多
                if (listView_Event.Items.Count>100)
                {
                    listView_Event.Items.RemoveAt(listView_Event.Items.Count - 1);
                }

                // 将事件添加到事件列表的第一行
                ListViewItem lvItem = new ListViewItem(mg.SenderName);
                lvItem.Name = mg.SenderID;
                lvItem.SubItems.Add(mg.Type);
                lvItem.SubItems.Add(mg.Level);
                lvItem.SubItems.Add(mg.Time);
                lvItem.SubItems.Add(mg.Detail);
                lvItem.SubItems.Add(mg.ECServerName);
                listView_Event.Items.Insert(0, lvItem);
            }
        }

        // 状态改变消息处理函数
        void SDKDemo_StatusChanged(object message)
        {
            if (this.InvokeRequired)
            {
                // 避免非主线程跟窗口控件交互造成的报错
                StatusChangedHandle sh = new StatusChangedHandle(this.SDKDemo_StatusChanged);
                this.Invoke(sh, new object[] { message });
            }
            else
            {
                // 转换成消息格式
                HUS.Client.Lib.InterComm.EC.Message mg = message as HUS.Client.Lib.InterComm.EC.Message;

                // 查找并删除设备状态列表中设备已经存在的状态
                ListViewItem[] allItems = listView_Status.Items.Find(mg.SenderID,false);
                if (allItems!=null && allItems.Length>0)
                {
                    foreach (ListViewItem item in allItems)
                    {
                        listView_Status.Items.Remove(item);
                    }
                }

                // 将设备状态添加到设备状态列表中的第一行
                ListViewItem lvItem = new ListViewItem(mg.SenderName);
                lvItem.Name = mg.SenderID;
                lvItem.SubItems.Add(mg.Type);
                lvItem.SubItems.Add(mg.Level);
                lvItem.SubItems.Add(mg.Time);
                lvItem.SubItems.Add(mg.Detail);
                lvItem.SubItems.Add(mg.ECServerName);
                listView_Status.Items.Insert(0, lvItem);
            }
        }

        // 报警状态改变消息处理函数
        void SDKDemo_AlarmStatusChange(object message)
        {
            if (this.InvokeRequired)
            {
                // 避免非主线程跟窗口控件交互造成的报错
                AlarmStatusChangeHandle sh = new AlarmStatusChangeHandle(this.SDKDemo_AlarmStatusChange);
                this.Invoke(sh, new object[] { message });
            }
            else
            {
                // 将消息传递给报警处理窗口进行处理
                if (m_aHandleAlarmForm!=null)
                {
                    m_aHandleAlarmForm.AlarmStatusChange(message);
                }
            }
        }

        // 升级失败消息处理函数
        void SDKDemo_OnUpgradeFailed(string reason, string detail)
        {
            /// 显示升级失败原因
            string strFailMsg = "UpgradeFail!\r\n";
            if (reason == "1")
            {
                // "1" 表示下载失败
                strFailMsg += "Reason: download fail\r\n";
            }
            else if (reason == "2")
            {
                // "2" 表示解压失败
                strFailMsg += "Reason: unzip fail\r\n";
            }
            else if (reason == "3")
            {
                // "3" 表示配置错误
                strFailMsg += "Reason: config error\r\n";
            }
            else if (reason == "4")
            {
                // "4" 表示覆盖失败
                strFailMsg += "Reason: overwrite fail\r\n";
            }
            else if (reason == "5")
            {
                // "5" 表示注册失败
                strFailMsg += "Reason: register fail\r\n";
            }
            strFailMsg += detail;
            Console.WriteLine("Failed reason:{0}, detail:{1}", reason, detail);
        }

        // 下载控件文件播放消息处理函数
        void SDKDemo_OnFilePlay(string strFile)
        {
            if (this.InvokeRequired)
            {
                // 避免非主线程跟窗口控件交互造成的报错
                OnFilePlayHandle sh = new OnFilePlayHandle(this.SDKDemo_OnFilePlay);
                this.Invoke(sh, new object[] { strFile });
            }
            else
            {
                // 打开文件播放窗口播放
                Form_PlayVideo filePlayForm = new Form_PlayVideo(strFile);
                filePlayForm.ShowDialog();
            }
        }

        // SDK初始化
        private bool InitSDK()
        {
            m_aEnvironment = HUS.Client.Lib.SDK.Environment.GetInstance();
            // 关联设备添加消息处理函数
            m_aEnvironment.DeviceAdded += new EventHandler<HUS.Client.Lib.DataModel.ChildEntityAddedEventArgs>(SDKDemo_DeviceAdded);
            // 关联设备删除消息处理函数
            m_aEnvironment.DeviceDeleted += new EventHandler(SDKDemo_DeviceDeleted);
            // 关联报警消息处理函数
            m_aEnvironment.ReceiveAlarmTrigger += new HUS.Client.Lib.InterComm.EC.AlarmTriggerEventHandler(SDKDemo_AlarmTriggered);
            // 关联事件消息处理函数
            m_aEnvironment.ReceiveEventChange += new HUS.Client.Lib.InterComm.EC.DeviceEventChangedEventHandler(SDKDemo_EventChanged);
            // 关联状态消息处理函数
            m_aEnvironment.ReceiveStatusChange += new HUS.Client.Lib.InterComm.EC.DeviceStatusChangedEventHandler(SDKDemo_StatusChanged);
            // 关联报警状态改变消息处理函数
            m_aEnvironment.ReceiveAlarmStatusChange += new HUS.Client.Lib.InterComm.EC.ProcessStatusChangedEventHandler(SDKDemo_AlarmStatusChange);

            // 关联升级失败消息处理函数
            m_aEnvironment.OnUpgradeFailed += new HUS.Client.Lib.SDK.Environment.OnUpgradeFailedDelegate(SDKDemo_OnUpgradeFailed);

            try
            {
                // 使用HUS站点地址，用户名及密码进行登录
                m_aEnvironment.Init(this.textBox_HUSSite.Text, this.textBox_UserName.Text, this.textBox_Password.Text);
            }
            catch (LoginException ex)
            {
                MessageBox.Show(ex.Reason.ToString());
            }

            if (SiteInfo.GetCurrentSite()==null)
            {
                // 获取HUS站点信息失败
                MessageBox.Show("Login Fail!!!");
                return false;
            }

            // 创建设备管理对象并关联到HUS站点
            m_aDeviceManagement = DeviceManagement.GetInstance();
            m_aDeviceManagement.CurrnetSite = m_aEnvironment.CurrentSite;

            // 全局窗口对象赋值，用于录像搜索时使用
            Global.MainForm = this;

            // 创建各个窗口对象
            m_aLiveViewForm = new Form_LiveView();
            m_aQueryLogForm = new Form_QueryLog();
            m_aNVRVideoForm = new Form_NVRVideo();
            m_aDVRVideoForm = new Form_DVRVideo(m_aDeviceManagement);
            m_aLocalVideoForm = new Form_LocalVideo();
            m_aHandleAlarmForm = new Form_HandleAlarm();

            // 创建下载控件对象 此控件只能在主窗体
            if (m_aEnvironment.DownderControl != null)
            {
                pictureBox_Download.Controls.Add(m_aEnvironment.DownderControl);
                m_aEnvironment.DownderControl.Location = new System.Drawing.Point(0, 0);
                m_aEnvironment.DownderControl.Size = new System.Drawing.Size(pictureBox_Download.Size.Width, pictureBox_Download.Size.Height);
                m_aEnvironment.DownderControl.Anchor =
                    ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top)));
                
                // 添加下载控件中的文件播放消息的处理函数
                m_aEnvironment.DownderControl.OnFilePlay += new VideoDownloader.Downloader.OnFilePlayDelegate(SDKDemo_OnFilePlay);
            }
            return true;
        }

        // 释放SDK资源
        private void UninitSDK()
        {
            if (m_aEnvironment != null)
            {
                // 取消消息处理函数的关联
                if (m_aEnvironment.DownderControl!=null)
                {
                    m_aEnvironment.DownderControl.OnFilePlay -= new VideoDownloader.Downloader.OnFilePlayDelegate(SDKDemo_OnFilePlay);
                }

                m_aEnvironment.OnUpgradeFailed -= new HUS.Client.Lib.SDK.Environment.OnUpgradeFailedDelegate(SDKDemo_OnUpgradeFailed);

                m_aEnvironment.DeviceAdded -= new EventHandler<HUS.Client.Lib.DataModel.ChildEntityAddedEventArgs>(SDKDemo_DeviceAdded);
                m_aEnvironment.DeviceDeleted -= new EventHandler(SDKDemo_DeviceDeleted);
                m_aEnvironment.ReceiveAlarmTrigger -= new HUS.Client.Lib.InterComm.EC.AlarmTriggerEventHandler(SDKDemo_AlarmTriggered);
                m_aEnvironment.ReceiveEventChange -= new HUS.Client.Lib.InterComm.EC.DeviceEventChangedEventHandler(SDKDemo_EventChanged);
                m_aEnvironment.ReceiveStatusChange -= new HUS.Client.Lib.InterComm.EC.DeviceStatusChangedEventHandler(SDKDemo_StatusChanged);
                m_aEnvironment.ReceiveAlarmStatusChange -= new HUS.Client.Lib.InterComm.EC.ProcessStatusChangedEventHandler(SDKDemo_AlarmStatusChange);

                m_aEnvironment.UnInit();
                m_aEnvironment = null;
            }

            if (m_aDeviceManagement != null)
            {
                m_aDeviceManagement = null;
            }
        }
        //登录方法
        private void button_LogIn_Click()
        {
            UninitSDK();
            if (InitSDK() == true)
            {
                button_LiveView.Enabled = true;
                button_QueryLog.Enabled = true;
                button_NVRVideo.Enabled = true;
                button_DVRVideo.Enabled = true;
                button_LocalVideo.Enabled = true;
                button_HandleAlarm.Enabled = true;

                textBox_HUSSite.Enabled = false;
                textBox_UserName.Enabled = false;
                textBox_Password.Enabled = false;
            }
            button_LogIn.Enabled = false;
            button_LogOut.Enabled = true;
        }

        // 点击“登录”按钮时的调用过程
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            UninitSDK();
            if (InitSDK()==true)
            {
                button_LiveView.Enabled = true;
                button_QueryLog.Enabled = true;
                button_NVRVideo.Enabled = true;
                button_DVRVideo.Enabled = true;
                button_LocalVideo.Enabled = true;
                button_HandleAlarm.Enabled = true;

                textBox_HUSSite.Enabled = false;
                textBox_UserName.Enabled = false;
                textBox_Password.Enabled = false;
            }
            button_LogIn.Enabled = false;
            button_LogOut.Enabled = true;
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            UninitSDK();

            // 因为不允许再次登录，所以直接退出程序
            Application.Exit();
        }

        // 显示视频播放窗口
        private void button_LiveView_Click(object sender, EventArgs e)
        {
            if (m_aLiveViewForm!=null)
            {
                m_aLiveViewForm.ShowDialog();
            }
        }

        // 显示日志查询窗口
        private void button_QueryLog_Click(object sender, EventArgs e)
        {
            if (m_aQueryLogForm!=null)
            {
                m_aQueryLogForm.ShowDialog();
            }
        }

        // 显示NVR搜索播放窗口
        private void button_NVRVideo_Click(object sender, EventArgs e)
        {
            if (m_aNVRVideoForm!=null)
            {
                m_aNVRVideoForm.ShowDialog();
            }
        }

        // 显示DVR搜索播放窗口
        private void button_DVRVideo_Click(object sender, EventArgs e)
        {
            if (m_aDVRVideoForm!=null)
            {
                m_aDVRVideoForm.ShowDialog();
            }
        }

        // 显示本地文件播放窗口
        private void button_LocalVideo_Click(object sender, EventArgs e)
        {
            if (m_aLocalVideoForm!=null)
            {
                m_aLocalVideoForm.ShowDialog();
            }
        }

        // 显示报警处理窗口
        private void button_HandleAlarm_Click(object sender, EventArgs e)
        {
            if (m_aHandleAlarmForm != null)
            {
                m_aHandleAlarmForm.ShowDialog();
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
