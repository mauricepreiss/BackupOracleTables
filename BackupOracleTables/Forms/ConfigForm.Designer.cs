namespace BackupOracleTables.Forms
{
    partial class ConfigForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.cbx_SaveAtStart = new System.Windows.Forms.CheckBox();
            this.btn_ShowPassword = new System.Windows.Forms.Button();
            this.btn_SetConnection = new System.Windows.Forms.Button();
            this.btn_TestConnection = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Servicename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Host = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cbx_SaveAtStart
            // 
            this.cbx_SaveAtStart.AutoSize = true;
            this.cbx_SaveAtStart.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_SaveAtStart.Location = new System.Drawing.Point(27, 291);
            this.cbx_SaveAtStart.Name = "cbx_SaveAtStart";
            this.cbx_SaveAtStart.Size = new System.Drawing.Size(141, 20);
            this.cbx_SaveAtStart.TabIndex = 27;
            this.cbx_SaveAtStart.Text = "Save on program start";
            this.toolTip.SetToolTip(this.cbx_SaveAtStart, "Sollen die Tabellen beim Start des Programms automatisch gesichert werden?");
            this.cbx_SaveAtStart.UseVisualStyleBackColor = true;
            this.cbx_SaveAtStart.CheckedChanged += new System.EventHandler(this.cbx_SaveAtStart_CheckedChanged);
            // 
            // btn_ShowPassword
            // 
            this.btn_ShowPassword.BackgroundImage = global::BackupOracleTables.Properties.Resources.show_password;
            this.btn_ShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShowPassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowPassword.Location = new System.Drawing.Point(155, 194);
            this.btn_ShowPassword.Name = "btn_ShowPassword";
            this.btn_ShowPassword.Size = new System.Drawing.Size(23, 23);
            this.btn_ShowPassword.TabIndex = 26;
            this.toolTip.SetToolTip(this.btn_ShowPassword, "Passwort anzeigen / verstecken");
            this.btn_ShowPassword.UseVisualStyleBackColor = true;
            this.btn_ShowPassword.Click += new System.EventHandler(this.btn_ShowPassword_Click);
            // 
            // btn_SetConnection
            // 
            this.btn_SetConnection.Enabled = false;
            this.btn_SetConnection.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetConnection.Location = new System.Drawing.Point(12, 259);
            this.btn_SetConnection.Name = "btn_SetConnection";
            this.btn_SetConnection.Size = new System.Drawing.Size(166, 28);
            this.btn_SetConnection.TabIndex = 25;
            this.btn_SetConnection.Text = "Set Connection";
            this.toolTip.SetToolTip(this.btn_SetConnection, "Verbindung speichern");
            this.btn_SetConnection.UseVisualStyleBackColor = true;
            this.btn_SetConnection.Click += new System.EventHandler(this.btn_SetConnection_Click);
            // 
            // btn_TestConnection
            // 
            this.btn_TestConnection.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestConnection.Location = new System.Drawing.Point(12, 224);
            this.btn_TestConnection.Name = "btn_TestConnection";
            this.btn_TestConnection.Size = new System.Drawing.Size(166, 28);
            this.btn_TestConnection.TabIndex = 24;
            this.btn_TestConnection.Text = "Test Connection";
            this.toolTip.SetToolTip(this.btn_TestConnection, "Prüfen, ob mit diesen Daten eine Verbindung aufgebaut werden kann");
            this.btn_TestConnection.UseVisualStyleBackColor = true;
            this.btn_TestConnection.Click += new System.EventHandler(this.btn_TestConnection_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Passwort";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(12, 193);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '•';
            this.tb_Password.Size = new System.Drawing.Size(139, 23);
            this.tb_Password.TabIndex = 22;
            this.toolTip.SetToolTip(this.tb_Password, "Passwort der Verbindung");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Username";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(12, 150);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(166, 23);
            this.tb_Username.TabIndex = 20;
            this.toolTip.SetToolTip(this.tb_Username, "Username der Verbindung");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Servicename";
            // 
            // tb_Servicename
            // 
            this.tb_Servicename.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Servicename.Location = new System.Drawing.Point(12, 107);
            this.tb_Servicename.Name = "tb_Servicename";
            this.tb_Servicename.Size = new System.Drawing.Size(166, 23);
            this.tb_Servicename.TabIndex = 18;
            this.toolTip.SetToolTip(this.tb_Servicename, "ServiceName der Verbindung");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Port";
            // 
            // tb_Port
            // 
            this.tb_Port.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Port.Location = new System.Drawing.Point(12, 64);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(166, 23);
            this.tb_Port.TabIndex = 16;
            this.toolTip.SetToolTip(this.tb_Port, "Port der Verbindung");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Host";
            // 
            // tb_Host
            // 
            this.tb_Host.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Host.Location = new System.Drawing.Point(12, 21);
            this.tb_Host.Name = "tb_Host";
            this.tb_Host.Size = new System.Drawing.Size(166, 23);
            this.tb_Host.TabIndex = 14;
            this.toolTip.SetToolTip(this.tb_Host, "Hostname der Verbindung");
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 315);
            this.Controls.Add(this.cbx_SaveAtStart);
            this.Controls.Add(this.btn_ShowPassword);
            this.Controls.Add(this.btn_SetConnection);
            this.Controls.Add(this.btn_TestConnection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Servicename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Host);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox cbx_SaveAtStart;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btn_ShowPassword;
        private System.Windows.Forms.Button btn_SetConnection;
        private System.Windows.Forms.Button btn_TestConnection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Servicename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Host;
    }
}