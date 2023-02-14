namespace BackupOracleTables.Forms
{
    partial class WaitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitForm));
            this.label1 = new System.Windows.Forms.Label();
            this.picBx_Loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bitte warten... Tabellen werden gesichert.";
            // 
            // picBx_Loading
            // 
            this.picBx_Loading.Image = global::BackupOracleTables.Properties.Resources.loading_animation;
            this.picBx_Loading.Location = new System.Drawing.Point(271, -2);
            this.picBx_Loading.Name = "picBx_Loading";
            this.picBx_Loading.Size = new System.Drawing.Size(48, 48);
            this.picBx_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBx_Loading.TabIndex = 5;
            this.picBx_Loading.TabStop = false;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 45);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBx_Loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaitForm";
            this.Text = "Saving...";
            ((System.ComponentModel.ISupportInitialize)(this.picBx_Loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBx_Loading;
    }
}