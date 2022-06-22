namespace EU4Backupper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Select();
            Directory.CreateDirectory("./Backups");

            Globals.Load();
            UpdateInterval();
            campaignNameTextBox.Text = Globals.campaignName;
            StartStop();
        }

        void UpdateInterval()
        {
            checker.Interval = Globals.autoSaveInterval switch
            {
                0 => 60000,
                1 => 300000,
                2 => 600000,
                3 => 900000,
                4 => 1800000
            };
            UpdateIntervalLbl();
        }

        void UpdateIntervalLbl()
        {
            intervalLbl.Text = Globals.autoSaveInterval switch
            {
                0 => "1 min",
                1 => "5 min",
                2 => "10 min",
                3 => "15 min",
                4 => "30 min"
            };
        }

        private void StartStop()
        {
            if (Globals.running)
            {
                checker.Start();
                startBtn.Text = "Stop Auto";
                startBtn.BackColor = Color.FromArgb(192, 255, 192);
            }
            else
            {
                checker.Stop();
                startBtn.Text = "Start Auto";
                startBtn.BackColor = Color.FromArgb(255, 192, 192);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Globals.running = !Globals.running;
            StartStop();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
            UpdateInterval();
        }

        private void quickSaveMilestoneBtn_Click(object sender, EventArgs e)
        {
            bool succes = Globals.SaveMilestone();
            Task.Run(() => NotifySaved(succes));
        }

        private void campaignNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Globals.campaignName = campaignNameTextBox.Text;
            Globals.Save();
        }

        private void saveNamedMilestoneBtn_Click(object sender, EventArgs e)
        {
            NamedSaveForm sf = new NamedSaveForm();

            bool succes = sf.ShowDialog() == DialogResult.OK;
            Task.Run(() => NotifySaved(succes));
        }

        Task NotifySaved(bool succes)
        {
            this.Invoke(() =>
            {
                if (succes) { savedLbl.Text = "Saved!"; savedLbl.ForeColor = Color.Green; }
                else { savedLbl.Text = "Failed!"; savedLbl.ForeColor = Color.Red; }
                savedLbl.Visible = true;
            });
            Thread.Sleep(2500);
            this.Invoke(() => { savedLbl.Visible = false; });
            return Task.CompletedTask;
        }

        Task NotifyRestored(bool succes)
        {
            this.Invoke(() =>
            {
                if (succes) { restoredLbl.Text = "Restored!"; restoredLbl.ForeColor = Color.Green; }
                else { restoredLbl.Text = "Failed!"; restoredLbl.ForeColor = Color.Red; }
                restoredLbl.Visible = true;
            });
            Thread.Sleep(2500);
            this.Invoke(() => { restoredLbl.Visible = false; });
            return Task.CompletedTask;
        }

        private void restoreMilestoneBtn_Click(object sender, EventArgs e)
        {
            bool succes = Globals.RestoreLastMilestone();
            Task.Run(() => NotifyRestored(succes));
            if (succes && Globals.autoReboot) Globals.RestartGame();
        }

        private void selectMilestoneBtn_Click(object sender, EventArgs e)
        {
            SelectBackupForm sbf = new SelectBackupForm(false);
            var res = sbf.ShowDialog();
            if (res == DialogResult.Cancel) return;
            bool succes = res == DialogResult.OK && Globals.Restore(sbf.Selected);
            Task.Run(() => NotifyRestored(succes));
            if (succes && Globals.autoReboot) Globals.RestartGame();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Globals.RestartGame();
            restoredLbl.Select();
        }

        private void checker_Tick(object sender, EventArgs e)
        {
            Globals.AutoBackup();
        }
    }
}