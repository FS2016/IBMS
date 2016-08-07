using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using HUS.Client.Lib.DataModel.BO;
using HUS.Client.Lib.SDK;
using CommonFactory;
using VideoDownloader;
using AdaptorFactory;
using HUS.SynchronizeService.SiteImage;

namespace HUSSDKDemo
{
    public partial class Form_NVRVideo : Form
    {
        // 保存转发服务器列表
        List<ServerInfo> m_allStreamServers;

        HistoryVideoPlayer vpb;

        public Form_NVRVideo()
        {
            InitializeComponent();

            //HistoryVideoHelper.ProcessReport += new HistoryVideoHelper.ProcessReportHandler(HistoryVideoHelper_ProcessReport);
        }

        //void HistoryVideoHelper_ProcessReport(object sender, HisActionArg arg)
        //{
        //    var hvp = vpb as HistoryVideoPlayer;
        //    if (hvp != null && hvp.PlayingHisDB == sender)
        //    {
        //        if (this.InvokeRequired)
        //        {
        //            this.BeginInvoke((Action)delegate()
        //            {
        //                lblFrameTime.Text = Convert.ToString(arg.FrameTime);
        //            });
        //        }
        //        else
        //        {
        //            lblFrameTime.Text = Convert.ToString(arg.FrameTime);
        //        }
        //    }
        //}

        private void Form_NVRVideo_Load(object sender, EventArgs e)
        {
            button_StopPlay.Enabled = false;
            btnSnapshot.Enabled = false;
            btnPause.Enabled = false;

            dateTimePicker_StartTime.Value = DateTime.Now.AddHours(-2);
            dateTimePicker_EndTime.Value = DateTime.Now;

            comboBox_TriggerType.SelectedIndex = 0;
            checkBox_Duration.Checked = true;
            radioButton_Camera.Checked = true;

            // 获取所有的Stream对象
            InitStreams();

            // 获取所有的转发服务器
            InitStreamServers();

            // 获取报警设备类型
            InitAlarmDeviceTypes();
        }

        void InitStreams()
        {
            // 清除已有列表
            comboBox_Camera.Items.Clear();
            // 将“All”做为第一个选项
            string strAll = "All";
            comboBox_Camera.Items.Add(strAll);
            comboBox_Camera.SelectedIndex = 0;

            List<StreamerBase> allStreamers = DeviceManagement.GetInstance().GetAllStreamers();

            if (allStreamers.Count > 0)
            {
                // 逐条添加到列表中
                foreach (StreamerBase streamer in allStreamers)
                {
                    Streamer stream = streamer as Streamer;
                    if (null != stream)
                    {
                        comboBox_Camera.Items.Add(streamer);
                    }
                }
            }
        }

        // 获取所有的转发服务器
        void InitStreamServers()
        {
            // 清除已有列表
            comboBox_Sever.Items.Clear();
            // 将“All”做为第一个选项
            string strAll = "All";
            comboBox_Sever.Items.Add(strAll);
            comboBox_Sever.SelectedIndex = 0;

            m_allStreamServers = DeviceManagement.GetInstance().GetAllStreamerServers();
            if (m_allStreamServers == null || m_allStreamServers.Count <= 0)
            {
                return;
            }

            // 逐条添加到列表中
            foreach (ServerInfo server in m_allStreamServers)
            {
                comboBox_Sever.Items.Add(server.Name);
            }
        }

        // 获取报警设备类型
        void InitAlarmDeviceTypes()
        {
            // 清除已有列表
            comboBox_DeviceType.Items.Clear();
            // 将“All”做为第一个选项
            string strAll = "All";
            comboBox_DeviceType.Items.Add(strAll);
            comboBox_DeviceType.SelectedIndex = 0;

            List<DeviceTypeInfo> dtis = DeviceManagement.GetInstance().GetAllAlarmDeviceType();
            if (dtis!=null && dtis.Count>0)
            {
                // 逐条添加到列表中
                foreach (DeviceTypeInfo dt in dtis)
                {
                    comboBox_DeviceType.Items.Add(dt);
                }
            }
        }

        // 搜索录像
        public delegate void SearchNVRVideoDelegate();
        void SearchNVRVideo()
        {
            if (this.InvokeRequired)
            {
                SearchNVRVideoDelegate sh = new SearchNVRVideoDelegate(this.SearchNVRVideo);
                this.BeginInvoke(sh, new object[] { });
            }
            else
            {
                // 设置查询过滤条件
                SearchParams sp = new SearchParams();
                sp.start = dateTimePicker_StartTime.Value;
                sp.end = dateTimePicker_EndTime.Value;
                sp.userID = DeviceManagement.GetInstance().GetUserID();
                if (comboBox_Sever.SelectedIndex > 0)
                {
                    // 获取选择的StreamServer，选择“All”不设置此项
                    sp.sServerID = m_allStreamServers[(comboBox_Sever.SelectedIndex - 1)].ID;
                }

                if (radioButton_Camera.Checked && comboBox_Camera.SelectedItem != null)
                {
                    Streamer stream = comboBox_Camera.SelectedItem as Streamer;
                    if (stream != null)
                    {
                        sp.VideoDeviceID = stream.DeviceID;
                    }
                }

                // 设备位置，不填写时不设置
                if (radioButton_Location.Checked && textBox_Location.Text.Length > 0)
                {
                    sp.devLocation = textBox_Location.Text;
                }

                // 录像持续时间的最大最小值
                if (checkBox_Duration.Checked && textBox_DurationMin.Text.Length > 0)
                {
                    try
                    {
                        sp.startduration = Convert.ToInt32(textBox_DurationMin.Text);
                    }
                    catch (System.Exception ex)
                    {
                    }
                }
                if (checkBox_Duration.Checked && textBox_DurationMax.Text.Length > 0)
                {
                    try
                    {
                        sp.endduration = Convert.ToInt32(textBox_DurationMax.Text);
                    }
                    catch (System.Exception ex)
                    {
                    }
                }

                // 录像触发类型，选“All”时不设置
                if (comboBox_TriggerType.SelectedIndex != 0)
                {
                    sp.triggerType = (Hus.Site.WSProxy.VideoManage.enmTriggerType)(comboBox_TriggerType.SelectedIndex);
                    switch (sp.triggerType)
                    {
                        case Hus.Site.WSProxy.VideoManage.enmTriggerType.Manual:
                        case Hus.Site.WSProxy.VideoManage.enmTriggerType.Schedule:
                            if (textBox_Rule.Text.Length > 0)
                            {
                                sp.Trigger = textBox_Rule.Text;
                            }
                            break;

                        case Hus.Site.WSProxy.VideoManage.enmTriggerType.Alarm:
                            if (radioButton_ItemID.Checked)
                            {
                                DeviceBase db = comboBox_ItemID.SelectedItem as DeviceBase;
                                if (db != null)
                                {
                                    sp.AlarmDeviceID = db.ID;
                                }
                            }
                            if (radioButton_ItemLoaction.Checked && textBox_ItemLocation.Text.Length > 0)
                            {
                                sp.AlarmDeviceLocation = textBox_ItemLocation.Text;
                            }
                            break;
                    }
                }

                if (textBox_Description.Text.Length > 0)
                {
                    sp.Description = textBox_Description.Text;
                }

                // 最大条数
                if (textBox_MaxLines.Text.Length > 0)
                {
                    try
                    {
                        sp.maxLines = Convert.ToInt32(textBox_MaxLines.Text);
                    }
                    catch (System.Exception ex)
                    {
                    }
                }

                NVRVideoSearch nvrsearch = new NVRVideoSearch();
                nvrsearch.searchFinished += new HistoryVideoSearch.SearchResultHandle(Search_searchFinished);
                nvrsearch.StartSearch(sp);
            }
        }

        // 下载录像
        public delegate void DownloadNVRVideoDelegate();
        void DownloadNVRVideo()
        {
            if (this.InvokeRequired)
            {
                DownloadNVRVideoDelegate sh = new DownloadNVRVideoDelegate(this.DownloadNVRVideo);
                this.BeginInvoke(sh, new object[] { });
            }
            else
            {
                if (listView_NVRVideo.SelectedItems == null || listView_NVRVideo.SelectedItems.Count <= 0)
                {
                    return;
                }

                // 选择时间段进行下载
                MyHisActionArg hisArg = listView_NVRVideo.SelectedItems[0].Tag as MyHisActionArg;
                NVRVideoSearch nvrs = new NVRVideoSearch();
                DateTime tStart = (hisArg.StartTime > dateTimePicker_DownloadStart.Value) ? hisArg.StartTime : dateTimePicker_DownloadStart.Value;
                DateTime tEnd = (hisArg.EndTime < dateTimePicker_DownloadEnd.Value) ? hisArg.EndTime : dateTimePicker_DownloadEnd.Value;
                Downloader.StoreTask storeTask = nvrs.DownloadVideo(hisArg, tStart, tEnd);
                if (storeTask != null)
                {
                    MessageBox.Show("The vidoe is downloading ,please check the status in MainForm");
                }
            }
        }

        // 搜索记录返回
        void Search_searchFinished(List<MyHisActionArg> searchResult)
        {
            if (this.InvokeRequired)
            {
                HistoryVideoSearch.SearchResultHandle sh = new HistoryVideoSearch.SearchResultHandle(this.Search_searchFinished);
                this.Invoke(sh, new object[] { searchResult });
            }
            else
            {
                listView_NVRVideo.Items.Clear();
                int iIndex = 1;
                if (searchResult != null && searchResult.Count>0)
                {
                    // 逐条添加到录像列表中
                    foreach (MyHisActionArg hisArg in searchResult)
                    {
                        if (hisArg != null)
                        {
                            ListViewItem item = new ListViewItem(iIndex.ToString());
                            item.SubItems.Add(hisArg.VideoName);
                            item.SubItems.Add(hisArg.StartTime.ToString());
                            item.SubItems.Add(hisArg.EndTime.ToString());
                            SiteAppend appenddata = hisArg.ActionArg.BindData as SiteAppend;
                            if (appenddata!=null)
                            {
                                if (appenddata.SServer != null)
                                {
                                    item.SubItems.Add(appenddata.SServer);
                                }
                                item.Tag = hisArg;
                                listView_NVRVideo.Items.Add(item);
                                iIndex++;
                            }
                        }
                    }
                }
            }
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            SearchNVRVideo();
        }

        private void button_Download_Click(object sender, EventArgs e)
        {
            //下载的录像可以在LiveView Form的SDKDemoForm的pictureBox_Download里面看到
            DownloadNVRVideo();
        }

        private void button_StartPlay_Click(object sender, EventArgs e)
        {
            StartPlay();
        }

        private void button_StopPlay_Click(object sender, EventArgs e)
        {
            StopPlay();
        }

        private bool StartPlay()
        {
            StopPlay();

            // 判断是否有录像被选中
            if (listView_NVRVideo.SelectedItems == null || listView_NVRVideo.SelectedItems.Count <= 0)
            {
                return false;
            }

            HUS.Client.Lib.DataModel.PropertyCollection pcs = new HUS.Client.Lib.DataModel.PropertyCollection();
            MyHisActionArg hisArg = listView_NVRVideo.SelectedItems[0].Tag as MyHisActionArg;
            if (hisArg == null)
            {
                return false;
            }

            try
            {
                pcs.Add(Global.VIDEOPARA_HISARG, hisArg);
                pcs.Add(Global.VIDEOPARA_ATTACHONLY, false);

                // 播放录像
                bool bRet = VideoPlayManager.GetInstance().PlayVideo(pictureBox_VideoWindow.Handle, pcs, VideoPlayType.PlaybackNVR);
                if (bRet)
                {
                    vpb = VideoPlayManager.GetInstance().GetPlayerByHandle(pictureBox_VideoWindow.Handle) as HistoryVideoPlayer;
                    button_StartPlay.Enabled = false;
                    button_StopPlay.Enabled = true;
                    btnSnapshot.Enabled = true;
                    btnPause.Enabled = true;
                }

                return bRet;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        // 停止播放
        private void StopPlay()
        {
            if (vpb != null)
            {
                VideoPlayManager.GetInstance().StopVideo(vpb);
                vpb = null;
                // 刷新播放窗口
                pictureBox_VideoWindow.Invalidate();

                button_StartPlay.Enabled = true;
                button_StopPlay.Enabled = false;
                btnSnapshot.Enabled = false;
                btnPause.Enabled = false;
            }
        }

        private void Form_NVRVideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 窗口关闭时停止播放
            StopPlay();
        }

        // 可否设置持续时间条件
        private void checkBox_Duration_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Duration.Checked)
            {
                textBox_DurationMin.Enabled = true;
                textBox_DurationMax.Enabled = true;
            }
            else
            {
                textBox_DurationMin.Enabled = false;
                textBox_DurationMax.Enabled = false;
            }
        }

        private void radioButton_Camera_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Camera.Checked)
            {
                comboBox_Camera.Enabled = true;
                textBox_Location.Enabled = false;
            }
            else
            {
                comboBox_Camera.Enabled = false;
                textBox_Location.Enabled = true;
            }
        }

        private void radioButton_ItemID_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ItemID.Checked)
            {
                comboBox_ItemID.Enabled = true;
                textBox_ItemLocation.Enabled = false;
            }
            else
            {
                comboBox_ItemID.Enabled = false;
                textBox_ItemLocation.Enabled = true;
            }
        }

        // 根据录像触发类型显示过滤条件
        private void comboBox_TriggerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectIndex = comboBox_TriggerType.SelectedIndex;
            switch (iSelectIndex)
            {
                case 0:
                    textBox_Rule.Enabled = false;
                    comboBox_DeviceType.Enabled = false;
                    radioButton_ItemID.Enabled = false;
                    comboBox_ItemID.Enabled = false;
                    radioButton_ItemLoaction.Enabled = false;
                    textBox_ItemLocation.Enabled = false;
                    break;
                case 1:
                case 3:
                    textBox_Rule.Enabled = true;
                    comboBox_DeviceType.Enabled = false;
                    radioButton_ItemID.Enabled = false;
                    comboBox_ItemID.Enabled = false;
                    radioButton_ItemLoaction.Enabled = false;
                    textBox_ItemLocation.Enabled = false;
                    break;
                case 2:
                    textBox_Rule.Enabled = false;
                    comboBox_DeviceType.Enabled = true;
                    radioButton_ItemID.Enabled = true;
                    radioButton_ItemLoaction.Enabled = true;
                    if (radioButton_ItemID.Checked)
                    {
                        comboBox_ItemID.Enabled = true;
                        textBox_ItemLocation.Enabled = false;
                    }
                    else
                    {
                        comboBox_ItemID.Enabled = false;
                        textBox_ItemLocation.Enabled = true;
                    }
                    break;
            }
        }

        // 根据设备类型显示设备列表
        private void comboBox_DeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_ItemID.Items.Clear();

            if (comboBox_DeviceType.SelectedIndex == 0)
            {
                string strAll = "All";
                comboBox_ItemID.Items.Add(strAll);
                comboBox_ItemID.SelectedIndex = 0;
            }
            else
            {
                DeviceTypeInfo dtInfo = comboBox_DeviceType.SelectedItem as DeviceTypeInfo;
                if (dtInfo!=null)
                {
                    // 根据设备类型查询设备
                    DeviceBase[] devices = DeviceManagement.GetInstance().GetDevicesByType(dtInfo);
                    if (devices != null && devices.Length>0)
                    {
                        foreach (DeviceBase db in devices)
                        {
                            if (db != null)
                            {
                                comboBox_ItemID.Items.Add(db);
                            }
                        }
                    }
                    if (comboBox_ItemID.Items.Count>0)
                    {
                        comboBox_ItemID.SelectedIndex = 0;
                    }
                }
            }
        }

        // 根据录像显示其可下载的起始结束时间
        private void listView_NVRVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_NVRVideo.SelectedItems == null || listView_NVRVideo.SelectedItems.Count <= 0)
            {
                return;
            }

            // 获取录像的起始结束时间作为其可下载的起始结束时间
            MyHisActionArg hisArg = listView_NVRVideo.SelectedItems[0].Tag as MyHisActionArg;
            dateTimePicker_DownloadStart.Value = hisArg.StartTime;
            dateTimePicker_DownloadEnd.Value = hisArg.EndTime;
        }

        private void btnSnapshot_Click(object sender, EventArgs e)
        {
            if (vpb != null)
            {
                string strPath = DeviceControl.GetInstance().ExecuteSnapshot(vpb.IStreamer as IHistoricalStreamer, vpb.StreamerDevice.Name);
                Console.WriteLine(strPath);
            }
        }

        private bool m_bPaused = false;
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (vpb != null)
            {               
                NVRHistoryVideoPlayer hvp = vpb as NVRHistoryVideoPlayer;
                if (hvp != null)
                {
                    if (!m_bPaused)
                    {
                        hvp.Pause();
                        m_bPaused = true;
                    }
                    else
                    {
                        hvp.Resume();
                        m_bPaused = false;
                    }
                }
            }
        }
    }
}
