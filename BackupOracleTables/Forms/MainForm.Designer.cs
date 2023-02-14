namespace BackupOracleTables.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpBx_SelectPath = new System.Windows.Forms.GroupBox();
            this.btn_SaveTables = new System.Windows.Forms.Button();
            this.btn_SetPath = new System.Windows.Forms.Button();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.btn_Trash = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.grpBx_SelectPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBx_SelectPath
            // 
            this.grpBx_SelectPath.Controls.Add(this.btn_Trash);
            this.grpBx_SelectPath.Controls.Add(this.btn_Settings);
            this.grpBx_SelectPath.Controls.Add(this.btn_SaveTables);
            this.grpBx_SelectPath.Controls.Add(this.btn_SetPath);
            this.grpBx_SelectPath.Controls.Add(this.tb_Path);
            this.grpBx_SelectPath.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBx_SelectPath.Location = new System.Drawing.Point(3, 3);
            this.grpBx_SelectPath.Name = "grpBx_SelectPath";
            this.grpBx_SelectPath.Size = new System.Drawing.Size(317, 78);
            this.grpBx_SelectPath.TabIndex = 1;
            this.grpBx_SelectPath.TabStop = false;
            this.grpBx_SelectPath.Text = "Path";
            // 
            // btn_SaveTables
            // 
            this.btn_SaveTables.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveTables.Location = new System.Drawing.Point(167, 49);
            this.btn_SaveTables.Name = "btn_SaveTables";
            this.btn_SaveTables.Size = new System.Drawing.Size(119, 23);
            this.btn_SaveTables.TabIndex = 2;
            this.btn_SaveTables.Text = "Save tables";
            this.btn_SaveTables.UseVisualStyleBackColor = true;
            this.btn_SaveTables.Click += new System.EventHandler(this.btn_SaveTables_Click);
            // 
            // btn_SetPath
            // 
            this.btn_SetPath.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetPath.Location = new System.Drawing.Point(6, 49);
            this.btn_SetPath.Name = "btn_SetPath";
            this.btn_SetPath.Size = new System.Drawing.Size(159, 23);
            this.btn_SetPath.TabIndex = 1;
            this.btn_SetPath.Text = "Select path and set";
            this.btn_SetPath.UseVisualStyleBackColor = true;
            this.btn_SetPath.Click += new System.EventHandler(this.btn_SetPath_Click);
            // 
            // tb_Path
            // 
            this.tb_Path.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Path.Location = new System.Drawing.Point(7, 20);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(279, 23);
            this.tb_Path.TabIndex = 0;
            // 
            // btn_Trash
            // 
            this.btn_Trash.BackgroundImage = global::BackupOracleTables.Properties.Resources.trash;
            this.btn_Trash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Trash.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trash.Location = new System.Drawing.Point(288, 20);
            this.btn_Trash.Name = "btn_Trash";
            this.btn_Trash.Size = new System.Drawing.Size(23, 23);
            this.btn_Trash.TabIndex = 4;
            this.btn_Trash.UseVisualStyleBackColor = true;
            this.btn_Trash.Click += new System.EventHandler(this.btn_Trash_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackgroundImage = global::BackupOracleTables.Properties.Resources.settings;
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Settings.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.Location = new System.Drawing.Point(288, 49);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(23, 23);
            this.btn_Settings.TabIndex = 3;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 84);
            this.Controls.Add(this.grpBx_SelectPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle Table Backup";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.grpBx_SelectPath.ResumeLayout(false);
            this.grpBx_SelectPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBx_SelectPath;
        private System.Windows.Forms.Button btn_Trash;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_SaveTables;
        private System.Windows.Forms.Button btn_SetPath;
        private System.Windows.Forms.TextBox tb_Path;
    }
}