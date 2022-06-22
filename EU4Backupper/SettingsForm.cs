using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EU4Backupper
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void autoStartCB_CheckedChanged(object sender, EventArgs e)
        {
            Globals.autoStart = AutoStartCB.Checked;
            Globals.Save();
        }

        private void autoRebootCheck_CheckedChanged(object sender, EventArgs e)
        {
            Globals.autoReboot = autoRebootCheck.Checked;
            Globals.Save();
        }

        private void openScumFolderBtn_Click(object sender, EventArgs e)
        {
            string loc = Path.GetFullPath("./Backups/" + Globals.campaignName);
            Process.Start("explorer.exe", loc);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            AutoStartCB.Checked = Globals.autoStart;
            autoRebootCheck.Checked = Globals.autoReboot;
            saveFolderTB.Text = Globals.saveGameLocation;
            exeBox.Text = Globals.gameExe;
            SaveInterval.Value = Globals.autoSaveInterval;
            UpdateIntervalLbl();
        }

        private void SelectSaveFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();
            if(result == DialogResult.OK) Globals.saveGameLocation = dialog.SelectedPath;
            saveFolderTB.Text = Globals.saveGameLocation;
            Globals.Save();
        }

        private void saveFolderTB_TextChanged(object sender, EventArgs e)
        {
            Globals.saveGameLocation = saveFolderTB.Text;
            Globals.Save();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectExeBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.FileName = Globals.gameExe;
            dialog.DefaultExt = "exe";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK) Globals.gameExe = dialog.FileName;
            exeBox.Text = Globals.gameExe;
            Globals.Save();
        }

        private void exeBox_TextChanged(object sender, EventArgs e)
        {
            Globals.gameExe = exeBox.Text;
            Globals.Save();
        }

        void UpdateIntervalLbl()
        {
            autosaveIntervalLbl.Text = SaveInterval.Value switch
            {
                0 => "1 min",
                1 => "5 min",
                2 => "10 min",
                3 => "15 min",
                4 => "30 min"
            };
        }

        private void SaveInterval_Scroll(object sender, EventArgs e)
        {
            Globals.autoSaveInterval = SaveInterval.Value;
            Globals.Save();
            UpdateIntervalLbl();
        }
    }
}