using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using HUS.Client.Lib.DataModel.BO;
using HUS.Client.Lib.SDK;
using CommonFactory;
using AdaptorFactory;
using HUS.Client.Lib.ClientPlayer;


namespace HUSSDKDemo
{
    public partial class Form_LiveView : Form
    {
        VideoPlayerBase vpb;
        DeviceBase dialogDevice = null;

        public Form_LiveView()
        {
            InitializeComponent();
        }

        private void Form_LiveView_Load(object sender, EventArgs e)
        {
            // 初始化设备列表
            InitDeviceList();
            // 初始化PTZ操作
            InitPTZSettings();
            button_StopPlay.Enabled = false;
            button_StopDialog.Enabled = false;
        }

        // 获取设备列表
        void InitDeviceList()
        {
            dialogDevice = null;

            // 获取所有的Streamer对象并显示到列表中
            List<StreamerBase> allStreamers = DeviceManagement.GetInstance().GetAllStreamers();
            if (allStreamers.Count > 0)
            {
                foreach (StreamerBase stream in allStreamers)
                {
                    ListViewItem[] titem = listView_Stream.Items.Find(stream.ID.ToString(), false);
                    if (titem.Length == 0)
                    {
                        Streamer streamer = stream as Streamer;
                        if (streamer != null)
                        {
                            ListViewItem lvItem = new ListViewItem(stream.Name);
                            lvItem.Name = stream.ID.ToString();
                            lvItem.SubItems.Add(stream.Status.ToString());
                            lvItem.Tag = streamer;
                            listView_Stream.Items.Add(lvItem);
                            // 添加状态改变处理函数
                            RegisterDeviceEventHandler(streamer);
                        }
                    }
                }
            }
        }
        
        // 开始实时预览
        private bool StartPlayVideo()
        {
            StopPlayVideo();

            // 获取当前选中的Streamer
            if (listView_Stream.SelectedItems == null || listView_Stream.SelectedItems.Count <= 0)
            {
                return false;
            }

            VideoPlayType vpt = VideoPlayType.Live;
            DeviceBase device;
            if (listView_VirtualStream.SelectedItems == null || listView_VirtualStream.SelectedItems.Count <= 0)
            {
                // 实时视频
                device = listView_Stream.SelectedItems[0].Tag as DeviceBase;
                vpt = VideoPlayType.Live;
            }
            else
            {
                // 转发实时视频
                device = listView_VirtualStream.SelectedItems[0].Tag as DeviceBase;
                vpt = VideoPlayType.Live;
            }

            bool result = false;
            HUS.Client.Lib.DataModel.PropertyCollection pcs = new HUS.Client.Lib.DataModel.PropertyCollection();
            pcs.Add(Global.VIDEOPARA_STREAMER, device as StreamerBase);

            try
            {
                if (pcs != null)
                {
                    // 开始播放
                    result = VideoPlayManager.GetInstance().PlayVideo(pictureBox_VideoWindow.Handle, pcs, vpt);
                }

            }
            catch (PlayVideoFailedException ex)
            {
                MessageBox.Show(ex.Reason.ToString());
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message.ToString());
            }

            if (result)
            {
                // 保存播放句柄
                vpb = VideoPlayManager.GetInstance().GetPlayerByHandle(pictureBox_VideoWindow.Handle);

                button_StartPlay.Enabled = false;
                button_StopPlay.Enabled = true;
            }

            return result;
        }

        //播放单个视频
        public void startSingleVideo(String guid) {
        DeviceBase device = DeviceManagement.GetInstance().GetDeviceById(new Guid(guid));
        HUS.Client.Lib.DataModel.PropertyCollection pcs = new HUS.Client.Lib.DataModel.PropertyCollection();
        pcs.Add(Global.VIDEOPARA_STREAMER, device as StreamerBase);
        if (pcs != null)
        VideoPlayManager.GetInstance().PlayVideo(pictureBox_VideoWindow.Handle, pcs,VideoPlayType.Live);
        
        }

        // 停止播放
        private void StopPlayVideo()
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

        #region event
        private void button_StartPlay_Click(object sender, EventArgs e)
        {
            startSingleVideo("c5f27d1b-f73e-496d-899d-8ec29334b0ed");
            //StartPlayVideo();
        }

        private void button_StopPlay_Click(object sender, EventArgs e)
        {
            StopPlayVideo();
        }

        // 根据当前选中的Streamer显示其可用的转发Streamer
        private void listView_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 清空已有列表
            listView_VirtualStream.Items.Clear();

            if (listView_Stream.SelectedItems == null || listView_Stream.SelectedItems.Count <= 0)
            {
                label_Playing.Text = "......";
                return;
            }

            // 查找其可用的转发Streamer并显示到列表中
            Streamer stream = listView_Stream.SelectedItems[0].Tag as Streamer;
            IList<VirtualStreamer> vss = stream.GetVirtualStreamers();
            if (vss!=null && vss.Count>0)
            {
                ListViewItem lvItem;
                foreach (VirtualStreamer vs in vss)
                {
                    lvItem = new ListViewItem(vs.Name);
                    // 将VirtualStreamer对象作为Tag保存在选项中
                    lvItem.Tag = vs;
                    listView_VirtualStream.Items.Add(lvItem);
                }
            }

            // 显示选中的Streamer
            label_Playing.Text = listView_Stream.SelectedItems[0].Text;
            var device = stream as DeviceBase;
            lblOSD.Text = Convert.ToString(device.SpecialParams["Text"]);
        }

        // 显示当前选中的转发Streamer
        private void listView_VirtualStream_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_VirtualStream.SelectedItems == null || listView_VirtualStream.SelectedItems.Count <= 0)
            {
                return;
            }

            label_Playing.Text = listView_VirtualStream.SelectedItems[0].Text;
        }

        // 截图
        private void button_Snapshot_Click(object sender, EventArgs e)
        {
            label_SnapshotPath.Text = "......";

            // No Device selected
            if (listView_Stream.SelectedItems == null || listView_Stream.SelectedItems.Count <= 0)
            {
                return;
            }

            // Not playing
            if (vpb == null)
            {
                return;
            }

            DeviceBase device = listView_Stream.SelectedItems[0].Tag as DeviceBase;
            Streamer stream = device as Streamer;
            //string strPath = DeviceControl.GetInstance().ExecuteSnapshot(vpb.StreamerDevice, vpb.StreamerDevice.GetRealStreamer());
            string strPath = DeviceControl.GetInstance().ExecuteSnapshot(vpb.StreamerDevice, vpb.IStreamer);
            // 显示截图保存路径
            label_SnapshotPath.Text = strPath;
        }

        // 开始对讲
        private void button_StartDialog_Click(object sender, EventArgs e)
        {
            // No Device selected
            if (listView_Stream.SelectedItems == null || listView_Stream.SelectedItems.Count <= 0)
            {
                return;
            }

            // Not playing
            if (vpb == null)
            {
                return;
            }

            // 获取选中的实时Streamer
            DeviceBase device = listView_Stream.SelectedItems[0].Tag as DeviceBase;
            Streamer stream = device as Streamer;

            // 开始对讲
            if (DeviceControl.GetInstance().ExecuteDialog(device, true, stream))
            {
                MessageBox.Show("Dialog Start!");
                dialogDevice = device;

                button_StartDialog.Enabled = false;
                button_StopDialog.Enabled = true;
            }
            else
            {
                MessageBox.Show("Dialog Fail!!!");
            }
        }

        // 停止对讲
        private void button_StopDialog_Click(object sender, EventArgs e)
        {
            // Not playing
            if (vpb==null || dialogDevice==null)
            {
                return;
            }

            Streamer stream = dialogDevice as Streamer;

            DeviceControl.GetInstance().ExecuteDialog(dialogDevice, false, stream);
            dialogDevice = null;

            button_StartDialog.Enabled = true;
            button_StopDialog.Enabled = false;

            MessageBox.Show("Dialog end!");
        }

        private void Form_LiveView_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (ListViewItem item in listView_Stream.Items)
            {
                Streamer st = item.Tag as Streamer;
                if (st != null)
                {
                    // 取消状态改变消息处理函数的关联
                    UnRegisterDeviceEventHandler(st);
                }
                listView_Stream.Items.Clear();
            }
            StopPlayVideo();
        }

        private void InitPTZSettings()
        {
            comboBox_Step.SelectedIndex = 0;
        }

        // PTZ普通操作
        private void PTZ(DomeItemEnum funcItem)
        {
            // No Device selected
            if (listView_Stream.SelectedItems == null || listView_Stream.SelectedItems.Count <= 0)
            {
                label_PTZInfo.Text = "PTZ Fail!-No Device selected!";
                return;
            }

            // Not playing
            if (vpb == null)
            {
                label_PTZInfo.Text = "PTZ Fail!-Not Playing ";
                return;
            }

            // 获取选中的Streamer
            DeviceBase device = listView_Stream.SelectedItems[0].Tag as DeviceBase;
            Streamer stream = device as Streamer;

            int iStep = comboBox_Step.SelectedIndex + 1;
            if (DeviceControl.GetInstance().ExecutePTZ(device, funcItem, iStep))
            {
                label_PTZInfo.Text = "PTZ " + funcItem.ToString() + " Success";
                if (funcItem != DomeItemEnum.Stop)
                {
                    System.Threading.Thread.Sleep(200);
                    DeviceControl.GetInstance().ExecutePTZ(device, DomeItemEnum.Stop, 0);
                }
            }
            else
            {
                label_PTZInfo.Text = "PTZ " + funcItem.ToString() + " Fail!";
            }
        }

        // PTZ预置位操作
        private void PTZPresent(DomeItemEnum funcItem, int iPresentIndex)
        {
            // No Device selected
            if (listView_Stream.SelectedItems == null || listView_Stream.SelectedItems.Count <= 0)
            {
                label_PTZInfo.Text = "PTZ Fail!-No Device selected!";
                return;
            }

            // Not playing
            if (vpb == null)
            {
                label_PTZInfo.Text = "PTZ Fail!-Not Playing ";
                return;
            }

            DeviceBase device = listView_Stream.SelectedItems[0].Tag as DeviceBase;
            Streamer stream = device as Streamer;

            if (DeviceControl.GetInstance().ExecutePTZ(device, funcItem, iPresentIndex))
            {
                label_PTZInfo.Text = "PTZ " + funcItem.ToString() + " Success";
            }
            else
            {
                label_PTZInfo.Text = "PTZ " + funcItem.ToString() + " Fail!";
            }
        }

        private void checkBox_LightOn_CheckedChanged(object sender, EventArgs e)
        {
            DomeItemEnum domeItem = (checkBox_LightOn.Checked == true) ? DomeItemEnum.LightOn : DomeItemEnum.LightOff;
            PTZ(domeItem);
        }

        private void checkBox_WipeOn_CheckedChanged(object sender, EventArgs e)
        {
            DomeItemEnum domeItem = (checkBox_WipeOn.Checked == true) ? DomeItemEnum.WipeOn : DomeItemEnum.WipeOff;
            PTZ(domeItem);
        }

        private void checkBox_WashOn_CheckedChanged(object sender, EventArgs e)
        {
            DomeItemEnum domeItem = (checkBox_WashOn.Checked == true) ? DomeItemEnum.WashOn : DomeItemEnum.WashOff;
            PTZ(domeItem);
        }

        private void checkBox_AuxOn_CheckedChanged(object sender, EventArgs e)
        {
            DomeItemEnum domeItem = (checkBox_AuxOn.Checked == true) ? DomeItemEnum.AuxOn : DomeItemEnum.AuxOff;
            PTZ(domeItem);
        }

        private void button_LeftUp_MouseDown(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.LeftUp);
        }

        private void button_LeftUp_MouseUp(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Stop);
        }

        private void button_Up_MouseDown(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Up);
        }

        private void button_Up_MouseUp(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Stop);
        }

        private void button_RightUp_MouseDown(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.RightUp);
        }

        private void button_RightUp_MouseUp(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Stop);
        }

        private void button_Left_MouseDown(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Left);
        }

        private void button_Left_MouseUp(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Stop);
        }

        private void button_ZoomOut_MouseDown(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.ZoomOut);
        }

        private void button_ZoomOut_MouseUp(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Stop);
        }

        private void button_ZoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.ZoomIn);
        }

        private void button_ZoomIn_MouseUp(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Stop);
        }

        private void button_Right_MouseDown(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Right);
        }

        private void button_Right_MouseUp(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Stop);
        }

        private void button_LeftDown_MouseDown(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.LeftDown);
        }

        private void button_LeftDown_MouseUp(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Stop);
        }

        private void button_Down_MouseDown(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Down);
        }

        private void button_Down_MouseUp(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Stop);
        }

        private void button_RightDown_MouseDown(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.RightDown);
        }

        private void button_RightDown_MouseUp(object sender, MouseEventArgs e)
        {
            PTZ(DomeItemEnum.Stop);
        }

        private void button_FocusIn_Click(object sender, EventArgs e)
        {
            PTZ(DomeItemEnum.FocusIn);
        }

        private void button_FocusOut_Click(object sender, EventArgs e)
        {
            PTZ(DomeItemEnum.FocusOut);
        }

        private void button_IrisOn_Click(object sender, EventArgs e)
        {
            PTZ(DomeItemEnum.IrisIn);
        }

        private void button_IrisOut_Click(object sender, EventArgs e)
        {
            PTZ(DomeItemEnum.IrisOut);
        }

        private void button_Preset_Goto_Click(object sender, EventArgs e)
        {
            PTZPresent(DomeItemEnum.PresetGoto, Convert.ToInt32(textBox_Preset.Text));
        }

        private void button_Preset_set_Click(object sender, EventArgs e)
        {
            PTZPresent(DomeItemEnum.PresetSet, Convert.ToInt32(textBox_Preset.Text));
        }

        private void button_Preset_Del_Click(object sender, EventArgs e)
        {
            PTZPresent(DomeItemEnum.PresetDel, Convert.ToInt32(textBox_Preset.Text));
        }
        #endregion

        // 关联设备消息处理函数
        private void RegisterDeviceEventHandler(Streamer device)
        {
            device.StatusChanged += new EventHandler<HUS.Client.Lib.DataModel.DeviceStatusChangedArgs>(device_StatusChanged);
            device.PTZEnableChanged += new EventHandler(device_PTZEnableChanged);
        }

        // 取消关联设备消息处理函数
        private void UnRegisterDeviceEventHandler(Streamer device)
        {
            device.StatusChanged -= new EventHandler<HUS.Client.Lib.DataModel.DeviceStatusChangedArgs>(device_StatusChanged);
            device.PTZEnableChanged -= new EventHandler(device_PTZEnableChanged);
        }

        void device_PTZEnableChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        // 设备消息处理函数
        void device_StatusChanged(object sender, HUS.Client.Lib.DataModel.DeviceStatusChangedArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler<HUS.Client.Lib.DataModel.DeviceStatusChangedArgs>(device_StatusChanged), new object[] { sender, e });
            }
            else
            {
                Streamer device = sender as Streamer;
                if (device != null)
                {
                    UpdateDeviceStatus(device);
                }
            }
        }

        // 更新设备状态
        void UpdateDeviceStatus(Streamer device)
        {
            ListViewItem[] allItems = listView_Stream.Items.Find(device.ID.ToString(), false);
            if (allItems != null && allItems.Length > 0)
            {
                foreach (ListViewItem item in allItems)
                {
                    item.SubItems[1].Text = device.Status.Name;
                }
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
