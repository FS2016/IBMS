namespace HUSSDKDemo
{
    partial class Form_HandleAlarm
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
            this.listView_ReceiveAlarm = new System.Windows.Forms.ListView();
            this.column_Device1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Type1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Level1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_FirstTime1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Count1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_LastTime1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Detail1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ECName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Status1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_ProcessingAlarm = new System.Windows.Forms.ListView();
            this.column_Device2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Type2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Level2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_FirstTime2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Count2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_LastTime2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Detail2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ECName2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Status2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_ProcessingAlarm = new System.Windows.Forms.Button();
            this.listView_ProcessedAlarm = new System.Windows.Forms.ListView();
            this.column_Device3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Type3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Level3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_FirstTime3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Count3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_LastTime3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Detail3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ECName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_ProcessedAlarm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_ReceiveAlarm
            // 
            this.listView_ReceiveAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_ReceiveAlarm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Device1,
            this.column_Type1,
            this.column_Level1,
            this.column_FirstTime1,
            this.column_Count1,
            this.column_LastTime1,
            this.column_Detail1,
            this.column_ECName1,
            this.column_Status1});
            this.listView_ReceiveAlarm.FullRowSelect = true;
            this.listView_ReceiveAlarm.HideSelection = false;
            this.listView_ReceiveAlarm.Location = new System.Drawing.Point(12, 12);
            this.listView_ReceiveAlarm.Name = "listView_ReceiveAlarm";
            this.listView_ReceiveAlarm.Size = new System.Drawing.Size(984, 243);
            this.listView_ReceiveAlarm.TabIndex = 0;
            this.listView_ReceiveAlarm.UseCompatibleStateImageBehavior = false;
            this.listView_ReceiveAlarm.View = System.Windows.Forms.View.Details;
            // 
            // column_Device1
            // 
            this.column_Device1.Text = "Device";
            this.column_Device1.Width = 192;
            // 
            // column_Type1
            // 
            this.column_Type1.Text = "Type";
            this.column_Type1.Width = 155;
            // 
            // column_Level1
            // 
            this.column_Level1.Text = "Level";
            this.column_Level1.Width = 63;
            // 
            // column_FirstTime1
            // 
            this.column_FirstTime1.Text = "FirstTime";
            this.column_FirstTime1.Width = 117;
            // 
            // column_Count1
            // 
            this.column_Count1.Text = "Count";
            this.column_Count1.Width = 49;
            // 
            // column_LastTime1
            // 
            this.column_LastTime1.Text = "LastTime";
            this.column_LastTime1.Width = 120;
            // 
            // column_Detail1
            // 
            this.column_Detail1.Text = "Detail";
            this.column_Detail1.Width = 102;
            // 
            // column_ECName1
            // 
            this.column_ECName1.Text = "ECName";
            this.column_ECName1.Width = 168;
            // 
            // column_Status1
            // 
            this.column_Status1.Text = "Status";
            this.column_Status1.Width = 83;
            // 
            // listView_ProcessingAlarm
            // 
            this.listView_ProcessingAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_ProcessingAlarm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Device2,
            this.column_Type2,
            this.column_Level2,
            this.column_FirstTime2,
            this.column_Count2,
            this.column_LastTime2,
            this.column_Detail2,
            this.column_ECName2,
            this.column_Status2});
            this.listView_ProcessingAlarm.FullRowSelect = true;
            this.listView_ProcessingAlarm.HideSelection = false;
            this.listView_ProcessingAlarm.Location = new System.Drawing.Point(12, 297);
            this.listView_ProcessingAlarm.Name = "listView_ProcessingAlarm";
            this.listView_ProcessingAlarm.Size = new System.Drawing.Size(980, 162);
            this.listView_ProcessingAlarm.TabIndex = 2;
            this.listView_ProcessingAlarm.UseCompatibleStateImageBehavior = false;
            this.listView_ProcessingAlarm.View = System.Windows.Forms.View.Details;
            // 
            // column_Device2
            // 
            this.column_Device2.Text = "Device";
            this.column_Device2.Width = 190;
            // 
            // column_Type2
            // 
            this.column_Type2.Text = "Type";
            this.column_Type2.Width = 158;
            // 
            // column_Level2
            // 
            this.column_Level2.Text = "Level";
            this.column_Level2.Width = 62;
            // 
            // column_FirstTime2
            // 
            this.column_FirstTime2.Text = "FirstTime";
            this.column_FirstTime2.Width = 128;
            // 
            // column_Count2
            // 
            this.column_Count2.Text = "Count";
            this.column_Count2.Width = 49;
            // 
            // column_LastTime2
            // 
            this.column_LastTime2.Text = "LastTime";
            this.column_LastTime2.Width = 116;
            // 
            // column_Detail2
            // 
            this.column_Detail2.Text = "Detail";
            this.column_Detail2.Width = 88;
            // 
            // column_ECName2
            // 
            this.column_ECName2.Text = "ECName";
            this.column_ECName2.Width = 106;
            // 
            // column_Status2
            // 
            this.column_Status2.Text = "Status";
            this.column_Status2.Width = 80;
            // 
            // button_ProcessingAlarm
            // 
            this.button_ProcessingAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ProcessingAlarm.Location = new System.Drawing.Point(12, 259);
            this.button_ProcessingAlarm.Name = "button_ProcessingAlarm";
            this.button_ProcessingAlarm.Size = new System.Drawing.Size(103, 32);
            this.button_ProcessingAlarm.TabIndex = 1;
            this.button_ProcessingAlarm.Text = "ProcessingAlarm";
            this.button_ProcessingAlarm.UseVisualStyleBackColor = true;
            this.button_ProcessingAlarm.Click += new System.EventHandler(this.button_ProcessingAlarm_Click);
            // 
            // listView_ProcessedAlarm
            // 
            this.listView_ProcessedAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_ProcessedAlarm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Device3,
            this.column_Type3,
            this.column_Level3,
            this.column_FirstTime3,
            this.column_Count3,
            this.column_LastTime3,
            this.column_Detail3,
            this.column_ECName,
            this.column_Status});
            this.listView_ProcessedAlarm.FullRowSelect = true;
            this.listView_ProcessedAlarm.HideSelection = false;
            this.listView_ProcessedAlarm.Location = new System.Drawing.Point(12, 505);
            this.listView_ProcessedAlarm.Name = "listView_ProcessedAlarm";
            this.listView_ProcessedAlarm.Size = new System.Drawing.Size(980, 145);
            this.listView_ProcessedAlarm.TabIndex = 7;
            this.listView_ProcessedAlarm.UseCompatibleStateImageBehavior = false;
            this.listView_ProcessedAlarm.View = System.Windows.Forms.View.Details;
            // 
            // column_Device3
            // 
            this.column_Device3.Text = "Device";
            this.column_Device3.Width = 190;
            // 
            // column_Type3
            // 
            this.column_Type3.Text = "Type";
            this.column_Type3.Width = 159;
            // 
            // column_Level3
            // 
            this.column_Level3.Text = "Level";
            this.column_Level3.Width = 53;
            // 
            // column_FirstTime3
            // 
            this.column_FirstTime3.Text = "FirstTime";
            this.column_FirstTime3.Width = 128;
            // 
            // column_Count3
            // 
            this.column_Count3.Text = "Count";
            this.column_Count3.Width = 51;
            // 
            // column_LastTime3
            // 
            this.column_LastTime3.Text = "LastTime";
            this.column_LastTime3.Width = 124;
            // 
            // column_Detail3
            // 
            this.column_Detail3.Text = "Detail";
            this.column_Detail3.Width = 88;
            // 
            // column_ECName
            // 
            this.column_ECName.Text = "ECName";
            this.column_ECName.Width = 100;
            // 
            // column_Status
            // 
            this.column_Status.Text = "Status";
            this.column_Status.Width = 85;
            // 
            // button_ProcessedAlarm
            // 
            this.button_ProcessedAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ProcessedAlarm.Location = new System.Drawing.Point(736, 465);
            this.button_ProcessedAlarm.Name = "button_ProcessedAlarm";
            this.button_ProcessedAlarm.Size = new System.Drawing.Size(103, 32);
            this.button_ProcessedAlarm.TabIndex = 4;
            this.button_ProcessedAlarm.Text = "ProcessedAlarm";
            this.button_ProcessedAlarm.UseVisualStyleBackColor = true;
            this.button_ProcessedAlarm.Click += new System.EventHandler(this.button_ProcessedAlarm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comment:";
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Comment.Location = new System.Drawing.Point(72, 472);
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(647, 20);
            this.textBox_Comment.TabIndex = 3;
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete.Location = new System.Drawing.Point(867, 465);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(55, 32);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "Clear";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clear.Location = new System.Drawing.Point(928, 465);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(64, 32);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "ClearAll";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form_HandleAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox_Comment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ProcessedAlarm);
            this.Controls.Add(this.button_ProcessingAlarm);
            this.Controls.Add(this.listView_ProcessedAlarm);
            this.Controls.Add(this.listView_ProcessingAlarm);
            this.Controls.Add(this.listView_ReceiveAlarm);
            this.Name = "Form_HandleAlarm";
            this.Text = "HandleAlarmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_ReceiveAlarm;
        private System.Windows.Forms.ListView listView_ProcessingAlarm;
        private System.Windows.Forms.Button button_ProcessingAlarm;
        private System.Windows.Forms.ColumnHeader column_Device1;
        private System.Windows.Forms.ColumnHeader column_Type1;
        private System.Windows.Forms.ColumnHeader column_Level1;
        private System.Windows.Forms.ColumnHeader column_FirstTime1;
        private System.Windows.Forms.ColumnHeader column_Count1;
        private System.Windows.Forms.ColumnHeader column_LastTime1;
        private System.Windows.Forms.ColumnHeader column_Detail1;
        private System.Windows.Forms.ColumnHeader column_ECName1;
        private System.Windows.Forms.ColumnHeader column_Device2;
        private System.Windows.Forms.ColumnHeader column_Type2;
        private System.Windows.Forms.ColumnHeader column_Level2;
        private System.Windows.Forms.ColumnHeader column_FirstTime2;
        private System.Windows.Forms.ColumnHeader column_Count2;
        private System.Windows.Forms.ColumnHeader column_LastTime2;
        private System.Windows.Forms.ColumnHeader column_Detail2;
        private System.Windows.Forms.ColumnHeader column_ECName2;
        private System.Windows.Forms.ColumnHeader column_Status2;
        private System.Windows.Forms.ListView listView_ProcessedAlarm;
        private System.Windows.Forms.ColumnHeader column_Device3;
        private System.Windows.Forms.ColumnHeader column_Type3;
        private System.Windows.Forms.ColumnHeader column_Level3;
        private System.Windows.Forms.ColumnHeader column_FirstTime3;
        private System.Windows.Forms.ColumnHeader column_Count3;
        private System.Windows.Forms.ColumnHeader column_LastTime3;
        private System.Windows.Forms.ColumnHeader column_Detail3;
        private System.Windows.Forms.ColumnHeader column_ECName;
        private System.Windows.Forms.ColumnHeader column_Status;
        private System.Windows.Forms.Button button_ProcessedAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ColumnHeader column_Status1;
    }
}