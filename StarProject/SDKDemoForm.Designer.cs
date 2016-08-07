namespace HUSSDKDemo
{
    partial class Form_SDKDemo
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
            this.label_HUSSite = new System.Windows.Forms.Label();
            this.textBox_HUSSite = new System.Windows.Forms.TextBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.button_LogOut = new System.Windows.Forms.Button();
            this.button_QueryLog = new System.Windows.Forms.Button();
            this.button_NVRVideo = new System.Windows.Forms.Button();
            this.button_DVRVideo = new System.Windows.Forms.Button();
            this.button_LiveView = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Event = new System.Windows.Forms.Label();
            this.button_LocalVideo = new System.Windows.Forms.Button();
            this.button_HandleAlarm = new System.Windows.Forms.Button();
            this.listView_Status = new System.Windows.Forms.ListView();
            this.column_Device1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Type1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Level1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Time1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Detail1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ECServerName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Event = new System.Windows.Forms.ListView();
            this.column_Device3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Type3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Level3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Time3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Detail3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ECServerName3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox_Download = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Download)).BeginInit();
            this.SuspendLayout();
            // 
            // label_HUSSite
            // 
            this.label_HUSSite.AutoSize = true;
            this.label_HUSSite.Location = new System.Drawing.Point(37, 28);
            this.label_HUSSite.Name = "label_HUSSite";
            this.label_HUSSite.Size = new System.Drawing.Size(51, 13);
            this.label_HUSSite.TabIndex = 0;
            this.label_HUSSite.Text = "HUSSite:";
            // 
            // textBox_HUSSite
            // 
            this.textBox_HUSSite.Location = new System.Drawing.Point(112, 25);
            this.textBox_HUSSite.Name = "textBox_HUSSite";
            this.textBox_HUSSite.Size = new System.Drawing.Size(103, 20);
            this.textBox_HUSSite.TabIndex = 0;
            this.textBox_HUSSite.Text = "10.15.16.2";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(37, 72);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(60, 13);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "UserName:";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(112, 69);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(103, 20);
            this.textBox_UserName.TabIndex = 1;
            this.textBox_UserName.Text = "admin";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(37, 115);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(56, 13);
            this.label_Password.TabIndex = 0;
            this.label_Password.Text = "Password:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(112, 112);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(103, 20);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.Text = "123456";
            // 
            // button_LogIn
            // 
            this.button_LogIn.Location = new System.Drawing.Point(250, 41);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(101, 27);
            this.button_LogIn.TabIndex = 3;
            this.button_LogIn.Text = "LogIn";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // button_LogOut
            // 
            this.button_LogOut.Enabled = false;
            this.button_LogOut.Location = new System.Drawing.Point(250, 83);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(101, 27);
            this.button_LogOut.TabIndex = 4;
            this.button_LogOut.Text = "LogOut";
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // button_QueryLog
            // 
            this.button_QueryLog.Enabled = false;
            this.button_QueryLog.Location = new System.Drawing.Point(156, 208);
            this.button_QueryLog.Name = "button_QueryLog";
            this.button_QueryLog.Size = new System.Drawing.Size(101, 27);
            this.button_QueryLog.TabIndex = 6;
            this.button_QueryLog.Text = "Query Log";
            this.button_QueryLog.UseVisualStyleBackColor = true;
            this.button_QueryLog.Click += new System.EventHandler(this.button_QueryLog_Click);
            // 
            // button_NVRVideo
            // 
            this.button_NVRVideo.Enabled = false;
            this.button_NVRVideo.Location = new System.Drawing.Point(156, 166);
            this.button_NVRVideo.Name = "button_NVRVideo";
            this.button_NVRVideo.Size = new System.Drawing.Size(101, 27);
            this.button_NVRVideo.TabIndex = 7;
            this.button_NVRVideo.Text = "NVR Video";
            this.button_NVRVideo.UseVisualStyleBackColor = true;
            this.button_NVRVideo.Click += new System.EventHandler(this.button_NVRVideo_Click);
            // 
            // button_DVRVideo
            // 
            this.button_DVRVideo.Enabled = false;
            this.button_DVRVideo.Location = new System.Drawing.Point(264, 166);
            this.button_DVRVideo.Name = "button_DVRVideo";
            this.button_DVRVideo.Size = new System.Drawing.Size(101, 27);
            this.button_DVRVideo.TabIndex = 8;
            this.button_DVRVideo.Text = "DVR Video";
            this.button_DVRVideo.UseVisualStyleBackColor = true;
            this.button_DVRVideo.Click += new System.EventHandler(this.button_DVRVideo_Click);
            // 
            // button_LiveView
            // 
            this.button_LiveView.Enabled = false;
            this.button_LiveView.Location = new System.Drawing.Point(49, 166);
            this.button_LiveView.Name = "button_LiveView";
            this.button_LiveView.Size = new System.Drawing.Size(101, 27);
            this.button_LiveView.TabIndex = 5;
            this.button_LiveView.Text = "LiveView";
            this.button_LiveView.UseVisualStyleBackColor = true;
            this.button_LiveView.Click += new System.EventHandler(this.button_LiveView_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(400, 8);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(40, 13);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Status:";
            // 
            // label_Event
            // 
            this.label_Event.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Event.AutoSize = true;
            this.label_Event.Location = new System.Drawing.Point(402, 349);
            this.label_Event.Name = "label_Event";
            this.label_Event.Size = new System.Drawing.Size(38, 13);
            this.label_Event.TabIndex = 0;
            this.label_Event.Text = "Event:";
            // 
            // button_LocalVideo
            // 
            this.button_LocalVideo.Enabled = false;
            this.button_LocalVideo.Location = new System.Drawing.Point(49, 208);
            this.button_LocalVideo.Name = "button_LocalVideo";
            this.button_LocalVideo.Size = new System.Drawing.Size(101, 27);
            this.button_LocalVideo.TabIndex = 9;
            this.button_LocalVideo.Text = "Local Video";
            this.button_LocalVideo.UseVisualStyleBackColor = true;
            this.button_LocalVideo.Click += new System.EventHandler(this.button_LocalVideo_Click);
            // 
            // button_HandleAlarm
            // 
            this.button_HandleAlarm.Enabled = false;
            this.button_HandleAlarm.Location = new System.Drawing.Point(264, 208);
            this.button_HandleAlarm.Name = "button_HandleAlarm";
            this.button_HandleAlarm.Size = new System.Drawing.Size(101, 27);
            this.button_HandleAlarm.TabIndex = 10;
            this.button_HandleAlarm.Text = "Alarm";
            this.button_HandleAlarm.UseVisualStyleBackColor = true;
            this.button_HandleAlarm.Click += new System.EventHandler(this.button_HandleAlarm_Click);
            // 
            // listView_Status
            // 
            this.listView_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Status.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Device1,
            this.column_Type1,
            this.column_Level1,
            this.column_Time1,
            this.column_Detail1,
            this.column_ECServerName1});
            this.listView_Status.FullRowSelect = true;
            this.listView_Status.Location = new System.Drawing.Point(403, 28);
            this.listView_Status.MultiSelect = false;
            this.listView_Status.Name = "listView_Status";
            this.listView_Status.Size = new System.Drawing.Size(592, 307);
            this.listView_Status.TabIndex = 11;
            this.listView_Status.UseCompatibleStateImageBehavior = false;
            this.listView_Status.View = System.Windows.Forms.View.Details;
            // 
            // column_Device1
            // 
            this.column_Device1.Text = "Device";
            this.column_Device1.Width = 131;
            // 
            // column_Type1
            // 
            this.column_Type1.Text = "Type";
            this.column_Type1.Width = 112;
            // 
            // column_Level1
            // 
            this.column_Level1.Text = "Level";
            this.column_Level1.Width = 41;
            // 
            // column_Time1
            // 
            this.column_Time1.Text = "Time";
            this.column_Time1.Width = 116;
            // 
            // column_Detail1
            // 
            this.column_Detail1.Text = "Detail";
            this.column_Detail1.Width = 92;
            // 
            // column_ECServerName1
            // 
            this.column_ECServerName1.Text = "ECServerName";
            this.column_ECServerName1.Width = 101;
            // 
            // listView_Event
            // 
            this.listView_Event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Event.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Device3,
            this.column_Type3,
            this.column_Level3,
            this.column_Time3,
            this.column_Detail3,
            this.column_ECServerName3});
            this.listView_Event.FullRowSelect = true;
            this.listView_Event.Location = new System.Drawing.Point(403, 371);
            this.listView_Event.MultiSelect = false;
            this.listView_Event.Name = "listView_Event";
            this.listView_Event.Size = new System.Drawing.Size(592, 276);
            this.listView_Event.TabIndex = 12;
            this.listView_Event.UseCompatibleStateImageBehavior = false;
            this.listView_Event.View = System.Windows.Forms.View.Details;
            // 
            // column_Device3
            // 
            this.column_Device3.Text = "Device";
            this.column_Device3.Width = 128;
            // 
            // column_Type3
            // 
            this.column_Type3.Text = "Type";
            this.column_Type3.Width = 115;
            // 
            // column_Level3
            // 
            this.column_Level3.Text = "Level";
            this.column_Level3.Width = 41;
            // 
            // column_Time3
            // 
            this.column_Time3.Text = "Time";
            this.column_Time3.Width = 129;
            // 
            // column_Detail3
            // 
            this.column_Detail3.Text = "Detail";
            this.column_Detail3.Width = 85;
            // 
            // column_ECServerName3
            // 
            this.column_ECServerName3.Text = "ECServerName";
            this.column_ECServerName3.Width = 95;
            // 
            // pictureBox_Download
            // 
            this.pictureBox_Download.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_Download.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox_Download.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Download.Location = new System.Drawing.Point(12, 289);
            this.pictureBox_Download.Name = "pictureBox_Download";
            this.pictureBox_Download.Size = new System.Drawing.Size(385, 358);
            this.pictureBox_Download.TabIndex = 13;
            this.pictureBox_Download.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DownloadManager:";
            // 
            // Form_SDKDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.pictureBox_Download);
            this.Controls.Add(this.listView_Event);
            this.Controls.Add(this.listView_Status);
            this.Controls.Add(this.button_HandleAlarm);
            this.Controls.Add(this.button_LocalVideo);
            this.Controls.Add(this.button_LiveView);
            this.Controls.Add(this.button_DVRVideo);
            this.Controls.Add(this.button_NVRVideo);
            this.Controls.Add(this.button_QueryLog);
            this.Controls.Add(this.button_LogOut);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.textBox_HUSSite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Event);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_HUSSite);
            this.Name = "Form_SDKDemo";
            this.Text = "SDKDemo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SDKDemo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Download)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_HUSSite;
        private System.Windows.Forms.TextBox textBox_HUSSite;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Button button_LogOut;
        private System.Windows.Forms.Button button_QueryLog;
        private System.Windows.Forms.Button button_NVRVideo;
        private System.Windows.Forms.Button button_DVRVideo;
        private System.Windows.Forms.Button button_LiveView;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Event;
        private System.Windows.Forms.Button button_LocalVideo;
        private System.Windows.Forms.Button button_HandleAlarm;
        private System.Windows.Forms.ListView listView_Status;
        private System.Windows.Forms.ColumnHeader column_Device1;
        private System.Windows.Forms.ColumnHeader column_Type1;
        private System.Windows.Forms.ColumnHeader column_Level1;
        private System.Windows.Forms.ColumnHeader column_Time1;
        private System.Windows.Forms.ColumnHeader column_Detail1;
        private System.Windows.Forms.ColumnHeader column_ECServerName1;
        private System.Windows.Forms.ListView listView_Event;
        private System.Windows.Forms.ColumnHeader column_Device3;
        private System.Windows.Forms.ColumnHeader column_Type3;
        private System.Windows.Forms.ColumnHeader column_Level3;
        private System.Windows.Forms.ColumnHeader column_Time3;
        private System.Windows.Forms.ColumnHeader column_Detail3;
        private System.Windows.Forms.ColumnHeader column_ECServerName3;
        private System.Windows.Forms.PictureBox pictureBox_Download;
        private System.Windows.Forms.Label label1;
    }
}

