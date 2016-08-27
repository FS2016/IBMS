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
using System.IO;
using HUS.Client.Lib.DataModel.BO;

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

        public Form_PlayVideo()
        {
            InitializeComponent();
        }


        //播放单个视频
        public void startSingleVideo(String guid)
        {
            try
            {
                bool ws = false;
                // 判断文件路径是否为NULL
                if (string.IsNullOrEmpty(guid))
                {
                    Console.WriteLine("guid为空!");
                    return;
                }
                //先停止播放当前视频
                StopPlay();
                //在开始播放视频
                DeviceBase device = DeviceManagement.GetInstance().GetDeviceById(new Guid(guid));
                HUS.Client.Lib.DataModel.PropertyCollection pcs = new HUS.Client.Lib.DataModel.PropertyCollection();
                pcs.Add(Global.VIDEOPARA_STREAMER, device as StreamerBase);
                if (pcs != null)
                    ws = VideoPlayManager.GetInstance().PlayVideo(pictureBox_VideoWindow.Handle, pcs, VideoPlayType.Live);
                if (ws)
                {
                    // 保存播放句柄，做为停止播放的参数使用
                    vpb = VideoPlayManager.GetInstance().GetPlayerByHandle(pictureBox_VideoWindow.Handle);
                }
            }
            catch (System.Exception ex)
            {
                WriteLog(ex);
            }

        }


        /// <summary>
        /// 将异常打印到LOG文件
        /// </summary>
        /// <param name="ex">异常</param>
        /// <param name="LogAddress">日志文件地址</param>
        public static void WriteLog(Exception ex, string LogAddress = "")
        {
            //如果日志文件为空，则默认在Debug目录下新建 YYYY-mm-dd_Log.log文件
            if (LogAddress == "")
            {
                LogAddress = System.Environment.CurrentDirectory + '\\' +
                    DateTime.Now.Year + '-' +
                    DateTime.Now.Month + '-' +
                    DateTime.Now.Day + "_Log.log";
            }

            //把异常信息输出到文件
            StreamWriter sw = new StreamWriter(LogAddress, true);
            sw.WriteLine("当前时间：" + DateTime.Now.ToString());
            sw.WriteLine("异常信息：" + ex.Message);
            sw.WriteLine("异常对象：" + ex.Source);
            sw.WriteLine("调用堆栈：\n" + ex.StackTrace.Trim());
            sw.WriteLine("触发方法：" + ex.TargetSite);
            sw.WriteLine();
            sw.Close();
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
