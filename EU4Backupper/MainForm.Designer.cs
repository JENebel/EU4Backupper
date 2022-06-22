namespace EU4Backupper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.campaignNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.restoreMilestoneBtn = new System.Windows.Forms.Button();
            this.quickSaveMilestoneBtn = new System.Windows.Forms.Button();
            this.checker = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.saveNamedMilestoneBtn = new System.Windows.Forms.Button();
            this.selectMilestoneBtn = new System.Windows.Forms.Button();
            this.savedLbl = new System.Windows.Forms.Label();
            this.restoredLbl = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.intervalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // campaignNameTextBox
            // 
            this.campaignNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.campaignNameTextBox.Location = new System.Drawing.Point(174, 12);
            this.campaignNameTextBox.Name = "campaignNameTextBox";
            this.campaignNameTextBox.Size = new System.Drawing.Size(286, 31);
            this.campaignNameTextBox.TabIndex = 1;
            this.campaignNameTextBox.TextChanged += new System.EventHandler(this.campaignNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campaign Name:";
            // 
            // restoreMilestoneBtn
            // 
            this.restoreMilestoneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreMilestoneBtn.Location = new System.Drawing.Point(299, 243);
            this.restoreMilestoneBtn.Name = "restoreMilestoneBtn";
            this.restoreMilestoneBtn.Size = new System.Drawing.Size(163, 69);
            this.restoreMilestoneBtn.TabIndex = 3;
            this.restoreMilestoneBtn.Text = "Restore Last Milestone";
            this.restoreMilestoneBtn.UseVisualStyleBackColor = true;
            this.restoreMilestoneBtn.Click += new System.EventHandler(this.restoreMilestoneBtn_Click);
            // 
            // quickSaveMilestoneBtn
            // 
            this.quickSaveMilestoneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quickSaveMilestoneBtn.Location = new System.Drawing.Point(11, 160);
            this.quickSaveMilestoneBtn.Name = "quickSaveMilestoneBtn";
            this.quickSaveMilestoneBtn.Size = new System.Drawing.Size(163, 69);
            this.quickSaveMilestoneBtn.TabIndex = 4;
            this.quickSaveMilestoneBtn.Text = "Quick Save Milestone";
            this.quickSaveMilestoneBtn.UseVisualStyleBackColor = true;
            this.quickSaveMilestoneBtn.Click += new System.EventHandler(this.quickSaveMilestoneBtn_Click);
            // 
            // checker
            // 
            this.checker.Interval = 300000;
            this.checker.Tick += new System.EventHandler(this.checker_Tick);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.startBtn.Location = new System.Drawing.Point(11, 77);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(163, 69);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start Auto";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsBtn.Location = new System.Drawing.Point(213, 254);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(46, 46);
            this.settingsBtn.TabIndex = 7;
            this.settingsBtn.Text = "⚙";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // saveNamedMilestoneBtn
            // 
            this.saveNamedMilestoneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveNamedMilestoneBtn.Location = new System.Drawing.Point(12, 243);
            this.saveNamedMilestoneBtn.Name = "saveNamedMilestoneBtn";
            this.saveNamedMilestoneBtn.Size = new System.Drawing.Size(163, 69);
            this.saveNamedMilestoneBtn.TabIndex = 8;
            this.saveNamedMilestoneBtn.Text = "Save Named Milestone";
            this.saveNamedMilestoneBtn.UseVisualStyleBackColor = true;
            this.saveNamedMilestoneBtn.Click += new System.EventHandler(this.saveNamedMilestoneBtn_Click);
            // 
            // selectMilestoneBtn
            // 
            this.selectMilestoneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectMilestoneBtn.Location = new System.Drawing.Point(297, 160);
            this.selectMilestoneBtn.Name = "selectMilestoneBtn";
            this.selectMilestoneBtn.Size = new System.Drawing.Size(163, 69);
            this.selectMilestoneBtn.TabIndex = 9;
            this.selectMilestoneBtn.Text = "All Backups";
            this.selectMilestoneBtn.UseVisualStyleBackColor = true;
            this.selectMilestoneBtn.Click += new System.EventHandler(this.selectMilestoneBtn_Click);
            // 
            // savedLbl
            // 
            this.savedLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savedLbl.ForeColor = System.Drawing.Color.Green;
            this.savedLbl.Location = new System.Drawing.Point(180, 166);
            this.savedLbl.Name = "savedLbl";
            this.savedLbl.Size = new System.Drawing.Size(111, 25);
            this.savedLbl.TabIndex = 11;
            this.savedLbl.Text = "SAVED!";
            this.savedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savedLbl.Visible = false;
            // 
            // restoredLbl
            // 
            this.restoredLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restoredLbl.ForeColor = System.Drawing.Color.Green;
            this.restoredLbl.Location = new System.Drawing.Point(180, 198);
            this.restoredLbl.Name = "restoredLbl";
            this.restoredLbl.Size = new System.Drawing.Size(111, 25);
            this.restoredLbl.TabIndex = 12;
            this.restoredLbl.Text = "RESTORED!";
            this.restoredLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restoredLbl.Visible = false;
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(299, 77);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(161, 69);
            this.restartBtn.TabIndex = 13;
            this.restartBtn.Text = "Reboot";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // intervalLbl
            // 
            this.intervalLbl.AutoSize = true;
            this.intervalLbl.Location = new System.Drawing.Point(180, 94);
            this.intervalLbl.Name = "intervalLbl";
            this.intervalLbl.Size = new System.Drawing.Size(57, 25);
            this.intervalLbl.TabIndex = 14;
            this.intervalLbl.Text = "5 min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 324);
            this.Controls.Add(this.intervalLbl);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.restoredLbl);
            this.Controls.Add(this.savedLbl);
            this.Controls.Add(this.selectMilestoneBtn);
            this.Controls.Add(this.saveNamedMilestoneBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.quickSaveMilestoneBtn);
            this.Controls.Add(this.restoreMilestoneBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campaignNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EU4 Savescummer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox campaignNameTextBox;
        private Label label1;
        private Button restoreMilestoneBtn;
        private Button quickSaveMilestoneBtn;
        private System.Windows.Forms.Timer checker;
        private Button startBtn;
        private Button settingsBtn;
        private Button saveNamedMilestoneBtn;
        private Button selectMilestoneBtn;
        private Label savedLbl;
        private Label restoredLbl;
        private Button restartBtn;
        private Label intervalLbl;
    }
}