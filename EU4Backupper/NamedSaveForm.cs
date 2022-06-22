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
    public partial class NamedSaveForm : Form
    {
        public NamedSaveForm()
        {
            InitializeComponent();
        }

        private void NamedSaveForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = DateTime.Now.ToString().Replace('/', '-');
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Go();
        }

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Go();
            }
        }

        void Go()
        {
            if (nameBox.Text != "" &&
                !File.Exists("./" + Globals.campaignName + "/Milestones/" + nameBox.Text + ".eu4"))
            {
                if(Globals.SaveMilestone(nameBox.Text))
                    DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Error!", "Invalid Milestone Name!");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}