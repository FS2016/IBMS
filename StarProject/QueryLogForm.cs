using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HUS.MS.LogRecordManager;
using HUS.Client.Lib.SDK;

namespace HUSSDKDemo
{
    public partial class Form_QueryLog : Form
    {
        private LogQuery m_aLogQuery;

        // 记录本次查询的日志的总条数
        private int m_nLogCount = 0;
        // 记录当前分页查询的起始下标
        private int m_nLogNowStartIndex = 0;
        // 每次分页查询的最大条数
        private int m_nOnceQueryCount = 20;

        public Form_QueryLog()
        {
            InitializeComponent();

            comboBox_Catalog.SelectedIndex = 0;
            comboBox_OnlineType.SelectedIndex = 0;
            comboBox_ClientType.SelectedIndex = 0;
            comboBox_ProcessType.SelectedIndex = 0;
            comboBox_AlarmType.SelectedIndex = 0;
        }

        private void Form_QueryLog_Load(object sender, EventArgs e)
        {
            // 初始化
            comboBox_Catalog_Init();
        }

        // 查询用户登录信息的总条数
        void QueryUserLoginLogsCount()
        {
            if (null == m_aLogQuery)
            {
                m_aLogQuery = LogQuery.GetInstance();
            }

            // 查询过滤参数集合
            object[] allParams = new object[6];

            //计算登入登出时间逻辑
            string strQuery = "((LoginTime between {0} and {1}) OR (ISNULL(LogoutTime,dateadd(second,LoginTimeOut,LastActiveTime)) between {0} and {1}))";
            allParams[0] = dateTimePicker_StartTime.Value;
            allParams[1] = dateTimePicker_EndTime.Value;

            if (textBox_UserName.Text.Length > 0)
            {
                // 登录用户名，未填写时不添加
                strQuery += " and LoginName={2}";
                allParams[2] = textBox_UserName.Text;
            }
            if (textBox_ClientIP.Text.Length > 0)
            {
                // 用户登录的IP地址，未填写时不添加
                strQuery += " and ClientAddress={3}";
                allParams[3] = textBox_ClientIP.Text;
            }
            if (comboBox_OnlineType.SelectedIndex > 0)
            {
                //comboBox_OnlineType.SelectedIndex:0不限,1在线,2离线
                //IsTimeout:0离线,1在线
                strQuery += " and {4}=(case when [LogoutTime] is null and IsTimeout!=1 then 1 else 0 end)";
                int isTimeoutFlag = 0;
                if (comboBox_OnlineType.SelectedIndex == 1)
                {
                    isTimeoutFlag = 1;
                }
                else if (comboBox_OnlineType.SelectedIndex == 2)
                {
                    isTimeoutFlag = 0;
                }
                allParams[4] = isTimeoutFlag;
                //// 用户登录类型
                //if (comboBox_OnlineType.SelectedIndex == 1)
                //{
                //    // 在线即当今还没有退出，退出时间为null
                //    strQuery += " and LogoutTime is null";
                //}
                //else
                //{
                //    // 离线用户的退出时间不为null
                //    strQuery += " and LogoutTime is not null";
                //}
            }
            if (comboBox_ClientType.SelectedIndex > 0)
            {
                // public enum ModuleType
                // {
                //     Unknown = -1,
                //     ECServer = 0,
                //     VideoClient = 1,
                //     EMap = 2,
                //     SynchronizeService = 3,
                //     StreamingServer = 4,
                //     RuleServer = 5,
                //     TriggerServer = 6,
                //     RuleDefClient = 7,
                //     RuleMonitorClient = 8,
                //     NetworkManagementClient = 9,
                //     KeyboardConsole = 10,
                //     HUSClient = 11,
                //     SDKClient = 12,
                // }
                // 客户端类型
                int iClientType = 0;
                switch (comboBox_ClientType.SelectedIndex)
                {
                    case 1:
                        // 数据管理中心
                        iClientType = 0;
                        break;
                    case 2:
                        // 预案编程
                        iClientType = 7;
                        break;
                    case 3:
                        // 网管工具
                        iClientType = 9;
                        break;
                    case 4:
                        // 键盘控制台
                        iClientType = 10;
                        break;
                    case 5:
                        // 客户端
                        iClientType = 11;
                        break;
                    case 6:
                        // SDK
                        iClientType = 12;
                        break;
                }
                strQuery += " and LoginAppID={5}";
                allParams[5] = iClientType;
            }

            try
            {
                m_nLogCount = m_aLogQuery.QueryRecordsCount<UserLoginRecord>(strQuery, allParams);
            }
            catch (PlayVideoFailedException ex)
            {
                MessageBox.Show(ex.Reason.ToString());
            }
            catch (Exception ex2)
            {
            }
            finally
            {
            }

            // 记录查询结果总数
            m_nLogCount = (m_nLogCount < 0) ? 0 : m_nLogCount;
            m_nLogNowStartIndex = 0;
        }

        // 从iStartIndex开始进行分页查询，每次查询最大条数为m_nOnceQueryCount
        void QueryUserLoginLogs(int iStartIndex)
        {
            textBox_IndexCount.Text = (iStartIndex + 1).ToString() + "/" + m_nLogCount.ToString();
            if (iStartIndex >= m_nLogCount)
            {
                return;
            }

            if (null == m_aLogQuery)
            {
                m_aLogQuery = LogQuery.GetInstance();
            }

            object[] allParams = new object[6];

            //计算登入登出时间逻辑
            string strQuery = "((LoginTime between {0} and {1}) OR (ISNULL(LogoutTime,dateadd(second,LoginTimeOut,LastActiveTime)) between {0} and {1}))";
            allParams[0] = dateTimePicker_StartTime.Value;
            allParams[1] = dateTimePicker_EndTime.Value;

            if (textBox_UserName.Text.Length > 0)
            {
                strQuery += " and LoginName={2}";
                allParams[2] = textBox_UserName.Text;
            }
            if (textBox_ClientIP.Text.Length > 0)
            {
                strQuery += " and ClientAddress={3}";
                allParams[3] = textBox_ClientIP.Text;
            }
            if (comboBox_OnlineType.SelectedIndex > 0)
            {
                //comboBox_OnlineType.SelectedIndex:0不限,1在线,2离线
                //IsTimeout:0离线,1在线
                strQuery += " and {4}=(case when [LogoutTime] is null and IsTimeout!=1 then 1 else 0 end)";
                int isTimeoutFlag = 0;
                if (comboBox_OnlineType.SelectedIndex == 1)
                {
                    isTimeoutFlag = 1;
                }
                else if (comboBox_OnlineType.SelectedIndex == 2)
                {
                    isTimeoutFlag = 0;
                }
                allParams[4] = isTimeoutFlag;
            }
            if (comboBox_ClientType.SelectedIndex > 0)
            {
                int iClientType = 0;
                switch (comboBox_ClientType.SelectedIndex)
                {
                    case 1:
                        iClientType = 0;
                        break;
                    case 2:
                        iClientType = 7;
                        break;
                    case 3:
                        iClientType = 9;
                        break;
                    case 4:
                        iClientType = 10;
                        break;
                    case 5:
                        iClientType = 11;
                        break;
                    case 6:
                        iClientType = 12;
                        break;
                }
                strQuery += " and LoginAppID={5}";
                allParams[5] = iClientType;
            }

            // 计算当前能查询的最大条数
            int iSelectCount = (iStartIndex + m_nOnceQueryCount) > m_nLogCount ? (m_nLogCount - iStartIndex) : m_nOnceQueryCount;

            try
            {
                List<UserLoginRecord> usl = m_aLogQuery.QueryRecords<UserLoginRecord>(strQuery, (iStartIndex + 1), iSelectCount, allParams);
                if (usl != null && usl.Count>0)
                {
                    // 分条添加到日志记录列表中
                    foreach (UserLoginRecord ulr in usl)
                    {
                        if (ulr != null)
                        {
                            ListViewItem lvItem = new ListViewItem(ulr.LoginName);
                            lvItem.SubItems.Add(ulr.LoginTime.ToString());
                            lvItem.SubItems.Add(ulr.LastActiveTime.ToString());
                            lvItem.SubItems.Add(ulr.ClientAddress);
                            // 显示登录客户端类型的中文内容
                            switch(ulr.LoginAppID)
                            {
                                case 0:
                                    lvItem.SubItems.Add("数据管理中心");
                                    break;
                                case 1:
                                    lvItem.SubItems.Add("VideoClient");
                                    break;
                                case 2:
                                    lvItem.SubItems.Add("EMap");
                                    break;
                                case 3:
                                    lvItem.SubItems.Add("SynchronizeService");
                                    break;
                                case 4:
                                    lvItem.SubItems.Add("StreamingServer");
                                    break;
                                case 5:
                                    lvItem.SubItems.Add("RuleServer");
                                    break;
                                case 6:
                                    lvItem.SubItems.Add("TriggerServer");
                                    break;
                                case 7:
                                    lvItem.SubItems.Add("预案编程");
                                    break;
                                case 8:
                                    lvItem.SubItems.Add("RuleMonitorClient");
                                    break;
                                case 9:
                                    lvItem.SubItems.Add("网管工具");
                                    break;
                                case 10:
                                    lvItem.SubItems.Add("键盘控制台");
                                    break;
                                case 11:
                                    lvItem.SubItems.Add("客户端");
                                    break;
                                case 12:
                                    lvItem.SubItems.Add("SDK客户端");
                                    break;
                                default:
                                    lvItem.SubItems.Add(ulr.LoginAppID.ToString());
                                    break;
                            }

                            //计算离线时间
                            string tempLogoutTime = String.Empty;
                            if(ulr.LogoutTime != null)
                            {
                                tempLogoutTime = ulr.LogoutTime.ToString();
                            }
                            else
                            {
                                if(ulr.IsTimeout == 1)
                                {
                                    tempLogoutTime = ulr.LastActiveTime.ToString();
                                }
                            }
                            lvItem.SubItems.Add(tempLogoutTime);

                            listView_Log.Items.Add(lvItem);
                        }
                    }
                }
            }
            catch (PlayVideoFailedException ex)
            {
                MessageBox.Show(ex.Reason.ToString());
            }
            catch (Exception ex2)
            {
            }
            finally
            {
            }
        }

        // 查询设备操作记录总数
        void QueryDeviceOperationLogsCount()
        {
            if (null == m_aLogQuery)
            {
                m_aLogQuery = LogQuery.GetInstance();
            }

            // 过滤条件集合
            object[] allParams = new object[7];
            // 起始时间
            string strQuery = "DateTime>{0}";
            allParams[0] = dateTimePicker_StartTime.Value;
            // 结束时间
            strQuery += " and DateTime<{1}";
            allParams[1] = dateTimePicker_EndTime.Value;
            if (textBox_DeviceName.Text.Length > 0)
            {
                // 设备名称，未填写时不添加
                strQuery += " and DeviceName={2}";
                allParams[2] = textBox_DeviceName.Text;
            }
            if (textBox_UserName.Text.Length > 0)
            {
                // 用户名，未填写时不添加
                strQuery += " and UserName={3}";
                allParams[3] = textBox_UserName.Text;
            }
            if (textBox_Terminal.Text.Length > 0)
            {
                // 操作终端，未填写时不添加
                strQuery += " and Terminal={4}";
                allParams[4] = textBox_Terminal.Text;
            }
            if (textBox_Content.Text.Length > 0)
            {
                // 操作内容，未填写时不添加
                strQuery += " and Operation={5}";
                allParams[5] = textBox_Content.Text;
            }
            if (textBox_Result.Text.Length > 0)
            {
                // 操作结果，未填写时不添加
                strQuery += " and Result={6}";
                allParams[6] = textBox_Result.Text;
            }

            try
            {
                m_nLogCount = m_aLogQuery.QueryRecordsCount<DeviceOperationRecord>(strQuery, allParams);
            }
            catch (PlayVideoFailedException ex)
            {
                MessageBox.Show(ex.Reason.ToString());
            }
            catch (Exception ex2)
            {
            }
            finally
            {
            }

            // 记录本次查询总数
            m_nLogCount = (m_nLogCount < 0) ? 0 : m_nLogCount;
            m_nLogNowStartIndex = 0;
        }

        // 分页查询设备操作日志
        void QueryDeviceOperationLogs(int iStartIndex)
        {
            textBox_IndexCount.Text = (iStartIndex + 1).ToString() + "/" + m_nLogCount.ToString();
            if (iStartIndex>=m_nLogCount)
            {
                return;
            }

            if (null == m_aLogQuery)
            {
                m_aLogQuery = LogQuery.GetInstance();
            }

            // 过滤条件集合
            object[] allParams = new object[7];
            // 起始时间
            string strQuery = "DateTime>{0}";
            allParams[0] = dateTimePicker_StartTime.Value;
            // 结束时间
            strQuery += " and DateTime<{1}";
            allParams[1] = dateTimePicker_EndTime.Value;
            if (textBox_DeviceName.Text.Length > 0)
            {
                // 设备名称
                strQuery += " and DeviceName={2}";
                allParams[2] = textBox_DeviceName.Text;
            }
            if (textBox_UserName.Text.Length > 0)
            {
                // 用户名
                strQuery += " and UserName={3}";
                allParams[3] = textBox_UserName.Text;
            }
            if (textBox_Terminal.Text.Length > 0)
            {
                // 操作终端
                strQuery += " and Terminal={4}";
                allParams[4] = textBox_Terminal.Text;
            }
            if (textBox_Content.Text.Length > 0)
            {
                // 操作内容
                strQuery += " and Operation={5}";
                allParams[5] = textBox_Content.Text;
            }
            if (textBox_Result.Text.Length > 0)
            {
                // 操作结果
                strQuery += " and Result={6}";
                allParams[6] = textBox_Result.Text;
            }

            int iSelectCount = (iStartIndex + m_nOnceQueryCount) > m_nLogCount ? (m_nLogCount - iStartIndex) : m_nOnceQueryCount;

            try
            {
                List<DeviceOperationRecord> usl = m_aLogQuery.QueryRecords<DeviceOperationRecord>(strQuery, (iStartIndex + 1), iSelectCount, allParams);
                if (usl != null && usl.Count > 0)
                {
                    // 分条放入日志列表
                    foreach (DeviceOperationRecord dor in usl)
                    {
                        if (dor != null)
                        {
                            ListViewItem lvItem = new ListViewItem(dor.UserName);
                            lvItem.SubItems.Add(dor.DeviceName);
                            lvItem.SubItems.Add(dor.DateTime.ToString());
                            lvItem.SubItems.Add(dor.Operation);
                            lvItem.SubItems.Add(dor.Terminal);
                            lvItem.SubItems.Add(dor.Result);
                            listView_Log.Items.Add(lvItem);
                        }
                    }
                }
            }
            catch (PlayVideoFailedException ex)
            {
                MessageBox.Show(ex.Reason.ToString());
            }
            catch (Exception ex2)
            {
            }
            finally
            {
            }
        }

        // 查询设备报警总数
        void QueryDeviceAlarmLogsCount()
        {
            if (null == m_aLogQuery)
            {
                m_aLogQuery = LogQuery.GetInstance();
            }
            // 过滤条件集合
            object[] allParams = new object[13];
            // 起始时间
            string strQuery = "FirstTime>{0}";
            allParams[0] = dateTimePicker_StartTime.Value;
            // 结束时间
            strQuery += " and FirstTime<{1}";
            allParams[1] = dateTimePicker_EndTime.Value;
            if (comboBox_ProcessType.SelectedIndex > 0)
            {
                // 处理类型
                if (comboBox_ProcessType.SelectedIndex == 1)
                {
                    // 已处理表示其最后时间不为空
                    strQuery += " and LastTime is not null";
                }
                else
                {
                    // 未处理表示其最后时间为空
                    strQuery += " and LastTime is null";
                }
            }
            if (comboBox_AlarmType.SelectedIndex>0)
            {
                // 报警类型
                switch (comboBox_AlarmType.SelectedIndex)
                {
                    case 1:
                        // 非阻塞报警
                        strQuery += " and Category='UA'";
                        break;
                    case 2:
                        // 超时报警
                        strQuery += " and Category='EA'";
                       break;
                    case 3:
                        // 阻塞报警
                       strQuery += " and Category='BA'";
                        break;
                    case 4:
                        // 状态
                        strQuery += " and Category='S'";
                        break;
                    case 5:
                        // 事件
                        strQuery += " and Category='E'";
                        break;
                }
            }
            if (textBox_DeviceName.Text.Length > 0)
            {
                // 设备名称
                strQuery += " and DeviceName={4}";
                allParams[4] = textBox_DeviceName.Text;
            }
            if (textBox_DeviceIP.Text.Length>0)
            {
                // 设备地址
                strQuery += " and Address={5}";
                allParams[5] = textBox_DeviceIP.Text;
            }
            if (textBox_Type.Text.Length > 0)
            {
                // 设备类型名称
                strQuery += " and DeviceTypeName={6}";
                allParams[6] = textBox_Type.Text;
            }
            if (textBox_DeviceTypeLabel.Text.Length>0)
            {
                // 设备类型标记
                strQuery += " and DeviceTypeTag={7}";
                allParams[7] = textBox_DeviceTypeLabel.Text;
            }
            if (textBox_AlarmCode.Text.Length > 0)
            {
                // 报警编号
                strQuery += " and AlarmCode={8}";
                allParams[8] = textBox_AlarmCode.Text;
            }
            if (textBox_AlarmName.Text.Length > 0)
            {
                // 报警名称
                strQuery += " and AlarmName={9}";
                allParams[9] = textBox_AlarmName.Text;
            }
            if (textBox_AlarmDescription.Text.Length > 0)
            {
                // 报警描述
                strQuery += " and AlarmDescription={10}";
                allParams[10] = textBox_AlarmDescription.Text;
            }
            if (textBox_AlarmPriority.Text.Length > 0)
            {
                // 报警优先级
                strQuery += " and AlarmPriority>={11}";
                allParams[11] = Convert.ToInt32(textBox_AlarmPriority.Text);
            }
            if (textBox_OccurTimes.Text.Length > 0)
            {
                // 发生次数
                strQuery += " and OccurTimes>={12}";
                allParams[12] = Convert.ToInt32(textBox_OccurTimes.Text);
            }

            try
            {
                m_nLogCount = m_aLogQuery.QueryRecordsCount<DeviceAlarmRecord>(strQuery, allParams);
            }
            catch (PlayVideoFailedException ex)
            {
                MessageBox.Show(ex.Reason.ToString());
            }
            catch (Exception ex2)
            {
            }
            finally
            {
            }

            m_nLogCount = (m_nLogCount < 0) ? 0 : m_nLogCount;
            m_nLogNowStartIndex = 0;
        }

        // 分页查询设备报警日志
        void QueryDeviceAlarmLogs(int iStartIndex)
        {
            textBox_IndexCount.Text = (iStartIndex + 1).ToString() + "/" + m_nLogCount.ToString();
            if (iStartIndex >= m_nLogCount)
            {
                return;
            }

            if (null == m_aLogQuery)
            {
                m_aLogQuery = LogQuery.GetInstance();
            }
            // 过滤条件集合
            object[] allParams = new object[13];
            // 起始时间
            string strQuery = "FirstTime>{0}";
            allParams[0] = dateTimePicker_StartTime.Value;
            // 结束时间
            strQuery += " and FirstTime<{1}";
            allParams[1] = dateTimePicker_EndTime.Value;
            if (comboBox_ProcessType.SelectedIndex > 0)
            {
                // 报警处理类型
                if (comboBox_ProcessType.SelectedIndex == 1)
                {
                    strQuery += " and LastTime is not null";
                }
                else
                {
                    strQuery += " and LastTime is null";
                }
            }
            if (comboBox_AlarmType.SelectedIndex > 0)
            {
                // 报警类别
                switch (comboBox_AlarmType.SelectedIndex)
                {
                    case 1:
                        strQuery += " and Category='UA'";
                        break;
                    case 2:
                        strQuery += " and Category='EA'";
                        break;
                    case 3:
                        strQuery += " and Category='BA'";
                        break;
                    case 4:
                        strQuery += " and Category='S'";
                        break;
                    case 5:
                        strQuery += " and Category='E'";
                        break;
                }
            }
            if (textBox_DeviceName.Text.Length > 0)
            {
                // 设备名称
                strQuery += " and DeviceName={4}";
                allParams[4] = textBox_DeviceName.Text;
            }
            if (textBox_DeviceIP.Text.Length > 0)
            {
                // 设备地址
                strQuery += " and Address={5}";
                allParams[5] = textBox_DeviceIP.Text;
            }
            if (textBox_Type.Text.Length > 0)
            {
                // 设备类型名称
                strQuery += " and DeviceTypeName={6}";
                allParams[6] = textBox_Type.Text;
            }
            if (textBox_DeviceTypeLabel.Text.Length > 0)
            {
                // 设备类型标签
                strQuery += " and DeviceTypeTag={7}";
                allParams[7] = textBox_DeviceTypeLabel.Text;
            }
            if (textBox_AlarmCode.Text.Length > 0)
            {
                // 报警编号
                strQuery += " and AlarmCode={8}";
                allParams[8] = textBox_AlarmCode.Text;
            }
            if (textBox_AlarmName.Text.Length > 0)
            {
                // 报警名称
                strQuery += " and AlarmName={9}";
                allParams[9] = textBox_AlarmName.Text;
            }
            if (textBox_AlarmDescription.Text.Length > 0)
            {
                // 报警描述
                strQuery += " and AlarmDescription={10}";
                allParams[10] = textBox_AlarmDescription.Text;
            }
            if (textBox_AlarmPriority.Text.Length > 0)
            {
                // 报警优先级
                strQuery += " and AlarmPriority>={11}";
                allParams[11] = Convert.ToInt32(textBox_AlarmPriority.Text);
            }
            if (textBox_OccurTimes.Text.Length > 0)
            {
                // 报警次数
                strQuery += " and OccurTimes>={12}";
                allParams[12] = Convert.ToInt32(textBox_OccurTimes.Text);
            }

            // 计算本次分页查询能查到的最大条数
            int iSelectCount = (iStartIndex + m_nOnceQueryCount) > m_nLogCount ? (m_nLogCount - iStartIndex) : m_nOnceQueryCount;

            try
            {
                List<DeviceAlarmRecord> usl = m_aLogQuery.QueryRecords<DeviceAlarmRecord>(strQuery, (iStartIndex + 1), iSelectCount, allParams);
                if (usl!=null && usl.Count>0)
                {
                    // 分条显示到日志列表中
                    foreach (DeviceAlarmRecord dar in usl)
                    {
                        if (dar != null)
                        {
                            ListViewItem lvItem = new ListViewItem(dar.DeviceName);
                            lvItem.SubItems.Add(dar.DeviceTypeName);
                            lvItem.SubItems.Add(dar.AlarmName);
                            lvItem.SubItems.Add(dar.FirstTime.ToString());
                            lvItem.SubItems.Add(dar.LastTime.ToString());
                            lvItem.SubItems.Add(dar.OccurTimes.ToString());
                            // 显示报警类别中文名称
                            if (dar.Category == "UA")
                            {
                                lvItem.SubItems.Add("非阻塞报警");
                            }
                            else if (dar.Category == "EA")
                            {
                                lvItem.SubItems.Add("超时报警");
                            }
                            else if (dar.Category == "BA")
                            {
                                lvItem.SubItems.Add("阻塞报警");
                            }
                            else if (dar.Category == "E")
                            {
                                lvItem.SubItems.Add("事件");
                            }
                            else if (dar.Category == "S")
                            {
                                lvItem.SubItems.Add("状态");
                            }
                            else
                            {
                                lvItem.SubItems.Add(dar.Category);
                            }
                            lvItem.SubItems.Add(dar.Address);
                            lvItem.SubItems.Add(dar.DeviceTypeTag);
                            lvItem.SubItems.Add(dar.AlarmCode);
                            lvItem.SubItems.Add(dar.AlarmDescription);
                            lvItem.SubItems.Add(dar.AlarmPriority.ToString());
                            listView_Log.Items.Add(lvItem);
                        }
                    }
                }
            }
            catch (PlayVideoFailedException ex)
            {
                MessageBox.Show(ex.Reason.ToString());
            }
            catch (Exception ex2)
            {
            }
            finally
            {
            }
        }

        // 点击“查询”按钮时的处理过程
        private void Button_Search_Click(object sender, EventArgs e)
        {
            listView_Log.Items.Clear();

            m_nLogCount = 0;
            m_nLogNowStartIndex = 0;

            // 根据选择的日志类型进行查询
            if (comboBox_Catalog.SelectedIndex == 0)
            {   // UserLogIn
                QueryUserLoginLogsCount();
                QueryUserLoginLogs(m_nLogNowStartIndex);
            }
            else if (comboBox_Catalog.SelectedIndex == 1)
            {   // DeviceOperation
                QueryDeviceOperationLogsCount();
                QueryDeviceOperationLogs(m_nLogNowStartIndex);
            }
            else if (comboBox_Catalog.SelectedIndex == 2)
            {   // DeviceAlarm
                QueryDeviceAlarmLogsCount();
                QueryDeviceAlarmLogs(m_nLogNowStartIndex);
            }
        }

        // 根据查询类型显示查询过滤条件及日志查询结果列表的表头
        private void comboBox_Catalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_Log.Items.Clear();

            m_nLogCount = 0;
            m_nLogNowStartIndex = 0;

            if (comboBox_Catalog.SelectedIndex == 0)
            {   // 用户登录日志
                dateTimePicker_StartTime.Enabled = true;
                dateTimePicker_EndTime.Enabled = true;
                textBox_UserName.Enabled = true;
                textBox_ClientIP.Enabled = true;
                comboBox_OnlineType.Enabled = true;
                comboBox_ClientType.Enabled = true;
                textBox_Terminal.Enabled = false;
                textBox_Content.Enabled = false;
                textBox_Result.Enabled = false;
                comboBox_ProcessType.Enabled = false;
                comboBox_AlarmType.Enabled = false;
                textBox_DeviceName.Enabled = false;
                textBox_DeviceIP.Enabled = false;
                textBox_Type.Enabled = false;
                textBox_DeviceTypeLabel.Enabled = false;
                textBox_AlarmCode.Enabled = false;
                textBox_AlarmName.Enabled = false;
                textBox_AlarmDescription.Enabled = false;
                textBox_AlarmPriority.Enabled = false;
                textBox_OccurTimes.Enabled = false;

                this.columnHeader1.Text = "LoginName";
                this.columnHeader2.Text = "LoginTime";
                this.columnHeader3.Text = "LastActiveTime";
                this.columnHeader4.Text = "ClientAddress";
                this.columnHeader5.Text = "ClientType";
                this.columnHeader6.Text = "LogoutTime";
                this.columnHeader7.Text = "";
                this.columnHeader8.Text = "";
                this.columnHeader9.Text = "";
                this.columnHeader10.Text = "";
                this.columnHeader11.Text = "";
                this.columnHeader12.Text = "";
            }
            else if (comboBox_Catalog.SelectedIndex == 1)
            {   // 设备操作日志
                dateTimePicker_StartTime.Enabled = true;
                dateTimePicker_EndTime.Enabled = true;
                textBox_UserName.Enabled = true;
                textBox_ClientIP.Enabled = false;
                comboBox_OnlineType.Enabled = false;
                comboBox_ClientType.Enabled = false;
                textBox_Terminal.Enabled = true;
                textBox_Content.Enabled = true;
                textBox_Result.Enabled = true;
                comboBox_ProcessType.Enabled = false;
                comboBox_AlarmType.Enabled = false;
                textBox_DeviceName.Enabled = true;
                textBox_DeviceIP.Enabled = false;
                textBox_Type.Enabled = false;
                textBox_DeviceTypeLabel.Enabled = false;
                textBox_AlarmCode.Enabled = false;
                textBox_AlarmName.Enabled = false;
                textBox_AlarmDescription.Enabled = false;
                textBox_AlarmPriority.Enabled = false;
                textBox_OccurTimes.Enabled = false;

                this.columnHeader1.Text = "UserName";
                this.columnHeader2.Text = "DeviceName";
                this.columnHeader3.Text = "DateTime";
                this.columnHeader4.Text = "Operation";
                this.columnHeader5.Text = "Terminal";
                this.columnHeader6.Text = "Result";
                this.columnHeader7.Text = "";
                this.columnHeader8.Text = "";
                this.columnHeader9.Text = "";
                this.columnHeader10.Text = "";
                this.columnHeader11.Text = "";
                this.columnHeader12.Text = "";
            }
            else if (comboBox_Catalog.SelectedIndex == 2)
            {   // 设备报警日志
                dateTimePicker_StartTime.Enabled = true;
                dateTimePicker_EndTime.Enabled = true;
                textBox_UserName.Enabled = false;
                textBox_ClientIP.Enabled = false;
                comboBox_OnlineType.Enabled = false;
                comboBox_ClientType.Enabled = false;
                textBox_Terminal.Enabled = false;
                textBox_Content.Enabled = false;
                textBox_Result.Enabled = false;
                comboBox_ProcessType.Enabled = true;
                comboBox_AlarmType.Enabled = true;
                textBox_DeviceName.Enabled = true;
                textBox_DeviceIP.Enabled = true;
                textBox_Type.Enabled = true;
                textBox_DeviceTypeLabel.Enabled = true;
                textBox_AlarmCode.Enabled = true;
                textBox_AlarmName.Enabled = true;
                textBox_AlarmDescription.Enabled = true;
                textBox_AlarmPriority.Enabled = true;
                textBox_OccurTimes.Enabled = true;

                this.columnHeader1.Text = "DeviceName";
                this.columnHeader2.Text = "DeviceTypeName";
                this.columnHeader3.Text = "AlarmName";
                this.columnHeader4.Text = "FirstTime";
                this.columnHeader5.Text = "LastTime";
                this.columnHeader6.Text = "OccurTimes";
                this.columnHeader7.Text = "AlarmType";
                this.columnHeader8.Text = "Address";
                this.columnHeader9.Text = "DeviceTypeTag";
                this.columnHeader10.Text = "AlarmCode";
                this.columnHeader11.Text = "AlarmDescription";
                this.columnHeader12.Text = "AlarmPriority";
            }

            comboBox_Catalog_Init();
        }

        // 查询过滤条件初始化
        private void comboBox_Catalog_Init()
        {
            dateTimePicker_StartTime.Value = DateTime.Now.AddHours(-2);
            dateTimePicker_EndTime.Value = DateTime.Now;
            textBox_UserName.Text = "";
            textBox_ClientIP.Text = "";
            textBox_Terminal.Text = "";
            textBox_Content.Text = "";
            textBox_Result.Text = "";
            textBox_DeviceName.Text = "";
            textBox_Type.Text = "";
        }

        // 分页查询
        void QueryInPage(int iStartIndex)
        {
            // 清除日志查询结果列表中上次查询的结果
            listView_Log.Items.Clear();

            if (comboBox_Catalog.SelectedIndex == 0)
            {   // UserLogIn
                QueryUserLoginLogs(iStartIndex);
            }
            else if (comboBox_Catalog.SelectedIndex == 1)
            {   // DeviceOperation
                QueryDeviceOperationLogs(iStartIndex);
            }
            else if (comboBox_Catalog.SelectedIndex == 2)
            {   // DeviceAlarm
                QueryDeviceAlarmLogs(iStartIndex);
            }
        }

        // 查询日志的第一页
        private void button_Begin_Click(object sender, EventArgs e)
        {
            // 设置起始查询页为0
            m_nLogNowStartIndex = 0;
            QueryInPage(m_nLogNowStartIndex);
        }

        // 查询上一页
        private void button_Preview_Click(object sender, EventArgs e)
        {
            m_nLogNowStartIndex = (m_nLogNowStartIndex - m_nOnceQueryCount) < 0 ? 0 : (m_nLogNowStartIndex - m_nOnceQueryCount);
            QueryInPage(m_nLogNowStartIndex);
        }

        // 查询下一页
        private void button_Next_Click(object sender, EventArgs e)
        {
            m_nLogNowStartIndex = (m_nLogNowStartIndex + m_nOnceQueryCount) >= m_nLogCount ? m_nLogNowStartIndex : (m_nLogNowStartIndex + m_nOnceQueryCount);
            QueryInPage(m_nLogNowStartIndex);
        }

        // 查询日志的最后一页
        private void button_End_Click(object sender, EventArgs e)
        {
            m_nLogNowStartIndex = (m_nLogCount - m_nOnceQueryCount) < 0 ? 0 : (m_nLogCount - m_nOnceQueryCount);
            QueryInPage(m_nLogNowStartIndex);
        }

    }
}
