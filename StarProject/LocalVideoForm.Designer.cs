namespace HUSSDKDemo
{
    partial class Form_LocalVideo
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
            this.button_Search = new System.Windows.Forms.Button();
            this.label_Path = new System.Windows.Forms.Label();
            this.pictureBox_VideoWindow = new System.Windows.Forms.PictureBox();
            this.listView_LocalVideo = new System.Windows.Forms.ListView();
            this.VideoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_StartPlay = new System.Windows.Forms.Button();
            this.button_StopPlay = new System.Windows.Forms.Button();
            this.label_LocalVideo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(12, 10);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(95, 29);
            this.button_Search.TabIndex = 0;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Location = new System.Drawing.Point(125, 18);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(25, 13);
            this.label_Path.TabIndex = 1;
            this.label_Path.Text = ">>>";
            // 
            // pictureBox_VideoWindow
            // 
            this.pictureBox_VideoWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_VideoWindow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_VideoWindow.Location = new System.Drawing.Point(430, 44);
            this.pictureBox_VideoWindow.Name = "pictureBox_VideoWindow";
            this.pictureBox_VideoWindow.Size = new System.Drawing.Size(566, 574);
            this.pictureBox_VideoWindow.TabIndex = 2;
            this.pictureBox_VideoWindow.TabStop = false;
            // 
            // listView_LocalVideo
            // 
            this.listView_LocalVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_LocalVideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VideoName,
            this.StartTime,
            this.EndTime});
            this.listView_LocalVideo.FullRowSelect = true;
            this.listView_LocalVideo.HideSelection = false;
            this.listView_LocalVideo.Location = new System.Drawing.Point(12, 45);
            this.listView_LocalVideo.MultiSelect = false;
            this.listView_LocalVideo.Name = "listView_LocalVideo";
            this.listView_LocalVideo.Size = new System.Drawing.Size(412, 573);
            this.listView_LocalVideo.TabIndex = 1;
            this.listView_LocalVideo.UseCompatibleStateImageBehavior = false;
            this.listView_LocalVideo.View = System.Windows.Forms.View.Details;
            this.listView_LocalVideo.SelectedIndexChanged += new System.EventHandler(this.listView_LocalVideo_SelectedIndexChanged);
            // 
            // VideoName
            // 
            this.VideoName.Text = "Name";
            this.VideoName.Width = 254;
            // 
            // StartTime
            // 
            this.StartTime.Text = "StartTime";
            this.StartTime.Width = 165;
            // 
            // EndTime
            // 
            this.EndTime.Text = "EndTime";
            this.EndTime.Width = 146;
            // 
            // button_StartPlay
            // 
            this.button_StartPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_StartPlay.Location = new System.Drawing.Point(13, 626);
            this.button_StartPlay.Name = "button_StartPlay";
            this.button_StartPlay.Size = new System.Drawing.Size(103, 29);
            this.button_StartPlay.TabIndex = 2;
            this.button_StartPlay.Text = "StartPlay";
            this.button_StartPlay.UseVisualStyleBackColor = true;
            this.button_StartPlay.Click += new System.EventHandler(this.button_StartPlay_Click);
            // 
            // button_StopPlay
            // 
            this.button_StopPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_StopPlay.Location = new System.Drawing.Point(121, 626);
            this.button_StopPlay.Name = "button_StopPlay";
            this.button_StopPlay.Size = new System.Drawing.Size(103, 29);
            this.button_StopPlay.TabIndex = 3;
            this.button_StopPlay.Text = "StopPlay";
            this.button_StopPlay.UseVisualStyleBackColor = true;
            this.button_StopPlay.Click += new System.EventHandler(this.button_StopPlay_Click);
            // 
            // label_LocalVideo
            // 
            this.label_LocalVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_LocalVideo.AutoSize = true;
            this.label_LocalVideo.Location = new System.Drawing.Point(260, 634);
            this.label_LocalVideo.Name = "label_LocalVideo";
            this.label_LocalVideo.Size = new System.Drawing.Size(25, 13);
            this.label_LocalVideo.TabIndex = 5;
            this.label_LocalVideo.Text = "......";
            // 
            // Form_LocalVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.label_LocalVideo);
            this.Controls.Add(this.button_StopPlay);
            this.Controls.Add(this.button_StartPlay);
            this.Controls.Add(this.listView_LocalVideo);
            this.Controls.Add(this.pictureBox_VideoWindow);
            this.Controls.Add(this.label_Path);
            this.Controls.Add(this.button_Search);
            this.Name = "Form_LocalVideo";
            this.Text = "LocalVideo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_LocalVideo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.PictureBox pictureBox_VideoWindow;
        private System.Windows.Forms.ListView listView_LocalVideo;
        private System.Windows.Forms.Button button_StartPlay;
        private System.Windows.Forms.Button button_StopPlay;
        private System.Windows.Forms.ColumnHeader VideoName;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.Label label_LocalVideo;
    }
}