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
    // 用于响应下载控件中的播放按钮，播放选中的文件
    public partial class Form_PlayVideo : Form
    {
        VideoPlayerBase vpb = null;
        string fileName = null;

        // 构造函数传入播放文件路径
        public Form_PlayVideo(string filePath)
        {
            InitializeComponent();
            fileName = filePath;
        }

        private bool StartPlay()
        {
            StopPlay();

            // 判断文件路径是否为NULL
            if (string.IsNullOrEmpty(fileName))
            {
                return false;
            }
            try
            {
                HUS.Client.Lib.DataModel.PropertyCollection pcs = new HUS.Client.Lib.DataModel.PropertyCollection();
                pcs.Add(Global.VIDEOPARA_FILENAME, fileName);
                pcs.Add(Global.VIDEOPARA_ATTACHONLY, false);

                // 将图像控件作为播放窗口
                bool bRet = VideoPlayManager.GetInstance().PlayVideo(pictureBox_VideoWindow.Handle, pcs, VideoPlayType.PlaybackFile);
                if (bRet)
                {
                    // 保存播放句柄，做为停止播放的参数使用
                    vpb = VideoPlayManager.GetInstance().GetPlayerByHandle(pictureBox_VideoWindow.Handle);
                }
                return bRet;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        private void StopPlay()
        {
            if (vpb != null)
            {
                try
                {
                    VideoPlayManager.GetInstance().StopVideo(vpb);
                    vpb = null;
                    // 刷新窗口
                    pictureBox_VideoWindow.Invalidate();
                }
                catch (System.Exception ex)
                {	
                }
            }
        }

        private void Form_PlayVideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 窗口关闭即结束播放
            StopPlay();
        }

        private void Form_PlayVideo_Load(object sender, EventArgs e)
        {
            // 窗口加载即开始播放
            StartPlay();
        }
    }
}
