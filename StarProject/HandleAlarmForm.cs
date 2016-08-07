using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HUS.Client.Lib.SDK;
using HUS.Client.Lib.InterComm.EC;

namespace HUSSDKDemo
{
    public partial class Form_HandleAlarm : Form
    {
        public Form_HandleAlarm()
        {
            InitializeComponent();
        }

        // 报警触发处理函数
        public void AlarmTriggered(object message)
        {
            HUS.Client.Lib.InterComm.EC.Message mg = message as HUS.Client.Lib.InterComm.EC.Message;

            // 移除已接收报警列表中相同的报警
            ListViewItem[] allItems = listView_ReceiveAlarm.Items.Find(mg.SenderName, false);
            if (allItems != null && allItems.Length>0)
            {
                foreach (ListViewItem item in allItems)
                {
                    HUS.Client.Lib.InterComm.EC.Message amg = item.Tag as HUS.Client.Lib.InterComm.EC.Message;
                    if (amg.ID == mg.ID)
                    {
                        listView_ReceiveAlarm.Items.Remove(item);
                        listView_ReceiveAlarm.Invalidate();
                    }
                }
            }

            ListViewItem lvItem = new ListViewItem(mg.SenderName);
            lvItem.Name = mg.SenderName;
            lvItem.SubItems.Add(mg.Type);
            lvItem.SubItems.Add(mg.Level);
            lvItem.SubItems.Add(mg.FirstTime);
            lvItem.SubItems.Add(mg.Count);
            lvItem.SubItems.Add(mg.Time);
            lvItem.SubItems.Add(mg.Detail);
            lvItem.SubItems.Add(mg.ECServerName);
            lvItem.SubItems.Add(mg.Status.ToString());
            lvItem.Tag = mg;

            // 根据报警状态添加到相应的列表中
            if (mg.Status.Equals(AlarmStatus.PROCESSING))
            {
                listView_ProcessingAlarm.Items.Insert(0, lvItem);
            }
            else if (mg.Status.Equals(AlarmStatus.PROCESSED))
            {
                listView_ProcessedAlarm.Items.Insert(0, lvItem);
            }
            else
            {
                listView_ReceiveAlarm.Items.Insert(0, lvItem);
            }
        }

        // 报警状态处理函数
        public void AlarmStatusChange(object message)
        {
            HUS.Client.Lib.InterComm.EC.Message mg = message as HUS.Client.Lib.InterComm.EC.Message;

            ListViewItem lvItem = new ListViewItem(mg.SenderName);
            lvItem.Name = mg.SenderName;
            lvItem.SubItems.Add(mg.Type);
            lvItem.SubItems.Add(mg.Level);
            lvItem.SubItems.Add(mg.FirstTime);
            lvItem.SubItems.Add(mg.Count);
            lvItem.SubItems.Add(mg.Time);
            lvItem.SubItems.Add(mg.Detail);
            lvItem.SubItems.Add(mg.ECServerName);
            lvItem.SubItems.Add(mg.Status.ToString());
            lvItem.Tag = mg;

            // 从报警列表中移除相同的报警，避免重复
            if (mg.Status.Equals(AlarmStatus.PROCESSING) || mg.Status.Equals(AlarmStatus.PROCESSED))
            {
                // Remove from Receive alarm list.
                ListViewItem[] inReceiveItems = listView_ReceiveAlarm.Items.Find(mg.SenderName, false);
                if (inReceiveItems != null && inReceiveItems.Length>0)
                {
                    foreach (ListViewItem item in inReceiveItems)
                    {
                        HUS.Client.Lib.InterComm.EC.Message amg = item.Tag as HUS.Client.Lib.InterComm.EC.Message;
                        if (amg.ID == mg.ID)
                        {
                            listView_ReceiveAlarm.Items.Remove(item);
                            listView_ReceiveAlarm.Invalidate();
                        }
                    }
                }

                // Remove from processing alarm list.
                ListViewItem[] inProcessingItems = listView_ProcessingAlarm.Items.Find(mg.SenderName, false);
                if (inProcessingItems != null && inProcessingItems.Length>0)
                {
                    foreach (ListViewItem item in inProcessingItems)
                    {
                        HUS.Client.Lib.InterComm.EC.Message amg = item.Tag as HUS.Client.Lib.InterComm.EC.Message;
                        if (amg.ID == mg.ID)
                        {
                            listView_ProcessingAlarm.Items.Remove(item);
                            listView_ProcessingAlarm.Invalidate();
                        }
                    }
                }

                // Remove from processed alarm list.
                ListViewItem[] inProcessedItems = listView_ProcessedAlarm.Items.Find(mg.SenderName, false);
                if (inProcessedItems != null && inProcessedItems.Length>0)
                {
                    foreach (ListViewItem item in inProcessedItems)
                    {
                        HUS.Client.Lib.InterComm.EC.Message amg = item.Tag as HUS.Client.Lib.InterComm.EC.Message;
                        if (amg.ID == mg.ID)
                        {
                            listView_ProcessedAlarm.Items.Remove(item);
                            listView_ProcessedAlarm.Invalidate();
                        }
                    }
                }
            }

            // 根据处理状态添加到报警列表中
            if (mg.Status.Equals(AlarmStatus.PROCESSING))
            {
                listView_ProcessingAlarm.Items.Insert(0, lvItem);
            }

            if (mg.Status.Equals(AlarmStatus.PROCESSED))
            {
                listView_ProcessedAlarm.Items.Insert(0, lvItem);
            }
        }

        // 将报警设置为处理中
        bool HandleAlarmToProcessing(HUS.Client.Lib.InterComm.EC.Message mg)
        {
            AlarmProcess ap = AlarmProcess.GetInstance();
            ap.Message = mg;
            return ap.HandleAlarmToProcessing();
        }

        // 将报警设置已处理
        bool HandleAlarmToProcessed(HUS.Client.Lib.InterComm.EC.Message mg, string comment)
        {
            AlarmProcess ap = AlarmProcess.GetInstance();
            ap.Message = mg;
            return ap.HandleAlarmToProcessed(comment);
        }

        private void button_ProcessingAlarm_Click(object sender, EventArgs e)
        {
            if (listView_ReceiveAlarm.SelectedItems == null || listView_ReceiveAlarm.SelectedItems.Count<=0)
            {
                return;
            }

            // 批量的将选中的已接收的报警设置为处理中
            foreach ( ListViewItem item in listView_ReceiveAlarm.SelectedItems)
            {
                HUS.Client.Lib.InterComm.EC.Message mg = item.Tag as HUS.Client.Lib.InterComm.EC.Message;
                try
                {
                    if (true == HandleAlarmToProcessing(mg))
                    {
                        listView_ReceiveAlarm.Items.Remove(item);
                    }
                }
                catch (HandleAlarmException ex)
                {
                    MessageBox.Show(ex.Reason.ToString());
                }
            }
        }

        private void button_ProcessedAlarm_Click(object sender, EventArgs e)
        {
            if (listView_ProcessingAlarm.SelectedItems == null || listView_ProcessingAlarm.SelectedItems.Count <= 0)
            {
                return;
            }

            // 批量的将选中的处理中状态的报警设置为已处理
            foreach (ListViewItem item in listView_ProcessingAlarm.SelectedItems)
            {
                HUS.Client.Lib.InterComm.EC.Message mg = item.Tag as HUS.Client.Lib.InterComm.EC.Message;
                try
                {
                    if (true == HandleAlarmToProcessed(mg, textBox_Comment.Text))
                    {
                        listView_ProcessingAlarm.Items.Remove(listView_ProcessingAlarm.SelectedItems[0]);
                    }
                }
                catch (HandleAlarmException ex)
                {
                    MessageBox.Show(ex.Reason.ToString());
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listView_ProcessedAlarm.SelectedItems == null || listView_ProcessedAlarm.SelectedItems.Count <= 0)
            {
                return;
            }

            // 删除选中的已处理报警
            foreach (ListViewItem item in listView_ProcessedAlarm.SelectedItems)
            {
                listView_ProcessedAlarm.Items.Remove(item);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            // 清空所有已处理状态的报警
            listView_ProcessedAlarm.Items.Clear();
        }
    }
}
