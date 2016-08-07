namespace HUSSDKDemo
{
    partial class Form_LiveView
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
            this.listView_Stream = new System.Windows.Forms.ListView();
            this.column_StreamName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox_VideoWindow = new System.Windows.Forms.PictureBox();
            this.button_StartPlay = new System.Windows.Forms.Button();
            this.button_StopPlay = new System.Windows.Forms.Button();
            this.label_Playing = new System.Windows.Forms.Label();
            this.button_Snapshot = new System.Windows.Forms.Button();
            this.label_SnapshotPath = new System.Windows.Forms.Label();
            this.button_StartDialog = new System.Windows.Forms.Button();
            this.button_StopDialog = new System.Windows.Forms.Button();
            this.listView_VirtualStream = new System.Windows.Forms.ListView();
            this.column_StreamServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_LeftUp = new System.Windows.Forms.Button();
            this.button_Up = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_ZoomOut = new System.Windows.Forms.Button();
            this.button_RightUp = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.button_LeftDown = new System.Windows.Forms.Button();
            this.button_RightDown = new System.Windows.Forms.Button();
            this.button_Down = new System.Windows.Forms.Button();
            this.button_ZoomIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Step = new System.Windows.Forms.ComboBox();
            this.checkBox_LightOn = new System.Windows.Forms.CheckBox();
            this.checkBox_WipeOn = new System.Windows.Forms.CheckBox();
            this.checkBox_WashOn = new System.Windows.Forms.CheckBox();
            this.checkBox_AuxOn = new System.Windows.Forms.CheckBox();
            this.button_FocusOut = new System.Windows.Forms.Button();
            this.button_FocusIn = new System.Windows.Forms.Button();
            this.button_IrisOn = new System.Windows.Forms.Button();
            this.button_IrisOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Preset_set = new System.Windows.Forms.Button();
            this.button_Preset_Goto = new System.Windows.Forms.Button();
            this.button_Preset_Del = new System.Windows.Forms.Button();
            this.textBox_Preset = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_PTZInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOSD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Stream
            // 
            this.listView_Stream.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_Stream.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_StreamName,
            this.column_Status});
            this.listView_Stream.FullRowSelect = true;
            this.listView_Stream.HideSelection = false;
            this.listView_Stream.Location = new System.Drawing.Point(12, 12);
            this.listView_Stream.MultiSelect = false;
            this.listView_Stream.Name = "listView_Stream";
            this.listView_Stream.Size = new System.Drawing.Size(336, 618);
            this.listView_Stream.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_Stream.TabIndex = 0;
            this.listView_Stream.UseCompatibleStateImageBehavior = false;
            this.listView_Stream.View = System.Windows.Forms.View.Details;
            this.listView_Stream.SelectedIndexChanged += new System.EventHandler(this.listView_Device_SelectedIndexChanged);
            // 
            // column_StreamName
            // 
            this.column_StreamName.Text = "Name";
            this.column_StreamName.Width = 265;
            // 
            // column_Status
            // 
            this.column_Status.Text = "Status";
            this.column_Status.Width = 71;
            // 
            // pictureBox_VideoWindow
            // 
            this.pictureBox_VideoWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_VideoWindow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_VideoWindow.Location = new System.Drawing.Point(354, 12);
            this.pictureBox_VideoWindow.Name = "pictureBox_VideoWindow";
            this.pictureBox_VideoWindow.Size = new System.Drawing.Size(645, 618);
            this.pictureBox_VideoWindow.TabIndex = 1;
            this.pictureBox_VideoWindow.TabStop = false;
            // 
            // button_StartPlay
            // 
            this.button_StartPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_StartPlay.Location = new System.Drawing.Point(354, 658);
            this.button_StartPlay.Name = "button_StartPlay";
            this.button_StartPlay.Size = new System.Drawing.Size(95, 26);
            this.button_StartPlay.TabIndex = 2;
            this.button_StartPlay.Text = "StartPlay";
            this.button_StartPlay.UseVisualStyleBackColor = true;
            this.button_StartPlay.Click += new System.EventHandler(this.button_StartPlay_Click);
            // 
            // button_StopPlay
            // 
            this.button_StopPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_StopPlay.Location = new System.Drawing.Point(464, 658);
            this.button_StopPlay.Name = "button_StopPlay";
            this.button_StopPlay.Size = new System.Drawing.Size(95, 26);
            this.button_StopPlay.TabIndex = 3;
            this.button_StopPlay.Text = "StopPlay";
            this.button_StopPlay.UseVisualStyleBackColor = true;
            this.button_StopPlay.Click += new System.EventHandler(this.button_StopPlay_Click);
            // 
            // label_Playing
            // 
            this.label_Playing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Playing.AutoSize = true;
            this.label_Playing.Location = new System.Drawing.Point(357, 634);
            this.label_Playing.Name = "label_Playing";
            this.label_Playing.Size = new System.Drawing.Size(25, 13);
            this.label_Playing.TabIndex = 3;
            this.label_Playing.Text = "......";
            // 
            // button_Snapshot
            // 
            this.button_Snapshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Snapshot.Location = new System.Drawing.Point(355, 731);
            this.button_Snapshot.Name = "button_Snapshot";
            this.button_Snapshot.Size = new System.Drawing.Size(95, 26);
            this.button_Snapshot.TabIndex = 6;
            this.button_Snapshot.Text = "Snapshot";
            this.button_Snapshot.UseVisualStyleBackColor = true;
            this.button_Snapshot.Click += new System.EventHandler(this.button_Snapshot_Click);
            // 
            // label_SnapshotPath
            // 
            this.label_SnapshotPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_SnapshotPath.AutoSize = true;
            this.label_SnapshotPath.Location = new System.Drawing.Point(357, 760);
            this.label_SnapshotPath.Name = "label_SnapshotPath";
            this.label_SnapshotPath.Size = new System.Drawing.Size(25, 13);
            this.label_SnapshotPath.TabIndex = 4;
            this.label_SnapshotPath.Text = "......";
            // 
            // button_StartDialog
            // 
            this.button_StartDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_StartDialog.Location = new System.Drawing.Point(354, 693);
            this.button_StartDialog.Name = "button_StartDialog";
            this.button_StartDialog.Size = new System.Drawing.Size(95, 26);
            this.button_StartDialog.TabIndex = 4;
            this.button_StartDialog.Text = "StartDialog";
            this.button_StartDialog.UseVisualStyleBackColor = true;
            this.button_StartDialog.Click += new System.EventHandler(this.button_StartDialog_Click);
            // 
            // button_StopDialog
            // 
            this.button_StopDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_StopDialog.Location = new System.Drawing.Point(464, 693);
            this.button_StopDialog.Name = "button_StopDialog";
            this.button_StopDialog.Size = new System.Drawing.Size(95, 26);
            this.button_StopDialog.TabIndex = 5;
            this.button_StopDialog.Text = "StopDialog";
            this.button_StopDialog.UseVisualStyleBackColor = true;
            this.button_StopDialog.Click += new System.EventHandler(this.button_StopDialog_Click);
            // 
            // listView_VirtualStream
            // 
            this.listView_VirtualStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_VirtualStream.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_StreamServer});
            this.listView_VirtualStream.FullRowSelect = true;
            this.listView_VirtualStream.HideSelection = false;
            this.listView_VirtualStream.Location = new System.Drawing.Point(12, 637);
            this.listView_VirtualStream.MultiSelect = false;
            this.listView_VirtualStream.Name = "listView_VirtualStream";
            this.listView_VirtualStream.Size = new System.Drawing.Size(336, 126);
            this.listView_VirtualStream.TabIndex = 1;
            this.listView_VirtualStream.UseCompatibleStateImageBehavior = false;
            this.listView_VirtualStream.View = System.Windows.Forms.View.Details;
            this.listView_VirtualStream.SelectedIndexChanged += new System.EventHandler(this.listView_VirtualStream_SelectedIndexChanged);
            // 
            // column_StreamServer
            // 
            this.column_StreamServer.Text = "StreamServer";
            this.column_StreamServer.Width = 316;
            // 
            // button_LeftUp
            // 
            this.button_LeftUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LeftUp.Location = new System.Drawing.Point(883, 651);
            this.button_LeftUp.Name = "button_LeftUp";
            this.button_LeftUp.Size = new System.Drawing.Size(33, 26);
            this.button_LeftUp.TabIndex = 8;
            this.button_LeftUp.Text = "\\";
            this.button_LeftUp.UseVisualStyleBackColor = true;
            this.button_LeftUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_LeftUp_MouseDown);
            this.button_LeftUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_LeftUp_MouseUp);
            // 
            // button_Up
            // 
            this.button_Up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Up.Location = new System.Drawing.Point(920, 641);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(33, 26);
            this.button_Up.TabIndex = 9;
            this.button_Up.Text = "|";
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Up_MouseDown);
            this.button_Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Up_MouseUp);
            // 
            // button_Left
            // 
            this.button_Left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Left.Location = new System.Drawing.Point(877, 679);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(33, 26);
            this.button_Left.TabIndex = 11;
            this.button_Left.Text = "--";
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Left_MouseDown);
            this.button_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Left_MouseUp);
            // 
            // button_ZoomOut
            // 
            this.button_ZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ZoomOut.Location = new System.Drawing.Point(920, 692);
            this.button_ZoomOut.Name = "button_ZoomOut";
            this.button_ZoomOut.Size = new System.Drawing.Size(33, 23);
            this.button_ZoomOut.TabIndex = 13;
            this.button_ZoomOut.Text = "-";
            this.button_ZoomOut.UseVisualStyleBackColor = true;
            this.button_ZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_ZoomOut_MouseDown);
            this.button_ZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_ZoomOut_MouseUp);
            // 
            // button_RightUp
            // 
            this.button_RightUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RightUp.Location = new System.Drawing.Point(959, 651);
            this.button_RightUp.Name = "button_RightUp";
            this.button_RightUp.Size = new System.Drawing.Size(33, 26);
            this.button_RightUp.TabIndex = 10;
            this.button_RightUp.Text = "/";
            this.button_RightUp.UseVisualStyleBackColor = true;
            this.button_RightUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_RightUp_MouseDown);
            this.button_RightUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_RightUp_MouseUp);
            // 
            // button_Right
            // 
            this.button_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Right.Location = new System.Drawing.Point(965, 679);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(33, 26);
            this.button_Right.TabIndex = 14;
            this.button_Right.Text = "--";
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Right_MouseDown);
            this.button_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Right_MouseUp);
            // 
            // button_LeftDown
            // 
            this.button_LeftDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LeftDown.Location = new System.Drawing.Point(883, 707);
            this.button_LeftDown.Name = "button_LeftDown";
            this.button_LeftDown.Size = new System.Drawing.Size(33, 26);
            this.button_LeftDown.TabIndex = 15;
            this.button_LeftDown.Text = "/";
            this.button_LeftDown.UseVisualStyleBackColor = true;
            this.button_LeftDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_LeftDown_MouseDown);
            this.button_LeftDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_LeftDown_MouseUp);
            // 
            // button_RightDown
            // 
            this.button_RightDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RightDown.Location = new System.Drawing.Point(958, 707);
            this.button_RightDown.Name = "button_RightDown";
            this.button_RightDown.Size = new System.Drawing.Size(33, 26);
            this.button_RightDown.TabIndex = 17;
            this.button_RightDown.Text = "\\";
            this.button_RightDown.UseVisualStyleBackColor = true;
            this.button_RightDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_RightDown_MouseDown);
            this.button_RightDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_RightDown_MouseUp);
            // 
            // button_Down
            // 
            this.button_Down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Down.Location = new System.Drawing.Point(920, 716);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(33, 26);
            this.button_Down.TabIndex = 16;
            this.button_Down.Text = "|";
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Down_MouseDown);
            this.button_Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Down_MouseUp);
            // 
            // button_ZoomIn
            // 
            this.button_ZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ZoomIn.Location = new System.Drawing.Point(920, 670);
            this.button_ZoomIn.Name = "button_ZoomIn";
            this.button_ZoomIn.Size = new System.Drawing.Size(33, 23);
            this.button_ZoomIn.TabIndex = 12;
            this.button_ZoomIn.Text = "+";
            this.button_ZoomIn.UseVisualStyleBackColor = true;
            this.button_ZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_ZoomIn_MouseDown);
            this.button_ZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_ZoomIn_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Step:";
            // 
            // comboBox_Step
            // 
            this.comboBox_Step.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Step.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Step.FormattingEnabled = true;
            this.comboBox_Step.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox_Step.Location = new System.Drawing.Point(820, 643);
            this.comboBox_Step.Name = "comboBox_Step";
            this.comboBox_Step.Size = new System.Drawing.Size(53, 21);
            this.comboBox_Step.TabIndex = 7;
            // 
            // checkBox_LightOn
            // 
            this.checkBox_LightOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_LightOn.AutoSize = true;
            this.checkBox_LightOn.Location = new System.Drawing.Point(792, 672);
            this.checkBox_LightOn.Name = "checkBox_LightOn";
            this.checkBox_LightOn.Size = new System.Drawing.Size(63, 17);
            this.checkBox_LightOn.TabIndex = 11;
            this.checkBox_LightOn.Text = "LightOn";
            this.checkBox_LightOn.UseVisualStyleBackColor = true;
            this.checkBox_LightOn.CheckedChanged += new System.EventHandler(this.checkBox_LightOn_CheckedChanged);
            // 
            // checkBox_WipeOn
            // 
            this.checkBox_WipeOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_WipeOn.AutoSize = true;
            this.checkBox_WipeOn.Location = new System.Drawing.Point(792, 690);
            this.checkBox_WipeOn.Name = "checkBox_WipeOn";
            this.checkBox_WipeOn.Size = new System.Drawing.Size(65, 17);
            this.checkBox_WipeOn.TabIndex = 11;
            this.checkBox_WipeOn.Text = "WipeOn";
            this.checkBox_WipeOn.UseVisualStyleBackColor = true;
            this.checkBox_WipeOn.CheckedChanged += new System.EventHandler(this.checkBox_WipeOn_CheckedChanged);
            // 
            // checkBox_WashOn
            // 
            this.checkBox_WashOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_WashOn.AutoSize = true;
            this.checkBox_WashOn.Location = new System.Drawing.Point(792, 708);
            this.checkBox_WashOn.Name = "checkBox_WashOn";
            this.checkBox_WashOn.Size = new System.Drawing.Size(68, 17);
            this.checkBox_WashOn.TabIndex = 11;
            this.checkBox_WashOn.Text = "WashOn";
            this.checkBox_WashOn.UseVisualStyleBackColor = true;
            this.checkBox_WashOn.CheckedChanged += new System.EventHandler(this.checkBox_WashOn_CheckedChanged);
            // 
            // checkBox_AuxOn
            // 
            this.checkBox_AuxOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_AuxOn.AutoSize = true;
            this.checkBox_AuxOn.Location = new System.Drawing.Point(792, 726);
            this.checkBox_AuxOn.Name = "checkBox_AuxOn";
            this.checkBox_AuxOn.Size = new System.Drawing.Size(58, 17);
            this.checkBox_AuxOn.TabIndex = 11;
            this.checkBox_AuxOn.Text = "AuxOn";
            this.checkBox_AuxOn.UseVisualStyleBackColor = true;
            this.checkBox_AuxOn.CheckedChanged += new System.EventHandler(this.checkBox_AuxOn_CheckedChanged);
            // 
            // button_FocusOut
            // 
            this.button_FocusOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_FocusOut.Location = new System.Drawing.Point(745, 641);
            this.button_FocusOut.Name = "button_FocusOut";
            this.button_FocusOut.Size = new System.Drawing.Size(33, 23);
            this.button_FocusOut.TabIndex = 18;
            this.button_FocusOut.Text = "-";
            this.button_FocusOut.UseVisualStyleBackColor = true;
            this.button_FocusOut.Click += new System.EventHandler(this.button_FocusOut_Click);
            // 
            // button_FocusIn
            // 
            this.button_FocusIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_FocusIn.Location = new System.Drawing.Point(670, 641);
            this.button_FocusIn.Name = "button_FocusIn";
            this.button_FocusIn.Size = new System.Drawing.Size(33, 23);
            this.button_FocusIn.TabIndex = 18;
            this.button_FocusIn.Text = "+";
            this.button_FocusIn.UseVisualStyleBackColor = true;
            this.button_FocusIn.Click += new System.EventHandler(this.button_FocusIn_Click);
            // 
            // button_IrisOn
            // 
            this.button_IrisOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_IrisOn.Location = new System.Drawing.Point(670, 667);
            this.button_IrisOn.Name = "button_IrisOn";
            this.button_IrisOn.Size = new System.Drawing.Size(33, 23);
            this.button_IrisOn.TabIndex = 18;
            this.button_IrisOn.Text = "+";
            this.button_IrisOn.UseVisualStyleBackColor = true;
            this.button_IrisOn.Click += new System.EventHandler(this.button_IrisOn_Click);
            // 
            // button_IrisOut
            // 
            this.button_IrisOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_IrisOut.Location = new System.Drawing.Point(745, 667);
            this.button_IrisOut.Name = "button_IrisOut";
            this.button_IrisOut.Size = new System.Drawing.Size(33, 23);
            this.button_IrisOut.TabIndex = 18;
            this.button_IrisOut.Text = "-";
            this.button_IrisOut.UseVisualStyleBackColor = true;
            this.button_IrisOut.Click += new System.EventHandler(this.button_IrisOut_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Focus:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Iris:";
            // 
            // button_Preset_set
            // 
            this.button_Preset_set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Preset_set.Location = new System.Drawing.Point(670, 737);
            this.button_Preset_set.Name = "button_Preset_set";
            this.button_Preset_set.Size = new System.Drawing.Size(53, 26);
            this.button_Preset_set.TabIndex = 19;
            this.button_Preset_set.Text = "Set";
            this.button_Preset_set.UseVisualStyleBackColor = true;
            this.button_Preset_set.Click += new System.EventHandler(this.button_Preset_set_Click);
            // 
            // button_Preset_Goto
            // 
            this.button_Preset_Goto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Preset_Goto.Location = new System.Drawing.Point(725, 711);
            this.button_Preset_Goto.Name = "button_Preset_Goto";
            this.button_Preset_Goto.Size = new System.Drawing.Size(53, 26);
            this.button_Preset_Goto.TabIndex = 19;
            this.button_Preset_Goto.Text = "Goto";
            this.button_Preset_Goto.UseVisualStyleBackColor = true;
            this.button_Preset_Goto.Click += new System.EventHandler(this.button_Preset_Goto_Click);
            // 
            // button_Preset_Del
            // 
            this.button_Preset_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Preset_Del.Location = new System.Drawing.Point(725, 737);
            this.button_Preset_Del.Name = "button_Preset_Del";
            this.button_Preset_Del.Size = new System.Drawing.Size(53, 26);
            this.button_Preset_Del.TabIndex = 19;
            this.button_Preset_Del.Text = "Del";
            this.button_Preset_Del.UseVisualStyleBackColor = true;
            this.button_Preset_Del.Click += new System.EventHandler(this.button_Preset_Del_Click);
            // 
            // textBox_Preset
            // 
            this.textBox_Preset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Preset.Location = new System.Drawing.Point(670, 714);
            this.textBox_Preset.Name = "textBox_Preset";
            this.textBox_Preset.Size = new System.Drawing.Size(53, 20);
            this.textBox_Preset.TabIndex = 20;
            this.textBox_Preset.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 696);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preset:";
            // 
            // label_PTZInfo
            // 
            this.label_PTZInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PTZInfo.AutoSize = true;
            this.label_PTZInfo.Location = new System.Drawing.Point(880, 752);
            this.label_PTZInfo.Name = "label_PTZInfo";
            this.label_PTZInfo.Size = new System.Drawing.Size(77, 13);
            this.label_PTZInfo.TabIndex = 21;
            this.label_PTZInfo.Text = "PTZ Operation";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 737);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "OSD:";
            // 
            // lblOSD
            // 
            this.lblOSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOSD.AutoSize = true;
            this.lblOSD.Location = new System.Drawing.Point(500, 737);
            this.lblOSD.Name = "lblOSD";
            this.lblOSD.Size = new System.Drawing.Size(16, 13);
            this.lblOSD.TabIndex = 23;
            this.lblOSD.Text = "...";
            // 
            // Form_LiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 774);
            this.Controls.Add(this.lblOSD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_PTZInfo);
            this.Controls.Add(this.textBox_Preset);
            this.Controls.Add(this.button_Preset_Del);
            this.Controls.Add(this.button_Preset_Goto);
            this.Controls.Add(this.button_Preset_set);
            this.Controls.Add(this.button_IrisOut);
            this.Controls.Add(this.button_IrisOn);
            this.Controls.Add(this.button_FocusIn);
            this.Controls.Add(this.button_FocusOut);
            this.Controls.Add(this.checkBox_AuxOn);
            this.Controls.Add(this.checkBox_WashOn);
            this.Controls.Add(this.checkBox_WipeOn);
            this.Controls.Add(this.checkBox_LightOn);
            this.Controls.Add(this.comboBox_Step);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Down);
            this.Controls.Add(this.button_RightDown);
            this.Controls.Add(this.button_LeftDown);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.button_RightUp);
            this.Controls.Add(this.button_ZoomIn);
            this.Controls.Add(this.button_ZoomOut);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.button_Up);
            this.Controls.Add(this.button_LeftUp);
            this.Controls.Add(this.listView_VirtualStream);
            this.Controls.Add(this.button_StopDialog);
            this.Controls.Add(this.button_StartDialog);
            this.Controls.Add(this.label_SnapshotPath);
            this.Controls.Add(this.label_Playing);
            this.Controls.Add(this.button_Snapshot);
            this.Controls.Add(this.button_StopPlay);
            this.Controls.Add(this.button_StartPlay);
            this.Controls.Add(this.pictureBox_VideoWindow);
            this.Controls.Add(this.listView_Stream);
            this.Name = "Form_LiveView";
            this.Text = "LiveView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_LiveView_FormClosed);
            this.Load += new System.EventHandler(this.Form_LiveView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Stream;
        private System.Windows.Forms.PictureBox pictureBox_VideoWindow;
        private System.Windows.Forms.Button button_StartPlay;
        private System.Windows.Forms.Button button_StopPlay;
        private System.Windows.Forms.Label label_Playing;
        private System.Windows.Forms.Button button_Snapshot;
        private System.Windows.Forms.Label label_SnapshotPath;
        private System.Windows.Forms.Button button_StartDialog;
        private System.Windows.Forms.Button button_StopDialog;
        private System.Windows.Forms.ListView listView_VirtualStream;
        private System.Windows.Forms.ColumnHeader column_StreamName;
        private System.Windows.Forms.ColumnHeader column_StreamServer;
        private System.Windows.Forms.ColumnHeader column_Status;
        private System.Windows.Forms.Button button_LeftUp;
        private System.Windows.Forms.Button button_Up;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_ZoomOut;
        private System.Windows.Forms.Button button_RightUp;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.Button button_LeftDown;
        private System.Windows.Forms.Button button_RightDown;
        private System.Windows.Forms.Button button_Down;
        private System.Windows.Forms.Button button_ZoomIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Step;
        private System.Windows.Forms.CheckBox checkBox_LightOn;
        private System.Windows.Forms.CheckBox checkBox_WipeOn;
        private System.Windows.Forms.CheckBox checkBox_WashOn;
        private System.Windows.Forms.CheckBox checkBox_AuxOn;
        private System.Windows.Forms.Button button_FocusOut;
        private System.Windows.Forms.Button button_FocusIn;
        private System.Windows.Forms.Button button_IrisOn;
        private System.Windows.Forms.Button button_IrisOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Preset_set;
        private System.Windows.Forms.Button button_Preset_Goto;
        private System.Windows.Forms.Button button_Preset_Del;
        private System.Windows.Forms.TextBox textBox_Preset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_PTZInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOSD;
    }
}