namespace EU4Backupper
{
    partial class SelectBackupForm
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
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.buListBox = new System.Windows.Forms.ListBox();
            this.autoRadio = new System.Windows.Forms.RadioButton();
            this.mileStoneRadio = new System.Windows.Forms.RadioButton();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(310, 324);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(112, 34);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "Restore";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(310, 364);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 34);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // buListBox
            // 
            this.buListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buListBox.FormattingEnabled = true;
            this.buListBox.IntegralHeight = false;
            this.buListBox.ItemHeight = 25;
            this.buListBox.Location = new System.Drawing.Point(12, 12);
            this.buListBox.Name = "buListBox";
            this.buListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.buListBox.Size = new System.Drawing.Size(292, 386);
            this.buListBox.TabIndex = 2;
            this.buListBox.SelectedIndexChanged += new System.EventHandler(this.buListBox_SelectedIndexChanged);
            // 
            // autoRadio
            // 
            this.autoRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoRadio.AutoSize = true;
            this.autoRadio.Location = new System.Drawing.Point(310, 12);
            this.autoRadio.Name = "autoRadio";
            this.autoRadio.Size = new System.Drawing.Size(76, 29);
            this.autoRadio.TabIndex = 3;
            this.autoRadio.TabStop = true;
            this.autoRadio.Text = "Auto";
            this.autoRadio.UseVisualStyleBackColor = true;
            this.autoRadio.CheckedChanged += new System.EventHandler(this.autoRadio_CheckedChanged);
            // 
            // mileStoneRadio
            // 
            this.mileStoneRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mileStoneRadio.AutoSize = true;
            this.mileStoneRadio.Location = new System.Drawing.Point(310, 47);
            this.mileStoneRadio.Name = "mileStoneRadio";
            this.mileStoneRadio.Size = new System.Drawing.Size(122, 29);
            this.mileStoneRadio.TabIndex = 4;
            this.mileStoneRadio.TabStop = true;
            this.mileStoneRadio.Text = "Milestones";
            this.mileStoneRadio.UseVisualStyleBackColor = true;
            this.mileStoneRadio.CheckedChanged += new System.EventHandler(this.mileStoneRadio_CheckedChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(310, 204);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 34);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Location = new System.Drawing.Point(310, 123);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(112, 71);
            this.timeLabel.TabIndex = 6;
            // 
            // SelectBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 410);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.mileStoneRadio);
            this.Controls.Add(this.autoRadio);
            this.Controls.Add(this.buListBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Name = "SelectBackupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backups";
            this.Load += new System.EventHandler(this.SelectBackupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button okBtn;
        private Button cancelBtn;
        private ListBox buListBox;
        private RadioButton autoRadio;
        private RadioButton mileStoneRadio;
        private Button deleteBtn;
        private Label timeLabel;
    }
}