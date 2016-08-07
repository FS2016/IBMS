namespace HUSSDKDemo
{
    partial class Form_NVRVideo
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
            this.listView_NVRVideo = new System.Windows.Forms.ListView();
            this.columnHeader_Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VideoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column_StreamServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox_VideoWindow = new System.Windows.Forms.PictureBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.dateTimePicker_EndTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_StartTime = new System.Windows.Forms.DateTimePicker();
            this.label_EndTime = new System.Windows.Forms.Label();
            this.label_StartTime = new System.Windows.Forms.Label();
            this.button_Download = new System.Windows.Forms.Button();
            this.button_StopPlay = new System.Windows.Forms.Button();
            this.button_StartPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Sever = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DurationMin = new System.Windows.Forms.TextBox();
            this.textBox_DurationMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_TriggerType = new System.Windows.Forms.ComboBox();
            this.checkBox_Duration = new System.Windows.Forms.CheckBox();
            this.textBox_Location = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_MaxLines = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Rule = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_DeviceType = new System.Windows.Forms.ComboBox();
            this.radioButton_ItemID = new System.Windows.Forms.RadioButton();
            this.radioButton_ItemLoaction = new System.Windows.Forms.RadioButton();
            this.textBox_ItemLocation = new System.Windows.Forms.TextBox();
            this.comboBox_ItemID = new System.Windows.Forms.ComboBox();
            this.comboBox_Camera = new System.Windows.Forms.ComboBox();
            this.radioButton_Camera = new System.Windows.Forms.RadioButton();
            this.radioButton_Location = new System.Windows.Forms.RadioButton();
            this.groupBox_Item = new System.Windows.Forms.GroupBox();
            this.groupBox_Device = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_DownloadEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DownloadStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblFrameTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).BeginInit();
            this.groupBox_Item.SuspendLayout();
            this.groupBox_Device.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_NVRVideo
            // 
            this.listView_NVRVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_NVRVideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Index,
            this.VideoName,
            this.StartTime,
            this.EndTime,
            this.Column_StreamServer});
            this.listView_NVRVideo.FullRowSelect = true;
            this.listView_NVRVideo.HideSelection = false;
            this.listView_NVRVideo.Location = new System.Drawing.Point(15, 145);
            this.listView_NVRVideo.MultiSelect = false;
            this.listView_NVRVideo.Name = "listView_NVRVideo";
            this.listView_NVRVideo.Size = new System.Drawing.Size(391, 470);
            this.listView_NVRVideo.TabIndex = 8;
            this.listView_NVRVideo.UseCompatibleStateImageBehavior = false;
            this.listView_NVRVideo.View = System.Windows.Forms.View.Details;
            this.listView_NVRVideo.SelectedIndexChanged += new System.EventHandler(this.listView_NVRVideo_SelectedIndexChanged);
            // 
            // columnHeader_Index
            // 
            this.columnHeader_Index.Text = "Index";
            // 
            // VideoName
            // 
            this.VideoName.Text = "Name";
            this.VideoName.Width = 141;
            // 
            // StartTime
            // 
            this.StartTime.Text = "StartTime";
            this.StartTime.Width = 133;
            // 
            // EndTime
            // 
            this.EndTime.Text = "EndTime";
            this.EndTime.Width = 150;
            // 
            // Column_StreamServer
            // 
            this.Column_StreamServer.Text = "Server";
            this.Column_StreamServer.Width = 97;
            // 
            // pictureBox_VideoWindow
            // 
            this.pictureBox_VideoWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_VideoWindow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_VideoWindow.Location = new System.Drawing.Point(412, 147);
            this.pictureBox_VideoWindow.Name = "pictureBox_VideoWindow";
            this.pictureBox_VideoWindow.Size = new System.Drawing.Size(583, 470);
            this.pictureBox_VideoWindow.TabIndex = 1;
            this.pictureBox_VideoWindow.TabStop = false;
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(834, 1);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(91, 28);
            this.Button_Search.TabIndex = 7;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // dateTimePicker_EndTime
            // 
            this.dateTimePicker_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_EndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_EndTime.Location = new System.Drawing.Point(590, 9);
            this.dateTimePicker_EndTime.Name = "dateTimePicker_EndTime";
            this.dateTimePicker_EndTime.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker_EndTime.TabIndex = 2;
            // 
            // dateTimePicker_StartTime
            // 
            this.dateTimePicker_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_StartTime.Location = new System.Drawing.Point(349, 9);
            this.dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            this.dateTimePicker_StartTime.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker_StartTime.TabIndex = 1;
            // 
            // label_EndTime
            // 
            this.label_EndTime.AutoSize = true;
            this.label_EndTime.Location = new System.Drawing.Point(527, 11);
            this.label_EndTime.Name = "label_EndTime";
            this.label_EndTime.Size = new System.Drawing.Size(52, 13);
            this.label_EndTime.TabIndex = 5;
            this.label_EndTime.Text = "EndTime:";
            // 
            // label_StartTime
            // 
            this.label_StartTime.AutoSize = true;
            this.label_StartTime.Location = new System.Drawing.Point(278, 11);
            this.label_StartTime.Name = "label_StartTime";
            this.label_StartTime.Size = new System.Drawing.Size(55, 13);
            this.label_StartTime.TabIndex = 6;
            this.label_StartTime.Text = "StartTime:";
            // 
            // button_Download
            // 
            this.button_Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Download.Location = new System.Drawing.Point(814, 627);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(63, 30);
            this.button_Download.TabIndex = 11;
            this.button_Download.Text = "Download";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // button_StopPlay
            // 
            this.button_StopPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_StopPlay.Location = new System.Drawing.Point(81, 623);
            this.button_StopPlay.Name = "button_StopPlay";
            this.button_StopPlay.Size = new System.Drawing.Size(61, 30);
            this.button_StopPlay.TabIndex = 10;
            this.button_StopPlay.Text = "StopPlay";
            this.button_StopPlay.UseVisualStyleBackColor = true;
            this.button_StopPlay.Click += new System.EventHandler(this.button_StopPlay_Click);
            // 
            // button_StartPlay
            // 
            this.button_StartPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_StartPlay.Location = new System.Drawing.Point(12, 623);
            this.button_StartPlay.Name = "button_StartPlay";
            this.button_StartPlay.Size = new System.Drawing.Size(63, 30);
            this.button_StartPlay.TabIndex = 9;
            this.button_StartPlay.Text = "StartPlay";
            this.button_StartPlay.UseVisualStyleBackColor = true;
            this.button_StartPlay.Click += new System.EventHandler(this.button_StartPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sever:";
            // 
            // comboBox_Sever
            // 
            this.comboBox_Sever.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sever.FormattingEnabled = true;
            this.comboBox_Sever.Location = new System.Drawing.Point(58, 8);
            this.comboBox_Sever.Name = "comboBox_Sever";
            this.comboBox_Sever.Size = new System.Drawing.Size(210, 21);
            this.comboBox_Sever.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Min(m):";
            // 
            // textBox_DurationMin
            // 
            this.textBox_DurationMin.Location = new System.Drawing.Point(122, 43);
            this.textBox_DurationMin.Name = "textBox_DurationMin";
            this.textBox_DurationMin.Size = new System.Drawing.Size(46, 20);
            this.textBox_DurationMin.TabIndex = 4;
            this.textBox_DurationMin.Text = "0";
            // 
            // textBox_DurationMax
            // 
            this.textBox_DurationMax.Location = new System.Drawing.Point(218, 43);
            this.textBox_DurationMax.Name = "textBox_DurationMax";
            this.textBox_DurationMax.Size = new System.Drawing.Size(48, 20);
            this.textBox_DurationMax.TabIndex = 5;
            this.textBox_DurationMax.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Max(m):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "TriggerType:";
            // 
            // comboBox_TriggerType
            // 
            this.comboBox_TriggerType.FormattingEnabled = true;
            this.comboBox_TriggerType.Items.AddRange(new object[] {
            "All",
            "Manual",
            "Alarm",
            "Schedule"});
            this.comboBox_TriggerType.Location = new System.Drawing.Point(523, 74);
            this.comboBox_TriggerType.Name = "comboBox_TriggerType";
            this.comboBox_TriggerType.Size = new System.Drawing.Size(143, 21);
            this.comboBox_TriggerType.TabIndex = 6;
            this.comboBox_TriggerType.SelectedIndexChanged += new System.EventHandler(this.comboBox_TriggerType_SelectedIndexChanged);
            // 
            // checkBox_Duration
            // 
            this.checkBox_Duration.AutoSize = true;
            this.checkBox_Duration.Location = new System.Drawing.Point(15, 43);
            this.checkBox_Duration.Name = "checkBox_Duration";
            this.checkBox_Duration.Size = new System.Drawing.Size(66, 17);
            this.checkBox_Duration.TabIndex = 22;
            this.checkBox_Duration.Text = "Duration";
            this.checkBox_Duration.UseVisualStyleBackColor = true;
            this.checkBox_Duration.CheckedChanged += new System.EventHandler(this.checkBox_Duration_CheckedChanged);
            // 
            // textBox_Location
            // 
            this.textBox_Location.Location = new System.Drawing.Point(473, 14);
            this.textBox_Location.Name = "textBox_Location";
            this.textBox_Location.Size = new System.Drawing.Size(242, 20);
            this.textBox_Location.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Operator/Rule:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Description:";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(76, 75);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(190, 20);
            this.textBox_Description.TabIndex = 28;
            // 
            // textBox_MaxLines
            // 
            this.textBox_MaxLines.Location = new System.Drawing.Point(330, 75);
            this.textBox_MaxLines.Name = "textBox_MaxLines";
            this.textBox_MaxLines.Size = new System.Drawing.Size(60, 20);
            this.textBox_MaxLines.TabIndex = 29;
            this.textBox_MaxLines.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "MaxLines:";
            // 
            // textBox_Rule
            // 
            this.textBox_Rule.Location = new System.Drawing.Point(756, 79);
            this.textBox_Rule.Name = "textBox_Rule";
            this.textBox_Rule.Size = new System.Drawing.Size(233, 20);
            this.textBox_Rule.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "DeviceType:";
            // 
            // comboBox_DeviceType
            // 
            this.comboBox_DeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DeviceType.FormattingEnabled = true;
            this.comboBox_DeviceType.Location = new System.Drawing.Point(84, 112);
            this.comboBox_DeviceType.Name = "comboBox_DeviceType";
            this.comboBox_DeviceType.Size = new System.Drawing.Size(182, 21);
            this.comboBox_DeviceType.Sorted = true;
            this.comboBox_DeviceType.TabIndex = 34;
            this.comboBox_DeviceType.SelectedIndexChanged += new System.EventHandler(this.comboBox_DeviceType_SelectedIndexChanged);
            // 
            // radioButton_ItemID
            // 
            this.radioButton_ItemID.AutoSize = true;
            this.radioButton_ItemID.Checked = true;
            this.radioButton_ItemID.Location = new System.Drawing.Point(7, 15);
            this.radioButton_ItemID.Name = "radioButton_ItemID";
            this.radioButton_ItemID.Size = new System.Drawing.Size(56, 17);
            this.radioButton_ItemID.TabIndex = 35;
            this.radioButton_ItemID.TabStop = true;
            this.radioButton_ItemID.Text = "ItemID";
            this.radioButton_ItemID.UseVisualStyleBackColor = true;
            this.radioButton_ItemID.CheckedChanged += new System.EventHandler(this.radioButton_ItemID_CheckedChanged);
            // 
            // radioButton_ItemLoaction
            // 
            this.radioButton_ItemLoaction.AutoSize = true;
            this.radioButton_ItemLoaction.Location = new System.Drawing.Point(400, 15);
            this.radioButton_ItemLoaction.Name = "radioButton_ItemLoaction";
            this.radioButton_ItemLoaction.Size = new System.Drawing.Size(66, 17);
            this.radioButton_ItemLoaction.TabIndex = 35;
            this.radioButton_ItemLoaction.TabStop = true;
            this.radioButton_ItemLoaction.Text = "Location";
            this.radioButton_ItemLoaction.UseVisualStyleBackColor = true;
            // 
            // textBox_ItemLocation
            // 
            this.textBox_ItemLocation.Location = new System.Drawing.Point(472, 14);
            this.textBox_ItemLocation.Name = "textBox_ItemLocation";
            this.textBox_ItemLocation.Size = new System.Drawing.Size(243, 20);
            this.textBox_ItemLocation.TabIndex = 36;
            // 
            // comboBox_ItemID
            // 
            this.comboBox_ItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ItemID.FormattingEnabled = true;
            this.comboBox_ItemID.Location = new System.Drawing.Point(70, 13);
            this.comboBox_ItemID.Name = "comboBox_ItemID";
            this.comboBox_ItemID.Size = new System.Drawing.Size(325, 21);
            this.comboBox_ItemID.TabIndex = 37;
            // 
            // comboBox_Camera
            // 
            this.comboBox_Camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Camera.FormattingEnabled = true;
            this.comboBox_Camera.Location = new System.Drawing.Point(70, 14);
            this.comboBox_Camera.Name = "comboBox_Camera";
            this.comboBox_Camera.Size = new System.Drawing.Size(325, 21);
            this.comboBox_Camera.TabIndex = 3;
            // 
            // radioButton_Camera
            // 
            this.radioButton_Camera.AutoSize = true;
            this.radioButton_Camera.Checked = true;
            this.radioButton_Camera.Location = new System.Drawing.Point(6, 16);
            this.radioButton_Camera.Name = "radioButton_Camera";
            this.radioButton_Camera.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Camera.TabIndex = 23;
            this.radioButton_Camera.TabStop = true;
            this.radioButton_Camera.Text = "Camera";
            this.radioButton_Camera.UseVisualStyleBackColor = true;
            this.radioButton_Camera.CheckedChanged += new System.EventHandler(this.radioButton_Camera_CheckedChanged);
            // 
            // radioButton_Location
            // 
            this.radioButton_Location.AutoSize = true;
            this.radioButton_Location.Location = new System.Drawing.Point(401, 16);
            this.radioButton_Location.Name = "radioButton_Location";
            this.radioButton_Location.Size = new System.Drawing.Size(66, 17);
            this.radioButton_Location.TabIndex = 23;
            this.radioButton_Location.TabStop = true;
            this.radioButton_Location.Text = "Location";
            this.radioButton_Location.UseVisualStyleBackColor = true;
            // 
            // groupBox_Item
            // 
            this.groupBox_Item.Controls.Add(this.radioButton_ItemID);
            this.groupBox_Item.Controls.Add(this.comboBox_ItemID);
            this.groupBox_Item.Controls.Add(this.radioButton_ItemLoaction);
            this.groupBox_Item.Controls.Add(this.textBox_ItemLocation);
            this.groupBox_Item.Location = new System.Drawing.Point(274, 98);
            this.groupBox_Item.Name = "groupBox_Item";
            this.groupBox_Item.Size = new System.Drawing.Size(721, 41);
            this.groupBox_Item.TabIndex = 38;
            this.groupBox_Item.TabStop = false;
            // 
            // groupBox_Device
            // 
            this.groupBox_Device.Controls.Add(this.radioButton_Camera);
            this.groupBox_Device.Controls.Add(this.comboBox_Camera);
            this.groupBox_Device.Controls.Add(this.radioButton_Location);
            this.groupBox_Device.Controls.Add(this.textBox_Location);
            this.groupBox_Device.Location = new System.Drawing.Point(274, 28);
            this.groupBox_Device.Name = "groupBox_Device";
            this.groupBox_Device.Size = new System.Drawing.Size(721, 41);
            this.groupBox_Device.TabIndex = 39;
            this.groupBox_Device.TabStop = false;
            // 
            // dateTimePicker_DownloadEnd
            // 
            this.dateTimePicker_DownloadEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_DownloadEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_DownloadEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DownloadEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_DownloadEnd.Location = new System.Drawing.Point(511, 631);
            this.dateTimePicker_DownloadEnd.Name = "dateTimePicker_DownloadEnd";
            this.dateTimePicker_DownloadEnd.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker_DownloadEnd.TabIndex = 41;
            // 
            // dateTimePicker_DownloadStart
            // 
            this.dateTimePicker_DownloadStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_DownloadStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_DownloadStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DownloadStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_DownloadStart.Location = new System.Drawing.Point(265, 630);
            this.dateTimePicker_DownloadStart.Name = "dateTimePicker_DownloadStart";
            this.dateTimePicker_DownloadStart.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker_DownloadStart.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 634);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "DownloadEndTime:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 632);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "DownloadStartTime:";
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSnapshot.Location = new System.Drawing.Point(883, 627);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(61, 30);
            this.btnSnapshot.TabIndex = 44;
            this.btnSnapshot.Text = "Snapshot";
            this.btnSnapshot.UseVisualStyleBackColor = true;
            this.btnSnapshot.Click += new System.EventHandler(this.btnSnapshot_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(950, 627);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 30);
            this.btnPause.TabIndex = 45;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblFrameTime
            // 
            this.lblFrameTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrameTime.AutoSize = true;
            this.lblFrameTime.Location = new System.Drawing.Point(683, 634);
            this.lblFrameTime.Name = "lblFrameTime";
            this.lblFrameTime.Size = new System.Drawing.Size(0, 13);
            this.lblFrameTime.TabIndex = 46;
            // 
            // Form_NVRVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.lblFrameTime);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnSnapshot);
            this.Controls.Add(this.dateTimePicker_DownloadEnd);
            this.Controls.Add(this.dateTimePicker_DownloadStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox_Device);
            this.Controls.Add(this.groupBox_Item);
            this.Controls.Add(this.comboBox_DeviceType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Rule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_MaxLines);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_Duration);
            this.Controls.Add(this.comboBox_TriggerType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_DurationMax);
            this.Controls.Add(this.textBox_DurationMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Sever);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_StartPlay);
            this.Controls.Add(this.button_StopPlay);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.dateTimePicker_EndTime);
            this.Controls.Add(this.dateTimePicker_StartTime);
            this.Controls.Add(this.label_EndTime);
            this.Controls.Add(this.label_StartTime);
            this.Controls.Add(this.pictureBox_VideoWindow);
            this.Controls.Add(this.listView_NVRVideo);
            this.Name = "Form_NVRVideo";
            this.Text = "NVRVideo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_NVRVideo_FormClosed);
            this.Load += new System.EventHandler(this.Form_NVRVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).EndInit();
            this.groupBox_Item.ResumeLayout(false);
            this.groupBox_Item.PerformLayout();
            this.groupBox_Device.ResumeLayout(false);
            this.groupBox_Device.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_NVRVideo;
        private System.Windows.Forms.PictureBox pictureBox_VideoWindow;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartTime;
        private System.Windows.Forms.Label label_EndTime;
        private System.Windows.Forms.Label label_StartTime;
        private System.Windows.Forms.ColumnHeader VideoName;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Button button_StopPlay;
        private System.Windows.Forms.Button button_StartPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Sever;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DurationMin;
        private System.Windows.Forms.TextBox textBox_DurationMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_TriggerType;
        private System.Windows.Forms.ColumnHeader Column_StreamServer;
        private System.Windows.Forms.CheckBox checkBox_Duration;
        private System.Windows.Forms.TextBox textBox_Location;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_MaxLines;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Rule;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_DeviceType;
        private System.Windows.Forms.RadioButton radioButton_ItemID;
        private System.Windows.Forms.RadioButton radioButton_ItemLoaction;
        private System.Windows.Forms.TextBox textBox_ItemLocation;
        private System.Windows.Forms.ComboBox comboBox_ItemID;
        private System.Windows.Forms.ComboBox comboBox_Camera;
        private System.Windows.Forms.RadioButton radioButton_Camera;
        private System.Windows.Forms.RadioButton radioButton_Location;
        private System.Windows.Forms.GroupBox groupBox_Item;
        private System.Windows.Forms.GroupBox groupBox_Device;
        private System.Windows.Forms.ColumnHeader columnHeader_Index;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DownloadEnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DownloadStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSnapshot;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblFrameTime;
    }
}