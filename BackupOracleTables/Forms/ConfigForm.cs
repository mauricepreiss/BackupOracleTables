using System;
using System.Windows.Forms;
using BackupOracleTables.Classes;

namespace BackupOracleTables.Forms
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        // on form loading
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tb_Host.Text = Properties.Settings.Default.host;
            tb_Port.Text = Properties.Settings.Default.port;
            tb_Servicename.Text = Properties.Settings.Default.servicename;
            tb_Username.Text = Properties.Settings.Default.username;
            tb_Password.Text = Common.DecryptText(Properties.Settings.Default.password);

            if (Properties.Settings.Default.SaveAtStart == true)
                cbx_SaveAtStart.Checked = true;
            else
                cbx_SaveAtStart.Checked = false;
        }

        // button - test connection
        private void btn_TestConnection_Click(object sender, EventArgs e)
        {
            string host = tb_Host.Text;
            string port = tb_Port.Text;
            string servicename = tb_Servicename.Text;
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            if (Database.CheckForConnection(host, port, servicename, username, password) == true)
            {
                MessageBox.Show("The connection was successfully established", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_SetConnection.Enabled = true;
            }
            else
            {
                MessageBox.Show("No connection could be established. Please check your login details.", "Connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_SetConnection.Enabled = false;
            }
        }

        // button - set connection
        private void btn_SetConnection_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.host = tb_Host.Text;
            Properties.Settings.Default.port = tb_Port.Text;
            Properties.Settings.Default.servicename = tb_Servicename.Text;
            Properties.Settings.Default.username = tb_Username.Text;
            Properties.Settings.Default.password = Common.EncryptText(tb_Password.Text);
            Properties.Settings.Default.Save();

            MessageBox.Show("The connection was set.", "Connection set", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // button - show password
        private void btn_ShowPassword_Click(object sender, EventArgs e)
        {
            char passwordchar = tb_Password.PasswordChar;

            if (passwordchar == '•')
                tb_Password.PasswordChar = '\0';
            else
                tb_Password.PasswordChar = '•';
        }

        // checkbox - save at start
        private void cbx_SaveAtStart_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_SaveAtStart.Checked)
            {
                Properties.Settings.Default.SaveAtStart = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.SaveAtStart = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
