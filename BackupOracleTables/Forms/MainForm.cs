using System;
using System.Windows.Forms;
using BackupOracleTables.Classes;

namespace BackupOracleTables.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string TextBoxText
        {
            get { return tb_Path.Text; }
            set { tb_Path.Text = value; }
        }

        // when form is shown
        private void MainForm_Shown(object sender, EventArgs e)
        {
            TextBoxText = Properties.Settings.Default.SavePath;
            if (Properties.Settings.Default.SaveAtStart == true)
            {
                if (string.IsNullOrEmpty(TextBoxText))
                {
                    MessageBox.Show("Please select a path first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Database.BackupTables(Properties.Settings.Default.SavePath) == true) // execute backup, check for success
                    {
                        MessageBox.Show("Tables were saved successfully.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error on table backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
            }
        }

        // button - set path
        private void btn_SetPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select a path where your tables should be stored";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.SavePath = fbd.SelectedPath; // refresh path in settings
                    Properties.Settings.Default.Save(); // save settings

                    TextBoxText = Properties.Settings.Default.SavePath; // write new path in textbox
                }
            }
        }

        // button - save tables
        private void btn_SaveTables_Click(object sender, EventArgs e)
        {
            string host = Properties.Settings.Default.host;
            string servicename = Properties.Settings.Default.servicename;
            string port = Properties.Settings.Default.port;
            string userid = Properties.Settings.Default.username;
            string password = Properties.Settings.Default.password;

            if (string.IsNullOrEmpty(TextBoxText))
            {
                MessageBox.Show("Please select a path first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(port) || string.IsNullOrEmpty(servicename) || string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please set a full connection in settings", "Set connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Database.BackupTables(Properties.Settings.Default.SavePath) == true) // execute backup, check for success
                {
                    MessageBox.Show("Tables were saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error on table backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // button - settings
        private void btn_Settings_Click(object sender, EventArgs e)
        {
            new ConfigForm().ShowDialog();
        }

        // button - clear path
        private void btn_Trash_Click(object sender, EventArgs e)
        {
            // reset path in settings
            Properties.Settings.Default.SavePath = string.Empty;
            Properties.Settings.Default.Save();

            // reset textbox text
            TextBoxText = string.Empty;
        }
    }
}
