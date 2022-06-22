using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EU4Backupper
{
    public partial class SelectBackupForm : Form
    {
        bool _auto;

        public SelectBackupForm(bool auto)
        {
            InitializeComponent();

            _auto = auto;
        }

        private void SelectBackupForm_Load(object sender, EventArgs e)
        {
            if (_auto) autoRadio.Checked = true;
            else mileStoneRadio.Checked = true;
            LoadFiles();
        }

        string folder;
        void LoadFiles()
        {
            folder = "./Backups/" + Globals.campaignName + "/" + (_auto ? "Auto/" : "Milestones/");
            buListBox.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(folder);
            if (dir.Exists)
            {
                var files = dir.GetFiles().OrderByDescending(f => f.LastWriteTime);
                buListBox.Items.AddRange(files.Select(f => Path.GetFileNameWithoutExtension(f.Name)).ToArray());
            }
        }

        private void mileStoneRadio_CheckedChanged(object sender, EventArgs e)
        {
            _auto = autoRadio.Checked;
            LoadFiles();
        }

        private void autoRadio_CheckedChanged(object sender, EventArgs e)
        {
            _auto = autoRadio.Checked;
            LoadFiles();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (Selected != "")
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Abort;
            Close();
        }

        public string Selected = "";
        private void buListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buListBox.SelectedItems.Count != 0)
            {
                Selected = folder + buListBox.SelectedItem.ToString() + ".eu4";
                timeLabel.Text = File.GetCreationTime(Selected).ToString();
            }
            else
            {
                Selected = "";
                timeLabel.Text = "";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            folder = "./Backups/" + Globals.campaignName + "/" + (_auto ? "Auto/" : "Milestones/");
            List<string> selected = new List<string>();
            foreach (string file in buListBox.SelectedItems)
            {
                selected.Add(file);
            }
            foreach (string file in selected)
            {
                File.Delete(folder + "/" + file + ".eu4");
                buListBox.Items.Remove(file);
            }
        }
    }
}
