namespace HUSSDKDemo
{
    partial class Form_QueryLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_UserName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.dateTimePicker_StartTime = new System.Windows.Forms.DateTimePicker();
            this.label_StartTime = new System.Windows.Forms.Label();
            this.label_EndTime = new System.Windows.Forms.Label();
            this.dateTimePicker_EndTime = new System.Windows.Forms.DateTimePicker();
            this.Button_Search = new System.Windows.Forms.Button();
            this.comboBox_Catalog = new System.Windows.Forms.ComboBox();
            this.label_ClientIP = new System.Windows.Forms.Label();
            this.label_DeviceName = new System.Windows.Forms.Label();
            this.label_Terminal = new System.Windows.Forms.Label();
            this.label_Content = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.textBox_ClientIP = new System.Windows.Forms.TextBox();
            this.textBox_Terminal = new System.Windows.Forms.TextBox();
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.textBox_DeviceName = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.listView_Log = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Begin = new System.Windows.Forms.Button();
            this.button_Preview = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_End = new System.Windows.Forms.Button();
            this.textBox_IndexCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_OnlineType = new System.Windows.Forms.ComboBox();
            this.comboBox_ClientType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_DeviceIP = new System.Windows.Forms.TextBox();
            this.textBox_AlarmCode = new System.Windows.Forms.TextBox();
            this.textBox_AlarmName = new System.Windows.Forms.TextBox();
            this.textBox_AlarmDescription = new System.Windows.Forms.TextBox();
            this.textBox_AlarmPriority = new System.Windows.Forms.TextBox();
            this.textBox_OccurTimes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_AlarmType = new System.Windows.Forms.ComboBox();
            this.comboBox_ProcessType = new System.Windows.Forms.ComboBox();
            this.label1_DeviceTypeLabel = new System.Windows.Forms.Label();
            this.textBox_DeviceTypeLabel = new System.Windows.Forms.TextBox();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(12, 118);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(64, 13);
            this.label_UserName.TabIndex = 1;
            this.label_UserName.Text = "LoginName:";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(123, 113);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(180, 20);
            this.textBox_UserName.TabIndex = 3;
            this.textBox_UserName.Text = "fb";
            // 
            // dateTimePicker_StartTime
            // 
            this.dateTimePicker_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_StartTime.Location = new System.Drawing.Point(123, 53);
            this.dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            this.dateTimePicker_StartTime.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker_StartTime.TabIndex = 1;
            // 
            // label_StartTime
            // 
            this.label_StartTime.AutoSize = true;
            this.label_StartTime.Location = new System.Drawing.Point(12, 58);
            this.label_StartTime.Name = "label_StartTime";
            this.label_StartTime.Size = new System.Drawing.Size(55, 13);
            this.label_StartTime.TabIndex = 1;
            this.label_StartTime.Text = "StartTime:";
            // 
            // label_EndTime
            // 
            this.label_EndTime.AutoSize = true;
            this.label_EndTime.Location = new System.Drawing.Point(12, 88);
            this.label_EndTime.Name = "label_EndTime";
            this.label_EndTime.Size = new System.Drawing.Size(52, 13);
            this.label_EndTime.TabIndex = 1;
            this.label_EndTime.Text = "EndTime:";
            // 
            // dateTimePicker_EndTime
            // 
            this.dateTimePicker_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_EndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_EndTime.Location = new System.Drawing.Point(123, 83);
            this.dateTimePicker_EndTime.Name = "dateTimePicker_EndTime";
            this.dateTimePicker_EndTime.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker_EndTime.TabIndex = 2;
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(225, 12);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(79, 30);
            this.Button_Search.TabIndex = 10;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // comboBox_Catalog
            // 
            this.comboBox_Catalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Catalog.FormattingEnabled = true;
            this.comboBox_Catalog.Items.AddRange(new object[] {
            "UserLogIn",
            "DeviceOperation",
            "DeviceAlarm"});
            this.comboBox_Catalog.Location = new System.Drawing.Point(15, 18);
            this.comboBox_Catalog.Name = "comboBox_Catalog";
            this.comboBox_Catalog.Size = new System.Drawing.Size(188, 21);
            this.comboBox_Catalog.TabIndex = 0;
            this.comboBox_Catalog.SelectedIndexChanged += new System.EventHandler(this.comboBox_Catalog_SelectedIndexChanged);
            // 
            // label_ClientIP
            // 
            this.label_ClientIP.AutoSize = true;
            this.label_ClientIP.Location = new System.Drawing.Point(12, 148);
            this.label_ClientIP.Name = "label_ClientIP";
            this.label_ClientIP.Size = new System.Drawing.Size(74, 13);
            this.label_ClientIP.TabIndex = 1;
            this.label_ClientIP.Text = "ClientAddress:";
            // 
            // label_DeviceName
            // 
            this.label_DeviceName.AutoSize = true;
            this.label_DeviceName.Location = new System.Drawing.Point(12, 328);
            this.label_DeviceName.Name = "label_DeviceName";
            this.label_DeviceName.Size = new System.Drawing.Size(72, 13);
            this.label_DeviceName.TabIndex = 1;
            this.label_DeviceName.Text = "DeviceName:";
            // 
            // label_Terminal
            // 
            this.label_Terminal.AutoSize = true;
            this.label_Terminal.Location = new System.Drawing.Point(12, 238);
            this.label_Terminal.Name = "label_Terminal";
            this.label_Terminal.Size = new System.Drawing.Size(50, 13);
            this.label_Terminal.TabIndex = 1;
            this.label_Terminal.Text = "Terminal:";
            // 
            // label_Content
            // 
            this.label_Content.AutoSize = true;
            this.label_Content.Location = new System.Drawing.Point(12, 268);
            this.label_Content.Name = "label_Content";
            this.label_Content.Size = new System.Drawing.Size(56, 13);
            this.label_Content.TabIndex = 1;
            this.label_Content.Text = "Operation:";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(12, 298);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(40, 13);
            this.label_Result.TabIndex = 1;
            this.label_Result.Text = "Result:";
            // 
            // textBox_ClientIP
            // 
            this.textBox_ClientIP.Location = new System.Drawing.Point(123, 143);
            this.textBox_ClientIP.Name = "textBox_ClientIP";
            this.textBox_ClientIP.Size = new System.Drawing.Size(180, 20);
            this.textBox_ClientIP.TabIndex = 4;
            this.textBox_ClientIP.Text = "192.168.250.95";
            // 
            // textBox_Terminal
            // 
            this.textBox_Terminal.Location = new System.Drawing.Point(124, 235);
            this.textBox_Terminal.Name = "textBox_Terminal";
            this.textBox_Terminal.Size = new System.Drawing.Size(180, 20);
            this.textBox_Terminal.TabIndex = 5;
            // 
            // textBox_Content
            // 
            this.textBox_Content.Location = new System.Drawing.Point(124, 265);
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.Size = new System.Drawing.Size(180, 20);
            this.textBox_Content.TabIndex = 6;
            // 
            // textBox_DeviceName
            // 
            this.textBox_DeviceName.Location = new System.Drawing.Point(124, 325);
            this.textBox_DeviceName.Name = "textBox_DeviceName";
            this.textBox_DeviceName.Size = new System.Drawing.Size(180, 20);
            this.textBox_DeviceName.TabIndex = 8;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(124, 295);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(180, 20);
            this.textBox_Result.TabIndex = 7;
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(12, 446);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(96, 13);
            this.label_Type.TabIndex = 1;
            this.label_Type.Text = "DeviceTypeName:";
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(124, 443);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(180, 20);
            this.textBox_Type.TabIndex = 9;
            // 
            // listView_Log
            // 
            this.listView_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView_Log.FullRowSelect = true;
            this.listView_Log.HideSelection = false;
            this.listView_Log.Location = new System.Drawing.Point(321, 12);
            this.listView_Log.MultiSelect = false;
            this.listView_Log.Name = "listView_Log";
            this.listView_Log.Size = new System.Drawing.Size(678, 606);
            this.listView_Log.TabIndex = 16;
            this.listView_Log.UseCompatibleStateImageBehavior = false;
            this.listView_Log.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "LoginName";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "LoginTime";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LastActiveTime";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ClientAddress";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.Width = 84;
            // 
            // button_Begin
            // 
            this.button_Begin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Begin.Location = new System.Drawing.Point(320, 623);
            this.button_Begin.Name = "button_Begin";
            this.button_Begin.Size = new System.Drawing.Size(28, 30);
            this.button_Begin.TabIndex = 11;
            this.button_Begin.Text = "|<";
            this.button_Begin.UseVisualStyleBackColor = true;
            this.button_Begin.Click += new System.EventHandler(this.button_Begin_Click);
            // 
            // button_Preview
            // 
            this.button_Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Preview.Location = new System.Drawing.Point(350, 623);
            this.button_Preview.Name = "button_Preview";
            this.button_Preview.Size = new System.Drawing.Size(28, 30);
            this.button_Preview.TabIndex = 12;
            this.button_Preview.Text = "<<";
            this.button_Preview.UseVisualStyleBackColor = true;
            this.button_Preview.Click += new System.EventHandler(this.button_Preview_Click);
            // 
            // button_Next
            // 
            this.button_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Next.Location = new System.Drawing.Point(474, 623);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(28, 30);
            this.button_Next.TabIndex = 13;
            this.button_Next.Text = ">>";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_End
            // 
            this.button_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_End.Location = new System.Drawing.Point(504, 623);
            this.button_End.Name = "button_End";
            this.button_End.Size = new System.Drawing.Size(28, 30);
            this.button_End.TabIndex = 14;
            this.button_End.Text = ">|";
            this.button_End.UseVisualStyleBackColor = true;
            this.button_End.Click += new System.EventHandler(this.button_End_Click);
            // 
            // textBox_IndexCount
            // 
            this.textBox_IndexCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_IndexCount.Enabled = false;
            this.textBox_IndexCount.Location = new System.Drawing.Point(386, 628);
            this.textBox_IndexCount.Name = "textBox_IndexCount";
            this.textBox_IndexCount.Size = new System.Drawing.Size(81, 20);
            this.textBox_IndexCount.TabIndex = 17;
            this.textBox_IndexCount.Text = "0/0";
            this.textBox_IndexCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "OnlineType:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ClientType:";
            // 
            // comboBox_OnlineType
            // 
            this.comboBox_OnlineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OnlineType.FormattingEnabled = true;
            this.comboBox_OnlineType.Items.AddRange(new object[] {
            "不限",
            "在线",
            "离线"});
            this.comboBox_OnlineType.Location = new System.Drawing.Point(124, 173);
            this.comboBox_OnlineType.Name = "comboBox_OnlineType";
            this.comboBox_OnlineType.Size = new System.Drawing.Size(180, 21);
            this.comboBox_OnlineType.TabIndex = 19;
            // 
            // comboBox_ClientType
            // 
            this.comboBox_ClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ClientType.FormattingEnabled = true;
            this.comboBox_ClientType.Items.AddRange(new object[] {
            "不限",
            "数据管理中心",
            "预案编程",
            "网管工具",
            "键盘控制台",
            "客户端",
            "SDK"});
            this.comboBox_ClientType.Location = new System.Drawing.Point(124, 204);
            this.comboBox_ClientType.Name = "comboBox_ClientType";
            this.comboBox_ClientType.Size = new System.Drawing.Size(180, 21);
            this.comboBox_ClientType.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "AlarmName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "AlarmCode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "AlarmDescription:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "AlarmPriority>=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "OccurTimes>=";
            // 
            // textBox_DeviceIP
            // 
            this.textBox_DeviceIP.Location = new System.Drawing.Point(124, 413);
            this.textBox_DeviceIP.Name = "textBox_DeviceIP";
            this.textBox_DeviceIP.Size = new System.Drawing.Size(180, 20);
            this.textBox_DeviceIP.TabIndex = 23;
            // 
            // textBox_AlarmCode
            // 
            this.textBox_AlarmCode.Location = new System.Drawing.Point(124, 505);
            this.textBox_AlarmCode.Name = "textBox_AlarmCode";
            this.textBox_AlarmCode.Size = new System.Drawing.Size(180, 20);
            this.textBox_AlarmCode.TabIndex = 23;
            // 
            // textBox_AlarmName
            // 
            this.textBox_AlarmName.Location = new System.Drawing.Point(124, 535);
            this.textBox_AlarmName.Name = "textBox_AlarmName";
            this.textBox_AlarmName.Size = new System.Drawing.Size(180, 20);
            this.textBox_AlarmName.TabIndex = 23;
            // 
            // textBox_AlarmDescription
            // 
            this.textBox_AlarmDescription.Location = new System.Drawing.Point(124, 565);
            this.textBox_AlarmDescription.Name = "textBox_AlarmDescription";
            this.textBox_AlarmDescription.Size = new System.Drawing.Size(180, 20);
            this.textBox_AlarmDescription.TabIndex = 23;
            // 
            // textBox_AlarmPriority
            // 
            this.textBox_AlarmPriority.Location = new System.Drawing.Point(124, 595);
            this.textBox_AlarmPriority.Name = "textBox_AlarmPriority";
            this.textBox_AlarmPriority.Size = new System.Drawing.Size(180, 20);
            this.textBox_AlarmPriority.TabIndex = 23;
            // 
            // textBox_OccurTimes
            // 
            this.textBox_OccurTimes.Location = new System.Drawing.Point(124, 625);
            this.textBox_OccurTimes.Name = "textBox_OccurTimes";
            this.textBox_OccurTimes.Size = new System.Drawing.Size(180, 20);
            this.textBox_OccurTimes.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ProcessType:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "AlarmType:";
            // 
            // comboBox_AlarmType
            // 
            this.comboBox_AlarmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AlarmType.FormattingEnabled = true;
            this.comboBox_AlarmType.Items.AddRange(new object[] {
            "不限",
            "非阻塞报警",
            "超时报警",
            "阻塞报警",
            "状态",
            "事件"});
            this.comboBox_AlarmType.Location = new System.Drawing.Point(124, 382);
            this.comboBox_AlarmType.Name = "comboBox_AlarmType";
            this.comboBox_AlarmType.Size = new System.Drawing.Size(180, 21);
            this.comboBox_AlarmType.TabIndex = 20;
            // 
            // comboBox_ProcessType
            // 
            this.comboBox_ProcessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProcessType.FormattingEnabled = true;
            this.comboBox_ProcessType.Items.AddRange(new object[] {
            "不限",
            "已处理",
            "未处理"});
            this.comboBox_ProcessType.Location = new System.Drawing.Point(124, 352);
            this.comboBox_ProcessType.Name = "comboBox_ProcessType";
            this.comboBox_ProcessType.Size = new System.Drawing.Size(180, 21);
            this.comboBox_ProcessType.TabIndex = 20;
            // 
            // label1_DeviceTypeLabel
            // 
            this.label1_DeviceTypeLabel.AutoSize = true;
            this.label1_DeviceTypeLabel.Location = new System.Drawing.Point(12, 477);
            this.label1_DeviceTypeLabel.Name = "label1_DeviceTypeLabel";
            this.label1_DeviceTypeLabel.Size = new System.Drawing.Size(87, 13);
            this.label1_DeviceTypeLabel.TabIndex = 1;
            this.label1_DeviceTypeLabel.Text = "DeviceTypeTag:";
            // 
            // textBox_DeviceTypeLabel
            // 
            this.textBox_DeviceTypeLabel.Location = new System.Drawing.Point(125, 474);
            this.textBox_DeviceTypeLabel.Name = "textBox_DeviceTypeLabel";
            this.textBox_DeviceTypeLabel.Size = new System.Drawing.Size(180, 20);
            this.textBox_DeviceTypeLabel.TabIndex = 9;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "";
            // 
            // Form_QueryLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.textBox_OccurTimes);
            this.Controls.Add(this.textBox_AlarmPriority);
            this.Controls.Add(this.textBox_AlarmDescription);
            this.Controls.Add(this.textBox_AlarmName);
            this.Controls.Add(this.textBox_AlarmCode);
            this.Controls.Add(this.textBox_DeviceIP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_ProcessType);
            this.Controls.Add(this.comboBox_AlarmType);
            this.Controls.Add(this.comboBox_ClientType);
            this.Controls.Add(this.comboBox_OnlineType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_IndexCount);
            this.Controls.Add(this.button_End);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Preview);
            this.Controls.Add(this.button_Begin);
            this.Controls.Add(this.listView_Log);
            this.Controls.Add(this.textBox_DeviceTypeLabel);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_DeviceName);
            this.Controls.Add(this.textBox_Content);
            this.Controls.Add(this.textBox_Terminal);
            this.Controls.Add(this.comboBox_Catalog);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.dateTimePicker_EndTime);
            this.Controls.Add(this.dateTimePicker_StartTime);
            this.Controls.Add(this.textBox_ClientIP);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_EndTime);
            this.Controls.Add(this.label_StartTime);
            this.Controls.Add(this.label_Content);
            this.Controls.Add(this.label1_DeviceTypeLabel);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.label_Terminal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_DeviceName);
            this.Controls.Add(this.label_ClientIP);
            this.Controls.Add(this.label_UserName);
            this.Name = "Form_QueryLog";
            this.Text = "QueryLog";
            this.Load += new System.EventHandler(this.Form_QueryLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartTime;
        private System.Windows.Forms.Label label_StartTime;
        private System.Windows.Forms.Label label_EndTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndTime;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.ComboBox comboBox_Catalog;
        private System.Windows.Forms.Label label_ClientIP;
        private System.Windows.Forms.Label label_DeviceName;
        private System.Windows.Forms.Label label_Terminal;
        private System.Windows.Forms.Label label_Content;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.TextBox textBox_ClientIP;
        private System.Windows.Forms.TextBox textBox_Terminal;
        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.TextBox textBox_DeviceName;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.ListView listView_Log;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button_Begin;
        private System.Windows.Forms.Button button_Preview;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_End;
        private System.Windows.Forms.TextBox textBox_IndexCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_OnlineType;
        private System.Windows.Forms.ComboBox comboBox_ClientType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_DeviceIP;
        private System.Windows.Forms.TextBox textBox_AlarmCode;
        private System.Windows.Forms.TextBox textBox_AlarmName;
        private System.Windows.Forms.TextBox textBox_AlarmDescription;
        private System.Windows.Forms.TextBox textBox_AlarmPriority;
        private System.Windows.Forms.TextBox textBox_OccurTimes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_AlarmType;
        private System.Windows.Forms.ComboBox comboBox_ProcessType;
        private System.Windows.Forms.Label label1_DeviceTypeLabel;
        private System.Windows.Forms.TextBox textBox_DeviceTypeLabel;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}