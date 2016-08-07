using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CommonFactory;
using HUS.Client.Lib.SDK;
using HUS.Client.Lib.DataModel.Utils;

namespace HUSSDKDemo
{
    public partial class Form_LocalVideo : Form
    {
        VideoPlayerBase vpb;

        public Form_LocalVideo()
        {
            InitializeComponent();

            button_StopPlay.Enabled = false;
        }

        // 查询本地文件
        private void button_Search_Click(object sender, EventArgs e)
        {
            // 显示现在文件夹对话框让用户选择查询录像的文件夹
            FolderBrowserDialog fBDailog = new FolderBrowserDialog();
            if (DialogResult.OK == fBDailog.ShowDialog())
            {
                string folderPath = fBDailog.SelectedPath;
                label_Path.Text = folderPath;

                LocalVideoSearch lvs = new LocalVideoSearch();
                try
                {
                    // 搜索文件夹获取录像文件
                    string[] files = lvs.StartSearch(folderPath);
                    if (files != null && files.Length>0)
                    {
                        // 将录像文件显示到列表中
                        listView_LocalVideo.Items.Clear();
                        foreach (string file in files)
                        {
                            VideoInfoForCSharp vc = LocalVideoSearch.GetFileInfo(file);
                            ListViewItem item = new ListViewItem(file);
                            DateTime st = Common.GetTimeFromSeconds(vc.StartTime);
                            DateTime et = Common.GetTimeFromSeconds(vc.EndTime);
                            item.SubItems.Add(st.ToString());
                            item.SubItems.Add(et.ToString());
                            listView_LocalVideo.Items.Add(item);
                        }
                    }
                }
                catch (System.Exception ex)
                {
                }
            }
        }

        // 开始播放
        private bool StartPlay()
        {
            StopPlay();

            // 获取选择文件
            if (listView_LocalVideo.SelectedItems == null || listView_LocalVideo.SelectedItems.Count <= 0)
            {
                return false;
            }
            string fileName = listView_LocalVideo.SelectedItems[0].Text;
            if (string.IsNullOrEmpty(fileName))
            {
                return false;
            }

            HUS.Client.Lib.DataModel.PropertyCollection pcs = new HUS.Client.Lib.DataModel.PropertyCollection();
            pcs.Add(Global.VIDEOPARA_FILENAME, fileName);
            pcs.Add(Global.VIDEOPARA_ATTACHONLY, false);

            bool bRet = VideoPlayManager.GetInstance().PlayVideo(pictureBox_VideoWindow.Handle, pcs, VideoPlayType.PlaybackFile);
            if (bRet)
            {
                // 保存播放句柄
                vpb = VideoPlayManager.GetInstance().GetPlayerByHandle(pictureBox_VideoWindow.Handle);

                button_StartPlay.Enabled = false;
                button_StopPlay.Enabled = true;
            }
            return bRet;
        }

        // 停止播放
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

        private void button_StartPlay_Click(object sender, EventArgs e)
        {
            StartPlay();
        }

        private void button_StopPlay_Click(object sender, EventArgs e)
        {
            StopPlay();
        }

        // 将当前选中文件的完整文件名显示出来
        private void listView_LocalVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_LocalVideo.SelectedItems == null 
                || listView_LocalVideo.SelectedItems.Count<=0)
            {
                return;
            }

            label_LocalVideo.Text = listView_LocalVideo.SelectedItems[0].Text;
        }

        // 窗口关闭时停止播放
        private void Form_LocalVideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopPlay();
        }
    }
}
