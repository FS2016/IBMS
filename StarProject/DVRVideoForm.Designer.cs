namespace HUSSDKDemo
{
    partial class Form_DVRVideo
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
            this.listView_DVRVideo = new System.Windows.Forms.ListView();
            this.columnHeader_Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VideoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox_VideoWindow = new System.Windows.Forms.PictureBox();
            this.label_DownloadProcess = new System.Windows.Forms.Label();
            this.button_Download = new System.Windows.Forms.Button();
            this.Button_Search = new System.Windows.Forms.Button();
            this.dateTimePicker_EndTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_StartTime = new System.Windows.Forms.DateTimePicker();
            this.label_EndTime = new System.Windows.Forms.Label();
            this.label_StartTime = new System.Windows.Forms.Label();
            this.button_StartPlay = new System.Windows.Forms.Button();
            this.button_StopPlay = new System.Windows.Forms.Button();
            this.comboBox_DeviceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Device = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Channel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_RecordType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_DownloadStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DownloadEnd = new System.Windows.Forms.DateTimePicker();
            this.lblFrameTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_DVRVideo
            // 
            this.listView_DVRVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_DVRVideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Index,
            this.VideoName,
            this.StartTime,
            this.EndTime});
            this.listView_DVRVideo.FullRowSelect = true;
            this.listView_DVRVideo.HideSelection = false;
            this.listView_DVRVideo.Location = new System.Drawing.Point(12, 74);
            this.listView_DVRVideo.MultiSelect = false;
            this.listView_DVRVideo.Name = "listView_DVRVideo";
            this.listView_DVRVideo.Size = new System.Drawing.Size(368, 542);
            this.listView_DVRVideo.TabIndex = 12;
            this.listView_DVRVideo.UseCompatibleStateImageBehavior = false;
            this.listView_DVRVideo.View = System.Windows.Forms.View.Details;
            this.listView_DVRVideo.SelectedIndexChanged += new System.EventHandler(this.listView_DVRVideo_SelectedIndexChanged);
            // 
            // columnHeader_Index
            // 
            this.columnHeader_Index.Text = "Index";
            // 
            // VideoName
            // 
            this.VideoName.Text = "Name";
            this.VideoName.Width = 190;
            // 
            // StartTime
            // 
            this.StartTime.Text = "StartTime";
            this.StartTime.Width = 126;
            // 
            // EndTime
            // 
            this.EndTime.Text = "EndTime";
            this.EndTime.Width = 117;
            // 
            // pictureBox_VideoWindow
            // 
            this.pictureBox_VideoWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_VideoWindow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_VideoWindow.Location = new System.Drawing.Point(388, 74);
            this.pictureBox_VideoWindow.Name = "pictureBox_VideoWindow";
            this.pictureBox_VideoWindow.Size = new System.Drawing.Size(608, 542);
            this.pictureBox_VideoWindow.TabIndex = 1;
            this.pictureBox_VideoWindow.TabStop = false;
            // 
            // label_DownloadProcess
            // 
            this.label_DownloadProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_DownloadProcess.AutoSize = true;
            this.label_DownloadProcess.Location = new System.Drawing.Point(859, 633);
            this.label_DownloadProcess.Name = "label_DownloadProcess";
            this.label_DownloadProcess.Size = new System.Drawing.Size(0, 13);
            this.label_DownloadProcess.TabIndex = 18;
            // 
            // button_Download
            // 
            this.button_Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Download.Location = new System.Drawing.Point(804, 624);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(79, 30);
            this.button_Download.TabIndex = 10;
            this.button_Download.Text = "Download";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(754, 32);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(66, 30);
            this.Button_Search.TabIndex = 6;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // dateTimePicker_EndTime
            // 
            this.dateTimePicker_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_EndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_EndTime.Location = new System.Drawing.Point(597, 39);
            this.dateTimePicker_EndTime.Name = "dateTimePicker_EndTime";
            this.dateTimePicker_EndTime.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker_EndTime.TabIndex = 5;
            // 
            // dateTimePicker_StartTime
            // 
            this.dateTimePicker_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_StartTime.Location = new System.Drawing.Point(391, 39);
            this.dateTimePicker_StartTime.Name = "dateTimePicker_StartTime";
            this.dateTimePicker_StartTime.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker_StartTime.TabIndex = 4;
            // 
            // label_EndTime
            // 
            this.label_EndTime.AutoSize = true;
            this.label_EndTime.Location = new System.Drawing.Point(539, 41);
            this.label_EndTime.Name = "label_EndTime";
            this.label_EndTime.Size = new System.Drawing.Size(52, 13);
            this.label_EndTime.TabIndex = 12;
            this.label_EndTime.Text = "EndTime:";
            // 
            // label_StartTime
            // 
            this.label_StartTime.AutoSize = true;
            this.label_StartTime.Location = new System.Drawing.Point(320, 41);
            this.label_StartTime.Name = "label_StartTime";
            this.label_StartTime.Size = new System.Drawing.Size(55, 13);
            this.label_StartTime.TabIndex = 13;
            this.label_StartTime.Text = "StartTime:";
            // 
            // button_StartPlay
            // 
            this.button_StartPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_StartPlay.Location = new System.Drawing.Point(12, 624);
            this.button_StartPlay.Name = "button_StartPlay";
            this.button_StartPlay.Size = new System.Drawing.Size(105, 30);
            this.button_StartPlay.TabIndex = 8;
            this.button_StartPlay.Text = "StartPlay";
            this.button_StartPlay.UseVisualStyleBackColor = true;
            this.button_StartPlay.Click += new System.EventHandler(this.button_StartPlay_Click);
            // 
            // button_StopPlay
            // 
            this.button_StopPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_StopPlay.Location = new System.Drawing.Point(123, 624);
            this.button_StopPlay.Name = "button_StopPlay";
            this.button_StopPlay.Size = new System.Drawing.Size(105, 30);
            this.button_StopPlay.TabIndex = 9;
            this.button_StopPlay.Text = "StopPlay";
            this.button_StopPlay.UseVisualStyleBackColor = true;
            this.button_StopPlay.Click += new System.EventHandler(this.button_StopPlay_Click);
            // 
            // comboBox_DeviceType
            // 
            this.comboBox_DeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DeviceType.FormattingEnabled = true;
            this.comboBox_DeviceType.Location = new System.Drawing.Point(83, 6);
            this.comboBox_DeviceType.Name = "comboBox_DeviceType";
            this.comboBox_DeviceType.Size = new System.Drawing.Size(215, 21);
            this.comboBox_DeviceType.TabIndex = 0;
            this.comboBox_DeviceType.SelectedIndexChanged += new System.EventHandler(this.comboBox_DeviceType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "DeviceType:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Device:";
            // 
            // comboBox_Device
            // 
            this.comboBox_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Device.FormattingEnabled = true;
            this.comboBox_Device.Location = new System.Drawing.Point(375, 6);
            this.comboBox_Device.Name = "comboBox_Device";
            this.comboBox_Device.Size = new System.Drawing.Size(241, 21);
            this.comboBox_Device.TabIndex = 1;
            this.comboBox_Device.SelectedIndexChanged += new System.EventHandler(this.comboBox_Device_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Channel:";
            // 
            // comboBox_Channel
            // 
            this.comboBox_Channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Channel.FormattingEnabled = true;
            this.comboBox_Channel.Location = new System.Drawing.Point(677, 6);
            this.comboBox_Channel.Name = "comboBox_Channel";
            this.comboBox_Channel.Size = new System.Drawing.Size(319, 21);
            this.comboBox_Channel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "RecordType:";
            // 
            // comboBox_RecordType
            // 
            this.comboBox_RecordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RecordType.FormattingEnabled = true;
            this.comboBox_RecordType.Location = new System.Drawing.Point(84, 38);
            this.comboBox_RecordType.Name = "comboBox_RecordType";
            this.comboBox_RecordType.Size = new System.Drawing.Size(214, 21);
            this.comboBox_RecordType.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "DownloadStartTime:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 633);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DownloadEndTime:";
            // 
            // dateTimePicker_DownloadStart
            // 
            this.dateTimePicker_DownloadStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_DownloadStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_DownloadStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DownloadStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_DownloadStart.Location = new System.Drawing.Point(404, 631);
            this.dateTimePicker_DownloadStart.Name = "dateTimePicker_DownloadStart";
            this.dateTimePicker_DownloadStart.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker_DownloadStart.TabIndex = 4;
            // 
            // dateTimePicker_DownloadEnd
            // 
            this.dateTimePicker_DownloadEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_DownloadEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_DownloadEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DownloadEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_DownloadEnd.Location = new System.Drawing.Point(661, 631);
            this.dateTimePicker_DownloadEnd.Name = "dateTimePicker_DownloadEnd";
            this.dateTimePicker_DownloadEnd.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker_DownloadEnd.TabIndex = 5;
            // 
            // lblFrameTime
            // 
            this.lblFrameTime.AutoSize = true;
            this.lblFrameTime.Location = new System.Drawing.Point(889, 633);
            this.lblFrameTime.Name = "lblFrameTime";
            this.lblFrameTime.Size = new System.Drawing.Size(0, 13);
            this.lblFrameTime.TabIndex = 28;
            // 
            // Form_DVRVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 663);
            this.Controls.Add(this.lblFrameTime);
            this.Controls.Add(this.comboBox_RecordType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Channel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Device);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_DeviceType);
            this.Controls.Add(this.button_StopPlay);
            this.Controls.Add(this.button_StartPlay);
            this.Controls.Add(this.label_DownloadProcess);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.dateTimePicker_DownloadEnd);
            this.Controls.Add(this.dateTimePicker_EndTime);
            this.Controls.Add(this.dateTimePicker_DownloadStart);
            this.Controls.Add(this.dateTimePicker_StartTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_EndTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_StartTime);
            this.Controls.Add(this.pictureBox_VideoWindow);
            this.Controls.Add(this.listView_DVRVideo);
            this.Name = "Form_DVRVideo";
            this.Text = "DVRVideo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_DVRVideo_FormClosed);
            this.Load += new System.EventHandler(this.Form_DVRVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_DVRVideo;
        private System.Windows.Forms.PictureBox pictureBox_VideoWindow;
        private System.Windows.Forms.Label label_DownloadProcess;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartTime;
        private System.Windows.Forms.Label label_EndTime;
        private System.Windows.Forms.Label label_StartTime;
        private System.Windows.Forms.Button button_StartPlay;
        private System.Windows.Forms.Button button_StopPlay;
        private System.Windows.Forms.ColumnHeader VideoName;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.ComboBox comboBox_DeviceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Device;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Channel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_RecordType;
        private System.Windows.Forms.ColumnHeader columnHeader_Index;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DownloadStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DownloadEnd;
        private System.Windows.Forms.Label lblFrameTime;
    }
}