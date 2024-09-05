namespace HealthPortal.View.MainPage
{
    partial class FrmMainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReestablishPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.cmsDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 120);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.Location = new System.Drawing.Point(32, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Página Principal";
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteUser,
            this.cmsReestablishPassword,
            this.cmsViewUser,
            this.cmsUpdateUser});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(279, 92);
            // 
            // cmsDeleteUser
            // 
            this.cmsDeleteUser.Name = "cmsDeleteUser";
            this.cmsDeleteUser.Size = new System.Drawing.Size(278, 22);
            this.cmsDeleteUser.Text = "Eliminar Usuario";
            // 
            // cmsReestablishPassword
            // 
            this.cmsReestablishPassword.Name = "cmsReestablishPassword";
            this.cmsReestablishPassword.Size = new System.Drawing.Size(278, 22);
            this.cmsReestablishPassword.Text = "Reestablecer Contraseña";
            // 
            // cmsViewUser
            // 
            this.cmsViewUser.Name = "cmsViewUser";
            this.cmsViewUser.Size = new System.Drawing.Size(278, 22);
            this.cmsViewUser.Text = "Ver Información del Usuario";
            // 
            // cmsUpdateUser
            // 
            this.cmsUpdateUser.Name = "cmsUpdateUser";
            this.cmsUpdateUser.Size = new System.Drawing.Size(278, 22);
            this.cmsUpdateUser.Text = "Actualizar Información del Usuario";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblTime.Location = new System.Drawing.Point(69, 205);
            this.lblTime.Margin = new System.Windows.Forms.Padding(60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(174, 77);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "hora";
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.lblDate.Location = new System.Drawing.Point(75, 180);
            this.lblDate.Margin = new System.Windows.Forms.Padding(60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "fecha";
            // 
            // FrmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1370, 825);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1240, 825);
            this.Name = "FrmMainPage";
            this.Text = "FrmUserAdministration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteUser;
        public System.Windows.Forms.ToolStripMenuItem cmsReestablishPassword;
        public System.Windows.Forms.ToolStripMenuItem cmsViewUser;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateUser;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Timer timerDateTime;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblDate;
    }
}