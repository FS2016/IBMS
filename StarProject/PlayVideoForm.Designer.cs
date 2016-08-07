namespace HUSSDKDemo
{
    partial class Form_PlayVideo
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
            this.pictureBox_VideoWindow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_VideoWindow
            // 
            this.pictureBox_VideoWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_VideoWindow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_VideoWindow.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_VideoWindow.Name = "pictureBox_VideoWindow";
            this.pictureBox_VideoWindow.Size = new System.Drawing.Size(560, 418);
            this.pictureBox_VideoWindow.TabIndex = 0;
            this.pictureBox_VideoWindow.TabStop = false;
            // 
            // Form_PlayVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.pictureBox_VideoWindow);
            this.Name = "Form_PlayVideo";
            this.Text = "PlayVideoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_PlayVideo_FormClosed);
            this.Load += new System.EventHandler(this.Form_PlayVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_VideoWindow;
    }
}