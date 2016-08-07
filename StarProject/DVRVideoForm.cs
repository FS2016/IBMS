using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using HUS.Client.Lib.Biz;
using HUS.Client.Lib.DataModel.BO;
using HUS.Client.Lib.SDK;
using CommonFactory;
using VideoDownloader;
using AdaptorFactory;

namespace HUSSDKDemo
{
    public partial class Form_DVRVideo : Form
    {
        private DeviceManagement m_aDeviceManagement;

        VideoPlayerBase vpb;

        private DateTime m_DTStart;
        private DateTime m_DTEnd;

        public Form_DVRVideo(DeviceManagement aDeviceManagement)
        {
            m_aDeviceManagement = aDeviceManagement;
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
        //            this.BeginInvoke((Action) delegate()
        //                                          {
        //                                              lblFrameTime.Text = Convert.ToString(arg.FrameTime);
        //                                          });
        //        }
        //        else
        //        {
        //            lblFrameTime.Text = Convert.ToString(arg.FrameTime);
        //        }
        //    }
        //}

        private void Form_DVRVideo_Load(object sender, EventArgs e)
        {
            button_StopPlay.Enabled = false;

            dateTimePicker_StartTime.Value = DateTime.Now.AddHours(-2);
            dateTimePicker_EndTime.Value = DateTime.Now;

            comboBox_DeviceType.Items.Clear();

            if (m_aDeviceManagement == null)
            {
                return;
            }

            // 获取DVR类型并添加到列表中
            List<DeviceTypeInfo> recordable = m_aDeviceManagement.GetRecordableDVRDTInfos();
            if (recordable != null && recordable.Count>0)
            {
                foreach (DeviceTypeInfo dti in recordable)
                {
                    comboBox_DeviceType.Items.Add(dti);
                    comboBox_DeviceType.SelectedIndex = 0;
                }
            }
        }

        // 查询DVR录像
        public delegate void SearchDVRVideoDelegate();
        void SearchDVRVideo()
        {
            if (this.InvokeRequired)
            {
                SearchDVRVideoDelegate sh = new SearchDVRVideoDelegate(this.SearchDVRVideo);
                this.BeginInvoke(sh, new object[] { });
            }
            else
            {
                if (m_aDeviceManagement == null)
                {
                    return;
                }

                if (comboBox_DeviceType.SelectedItem == null
                    || comboBox_Channel.SelectedItem == null
                    || comboBox_RecordType.SelectedItem == null)
                {
                    return;
                }

                DVRVideoSearch dvrsearch = new DVRVideoSearch(comboBox_Channel.SelectedItem as DeviceBase);
                dvrsearch.searchFinished += new HistoryVideoSearch.SearchResultHandle(Search_searchFinished);

                // 设置录像触发条件
                int index = m_aDeviceManagement.GetTriggerIndex(comboBox_DeviceType.SelectedItem as RecordableDVRDeviceTypeInfo,
                    comboBox_RecordType.SelectedItem as string);
                if (index != -1)
                {
                    m_DTStart = dateTimePicker_StartTime.Value;
                    m_DTEnd = dateTimePicker_EndTime.Value;
                    dvrsearch.StartSearch(index, "0", m_DTStart, m_DTEnd);
                }
            }
        }

        // 下载录像
        public delegate void DownloadDVRVideoDelegate();
        void DownloadDVRVideo()
        {
            if (this.InvokeRequired)
            {
                DownloadDVRVideoDelegate sh = new DownloadDVRVideoDelegate(this.DownloadDVRVideo);
                this.BeginInvoke(sh, new object[] { });
            }
            else
            {
                if (listView_DVRVideo.SelectedItems == null || listView_DVRVideo.SelectedItems.Count <= 0)
                {
                    return;
                }

                // 根据时间段下载选中的录像
                MyHisActionArg hisArg = listView_DVRVideo.SelectedItems[0].Tag as MyHisActionArg;
                DVRVideoSearch dvrs = new DVRVideoSearch(hisArg.ActionArg.Tag as DeviceBase);
                DateTime tStart = (hisArg.StartTime > dateTimePicker_DownloadStart.Value) ? hisArg.StartTime : dateTimePicker_DownloadStart.Value;
                DateTime tEnd = (hisArg.EndTime < dateTimePicker_DownloadEnd.Value) ? hisArg.EndTime : dateTimePicker_DownloadEnd.Value;
                Downloader.StoreTask storeTask = dvrs.DownloadVideo(hisArg, tStart, tEnd);
                if (storeTask != null)
                {
                    MessageBox.Show("The vidoe is downloading ,please check the status in MainForm");
                }
            }
        }

        // 查询结果返回消息处理函数
        void Search_searchFinished(List<MyHisActionArg> searchResult)
        {
            if (this.InvokeRequired)
            {
                HistoryVideoSearch.SearchResultHandle sh = new HistoryVideoSearch.SearchResultHandle(this.Search_searchFinished);
                this.Invoke(sh, new object[] { searchResult });
            }
            else
            {
                listView_DVRVideo.Items.Clear();
                int iIndex = 1;
                if (searchResult != null && searchResult.Count > 0)
                {
                    //为了与客户端一致的计算逻辑,m_DTVideoHistory.DefaultView.Sort = "StartTime DESC";
                    searchResult.Sort((MyHisActionArg x,MyHisActionArg y)=>{
                        if (x.StartTime < y.StartTime)
                        {
                            return 1;
                        }
                        else if(x.StartTime > y.StartTime)
                        {
                            return -1;
                        }
                        else
                        {
                            return 0;
                        }
                    });
                    // 逐条将查询结果显示到列表中
                    foreach (MyHisActionArg hisArg in searchResult)
                    {
                        if (hisArg != null)
                        {
                            ListViewItem item = new ListViewItem(iIndex.ToString());
                            item.SubItems.Add(hisArg.VideoName);

                            //为了与客户端一致的计算逻辑
                            hisArg.RealStartTime = m_DTStart > hisArg.StartTime ? m_DTStart : hisArg.StartTime;
                            hisArg.RealEndTime = m_DTEnd < hisArg.EndTime ? m_DTEnd : hisArg.EndTime;
                            item.SubItems.Add(hisArg.RealStartTime.ToString());
                            item.SubItems.Add(hisArg.RealEndTime.ToString());

                            item.Tag = hisArg;
                            listView_DVRVideo.Items.Add(item);
                            iIndex++;
                        }
                    }
                }
            }
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            SearchDVRVideo();
        }

        private void button_Download_Click(object sender, EventArgs e)
        {
            Thread trd1 = new Thread(new ThreadStart(this.DownloadDVRVideo));
            trd1.Start();
        }

        private void button_StartPlay_Click(object sender, EventArgs e)
        {
            StartPlay();
        }

        private void button_StopPlay_Click(object sender, EventArgs e)
        {
            StopPlay();
        }

        // 开始播放DVR录像
        private bool StartPlay()
        {
            StopPlay();

            if (listView_DVRVideo.SelectedItems == null || listView_DVRVideo.SelectedItems.Count <= 0)
            {
                return false;
            }

            // 获取选中的DVR录像记录
            HUS.Client.Lib.DataModel.PropertyCollection pcs = new HUS.Client.Lib.DataModel.PropertyCollection();
            MyHisActionArg hisArg = listView_DVRVideo.SelectedItems[0].Tag as MyHisActionArg;
            if (hisArg == null)
            {
                return false;
            }
            pcs.Add(Global.VIDEOPARA_HISARG, hisArg);
            pcs.Add(Global.VIDEOPARA_DVRCHANNEL, hisArg.Channel);   //hisArg.ActionArg.Tag as IChannel);

            bool bRet = VideoPlayManager.GetInstance().PlayVideo(pictureBox_VideoWindow.Handle, pcs, VideoPlayType.PlaybackDVR);
            if (bRet)
            {
                vpb = VideoPlayManager.GetInstance().GetPlayerByHandle(pictureBox_VideoWindow.Handle);

                button_StartPlay.Enabled = false;
                button_StopPlay.Enabled = true;
            }

            return bRet;
        }

        // 停止播放DVR录像
        private void StopPlay()
        {
            if (vpb != null)
            {
                VideoPlayManager.GetInstance().StopVideo(vpb);
                vpb = null;
                // 刷新窗口
                pictureBox_VideoWindow.Invalidate();

                button_StartPlay.Enabled = true;
                button_StopPlay.Enabled = false;
            }
        }

        // 根据设备类型显示设备列表及录像触发类型列表
        private void comboBox_DeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Device.Items.Clear();
            comboBox_RecordType.Items.Clear();
            comboBox_Channel.Items.Clear();

            // 根据设备类型获取并显示设备列表
            List<DeviceBase> dvr = DeviceManagement.GetInstance().GetRecordableDVRsByTypeInfo(comboBox_DeviceType.SelectedItem as DeviceTypeInfo);
            if (dvr != null && dvr.Count > 0)
            {
                foreach (DeviceBase db in dvr)
                {
                    comboBox_Device.Items.Add(db);
                    comboBox_Device.SelectedIndex = 0;
                }
            }

            // 根据设备类型获取并显示录像触发列表
            string[] types = DeviceManagement.GetInstance().GetTriggerTypeName(comboBox_DeviceType.SelectedItem as RecordableDVRDeviceTypeInfo);
            if (types != null && types.Length>0)
            {
                foreach (string type in types)
                {
                    comboBox_RecordType.Items.Add(type);
                    comboBox_RecordType.SelectedIndex = 0;
                }
            }
        }

        // 根据设备显示通道列表
        private void comboBox_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Channel.Items.Clear();

            List<DeviceBase> channels = DeviceManagement.GetInstance().GetRecordableDVRChannlesByDVR(comboBox_Device.SelectedItem as DeviceBase);
            if (channels != null && channels.Count>0)
            {
                foreach (DeviceBase db in channels)
                {
                    comboBox_Channel.Items.Add(db);
                    comboBox_Channel.SelectedIndex = 0;
                }
            }
        }

        private void Form_DVRVideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 关闭窗口时停止播放视频
            StopPlay();
        }

        // 根据录像记录显示其可下载的起始结束时间
        private void listView_DVRVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_DVRVideo.SelectedItems == null || listView_DVRVideo.SelectedItems.Count <= 0)
            {
                return;
            }

            // 将录像记录的起始结束时间做为其可下载的起始结束时间
            MyHisActionArg hisArg = listView_DVRVideo.SelectedItems[0].Tag as MyHisActionArg;
            dateTimePicker_DownloadStart.Value = hisArg.StartTime;
            dateTimePicker_DownloadEnd.Value =  hisArg.EndTime;
        }
    }
}
