namespace EU4Backupper
{
    partial class SettingsForm
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
            this.openScumFolderBtn = new System.Windows.Forms.Button();
            this.saveFolderTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectSaveFolderBtn = new System.Windows.Forms.Button();
            this.AutoStartCB = new System.Windows.Forms.CheckBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.selectExeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exeBox = new System.Windows.Forms.TextBox();
            this.autoRebootCheck = new System.Windows.Forms.CheckBox();
            this.SaveInterval = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.autosaveIntervalLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SaveInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // openScumFolderBtn
            // 
            this.openScumFolderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openScumFolderBtn.Location = new System.Drawing.Point(8, 127);
            this.openScumFolderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openScumFolderBtn.Name = "openScumFolderBtn";
            this.openScumFolderBtn.Size = new System.Drawing.Size(145, 20);
            this.openScumFolderBtn.TabIndex = 5;
            this.openScumFolderBtn.Text = "Open Scum Folder";
            this.openScumFolderBtn.UseVisualStyleBackColor = true;
            this.openScumFolderBtn.Click += new System.EventHandler(this.openScumFolderBtn_Click);
            // 
            // saveFolderTB
            // 
            this.saveFolderTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFolderTB.Location = new System.Drawing.Point(110, 7);
            this.saveFolderTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveFolderTB.Name = "saveFolderTB";
            this.saveFolderTB.Size = new System.Drawing.Size(135, 23);
            this.saveFolderTB.TabIndex = 1;
            this.saveFolderTB.TextChanged += new System.EventHandler(this.saveFolderTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "EU4 save folder:";
            // 
            // SelectSaveFolderBtn
            // 
            this.SelectSaveFolderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectSaveFolderBtn.Location = new System.Drawing.Point(248, 6);
            this.SelectSaveFolderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectSaveFolderBtn.Name = "SelectSaveFolderBtn";
            this.SelectSaveFolderBtn.Size = new System.Drawing.Size(78, 20);
            this.SelectSaveFolderBtn.TabIndex = 3;
            this.SelectSaveFolderBtn.Text = "Select";
            this.SelectSaveFolderBtn.UseVisualStyleBackColor = true;
            this.SelectSaveFolderBtn.Click += new System.EventHandler(this.SelectSaveFolder_Click);
            // 
            // AutoStartCB
            // 
            this.AutoStartCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AutoStartCB.AutoSize = true;
            this.AutoStartCB.Location = new System.Drawing.Point(8, 90);
            this.AutoStartCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AutoStartCB.Name = "AutoStartCB";
            this.AutoStartCB.Size = new System.Drawing.Size(79, 19);
            this.AutoStartCB.TabIndex = 4;
            this.AutoStartCB.Text = "Auto Start";
            this.AutoStartCB.UseVisualStyleBackColor = true;
            this.AutoStartCB.CheckedChanged += new System.EventHandler(this.autoStartCB_CheckedChanged);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(248, 127);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(78, 20);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // selectExeBtn
            // 
            this.selectExeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectExeBtn.Location = new System.Drawing.Point(248, 28);
            this.selectExeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectExeBtn.Name = "selectExeBtn";
            this.selectExeBtn.Size = new System.Drawing.Size(78, 20);
            this.selectExeBtn.TabIndex = 8;
            this.selectExeBtn.Text = "Select";
            this.selectExeBtn.UseVisualStyleBackColor = true;
            this.selectExeBtn.Click += new System.EventHandler(this.selectExeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Steam exe:";
            // 
            // exeBox
            // 
            this.exeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exeBox.Location = new System.Drawing.Point(110, 29);
            this.exeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exeBox.Name = "exeBox";
            this.exeBox.Size = new System.Drawing.Size(135, 23);
            this.exeBox.TabIndex = 6;
            this.exeBox.TextChanged += new System.EventHandler(this.exeBox_TextChanged);
            // 
            // autoRebootCheck
            // 
            this.autoRebootCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoRebootCheck.AutoSize = true;
            this.autoRebootCheck.Location = new System.Drawing.Point(110, 90);
            this.autoRebootCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.autoRebootCheck.Name = "autoRebootCheck";
            this.autoRebootCheck.Size = new System.Drawing.Size(93, 19);
            this.autoRebootCheck.TabIndex = 9;
            this.autoRebootCheck.Text = "Auto Reboot";
            this.autoRebootCheck.UseVisualStyleBackColor = true;
            this.autoRebootCheck.CheckedChanged += new System.EventHandler(this.autoRebootCheck_CheckedChanged);
            // 
            // SaveInterval
            // 
            this.SaveInterval.Location = new System.Drawing.Point(122, 51);
            this.SaveInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveInterval.Maximum = 4;
            this.SaveInterval.Name = "SaveInterval";
            this.SaveInterval.Size = new System.Drawing.Size(122, 45);
            this.SaveInterval.TabIndex = 10;
            this.SaveInterval.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SaveInterval.Value = 2;
            this.SaveInterval.Scroll += new System.EventHandler(this.SaveInterval_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Auto save interval:";
            // 
            // autosaveIntervalLbl
            // 
            this.autosaveIntervalLbl.AutoSize = true;
            this.autosaveIntervalLbl.Location = new System.Drawing.Point(248, 58);
            this.autosaveIntervalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autosaveIntervalLbl.Name = "autosaveIntervalLbl";
            this.autosaveIntervalLbl.Size = new System.Drawing.Size(37, 15);
            this.autosaveIntervalLbl.TabIndex = 12;
            this.autosaveIntervalLbl.Text = "1 min";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 154);
            this.Controls.Add(this.autosaveIntervalLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.autoRebootCheck);
            this.Controls.Add(this.selectExeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exeBox);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.AutoStartCB);
            this.Controls.Add(this.SelectSaveFolderBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveFolderTB);
            this.Controls.Add(this.openScumFolderBtn);
            this.Controls.Add(this.SaveInterval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaveInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openScumFolderBtn;
        private TextBox saveFolderTB;
        private Label label1;
        private Button SelectSaveFolderBtn;
        private CheckBox AutoStartCB;
        private Button okBtn;
        private Button selectExeBtn;
        private Label label2;
        private TextBox exeBox;
        private CheckBox autoRebootCheck;
        private TrackBar SaveInterval;
        private Label label3;
        private Label autosaveIntervalLbl;
    }
}