namespace HealthPortal.View.Settings
{
    partial class FrmServerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCustom1 = new CustomPanel.PanelCustom();
            this.grpLocalConfig = new System.Windows.Forms.GroupBox();
            this.pnlAuth = new System.Windows.Forms.Panel();
            this.txtPassword = new CustomPanel.BorderRadiusTXT();
            this.txtSQLAuth = new CustomPanel.BorderRadiusTXT();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpConnectionInfo = new System.Windows.Forms.GroupBox();
            this.txtDataBase = new CustomPanel.BorderRadiusTXT();
            this.txtServerURL = new CustomPanel.BorderRadiusTXT();
            this.btnSaveConfig = new CustomPanel.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCustom1.SuspendLayout();
            this.grpLocalConfig.SuspendLayout();
            this.pnlAuth.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grpConnectionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 120);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(41, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(32, 39, 32, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(457, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Configuración de Servidor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelCustom1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Margin = new System.Windows.Forms.Padding(48, 0, 48, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 528);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveConfig);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 528);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 528);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelCustom1
            // 
            this.panelCustom1.BackColor = System.Drawing.Color.White;
            this.panelCustom1.BorderRadius = 30;
            this.panelCustom1.Controls.Add(this.grpLocalConfig);
            this.panelCustom1.Controls.Add(this.grpConnectionInfo);
            this.panelCustom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustom1.ForeColor = System.Drawing.Color.Black;
            this.panelCustom1.GradientAngle = 90F;
            this.panelCustom1.GradientBottomColor = System.Drawing.Color.White;
            this.panelCustom1.GradientTopColor = System.Drawing.Color.White;
            this.panelCustom1.Location = new System.Drawing.Point(400, 0);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(634, 528);
            this.panelCustom1.TabIndex = 6;
            // 
            // grpLocalConfig
            // 
            this.grpLocalConfig.Controls.Add(this.pnlAuth);
            this.grpLocalConfig.Controls.Add(this.panel5);
            this.grpLocalConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLocalConfig.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpLocalConfig.Location = new System.Drawing.Point(33, 279);
            this.grpLocalConfig.Margin = new System.Windows.Forms.Padding(30, 15, 30, 30);
            this.grpLocalConfig.Name = "grpLocalConfig";
            this.grpLocalConfig.Size = new System.Drawing.Size(571, 219);
            this.grpLocalConfig.TabIndex = 7;
            this.grpLocalConfig.TabStop = false;
            this.grpLocalConfig.Text = "Configuración local";
            // 
            // pnlAuth
            // 
            this.pnlAuth.Controls.Add(this.txtPassword);
            this.pnlAuth.Controls.Add(this.txtSQLAuth);
            this.pnlAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAuth.Location = new System.Drawing.Point(236, 19);
            this.pnlAuth.Name = "pnlAuth";
            this.pnlAuth.Size = new System.Drawing.Size(332, 197);
            this.pnlAuth.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 18;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPassword.Location = new System.Drawing.Point(66, 113);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(66, 20, 66, 20);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.White;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 38);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Texts = "Contraseña";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtSQLAuth
            // 
            this.txtSQLAuth.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtSQLAuth.BackColor = System.Drawing.SystemColors.Window;
            this.txtSQLAuth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSQLAuth.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSQLAuth.BorderRadius = 18;
            this.txtSQLAuth.BorderSize = 2;
            this.txtSQLAuth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtSQLAuth.Location = new System.Drawing.Point(66, 46);
            this.txtSQLAuth.Margin = new System.Windows.Forms.Padding(66, 20, 66, 20);
            this.txtSQLAuth.MaxLength = 50;
            this.txtSQLAuth.Multiline = false;
            this.txtSQLAuth.Name = "txtSQLAuth";
            this.txtSQLAuth.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.txtSQLAuth.PasswordChar = false;
            this.txtSQLAuth.PlaceholderColor = System.Drawing.Color.White;
            this.txtSQLAuth.PlaceholderText = "";
            this.txtSQLAuth.Size = new System.Drawing.Size(200, 38);
            this.txtSQLAuth.TabIndex = 3;
            this.txtSQLAuth.Texts = "Autenticación SQL";
            this.txtSQLAuth.UnderlinedStyle = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.rdoFalse);
            this.panel5.Controls.Add(this.rdoTrue);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(3, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 197);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "de Windows";
            // 
            // rdoFalse
            // 
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoFalse.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFalse.Location = new System.Drawing.Point(54, 134);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(88, 20);
            this.rdoFalse.TabIndex = 7;
            this.rdoFalse.Text = "Deshabilitar";
            this.rdoFalse.UseVisualStyleBackColor = true;
            // 
            // rdoTrue
            // 
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.Checked = true;
            this.rdoTrue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoTrue.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTrue.Location = new System.Drawing.Point(54, 107);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(70, 20);
            this.rdoTrue.TabIndex = 6;
            this.rdoTrue.TabStop = true;
            this.rdoTrue.Text = "Habilitar";
            this.rdoTrue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seguridad integrada";
            // 
            // grpConnectionInfo
            // 
            this.grpConnectionInfo.Controls.Add(this.txtDataBase);
            this.grpConnectionInfo.Controls.Add(this.txtServerURL);
            this.grpConnectionInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConnectionInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpConnectionInfo.Location = new System.Drawing.Point(33, 30);
            this.grpConnectionInfo.Margin = new System.Windows.Forms.Padding(30);
            this.grpConnectionInfo.Name = "grpConnectionInfo";
            this.grpConnectionInfo.Size = new System.Drawing.Size(571, 219);
            this.grpConnectionInfo.TabIndex = 5;
            this.grpConnectionInfo.TabStop = false;
            this.grpConnectionInfo.Text = "Conexión con la base de datos";
            // 
            // txtDataBase
            // 
            this.txtDataBase.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataBase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtDataBase.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDataBase.BorderRadius = 18;
            this.txtDataBase.BorderSize = 2;
            this.txtDataBase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtDataBase.Location = new System.Drawing.Point(23, 128);
            this.txtDataBase.Margin = new System.Windows.Forms.Padding(20);
            this.txtDataBase.MaxLength = 128;
            this.txtDataBase.Multiline = false;
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Padding = new System.Windows.Forms.Padding(30, 25, 25, 25);
            this.txtDataBase.PasswordChar = false;
            this.txtDataBase.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataBase.PlaceholderText = "";
            this.txtDataBase.Size = new System.Drawing.Size(525, 68);
            this.txtDataBase.TabIndex = 2;
            this.txtDataBase.Texts = "Nombre de la base de datos";
            this.txtDataBase.UnderlinedStyle = false;
            // 
            // txtServerURL
            // 
            this.txtServerURL.BackColor = System.Drawing.SystemColors.Window;
            this.txtServerURL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtServerURL.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtServerURL.BorderRadius = 18;
            this.txtServerURL.BorderSize = 2;
            this.txtServerURL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtServerURL.Location = new System.Drawing.Point(23, 39);
            this.txtServerURL.Margin = new System.Windows.Forms.Padding(20);
            this.txtServerURL.MaxLength = 255;
            this.txtServerURL.Multiline = false;
            this.txtServerURL.Name = "txtServerURL";
            this.txtServerURL.Padding = new System.Windows.Forms.Padding(30, 25, 25, 25);
            this.txtServerURL.PasswordChar = false;
            this.txtServerURL.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtServerURL.PlaceholderText = "";
            this.txtServerURL.Size = new System.Drawing.Size(525, 68);
            this.txtServerURL.TabIndex = 1;
            this.txtServerURL.Texts = "URL del servidor";
            this.txtServerURL.UnderlinedStyle = false;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.Color.White;
            this.btnSaveConfig.BackGroundColor = System.Drawing.Color.White;
            this.btnSaveConfig.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSaveConfig.BorderRadius = 30;
            this.btnSaveConfig.BorderSize = 0;
            this.btnSaveConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveConfig.FlatAppearance.BorderSize = 0;
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSaveConfig.Location = new System.Drawing.Point(202, 49);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(10);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Padding = new System.Windows.Forms.Padding(5);
            this.btnSaveConfig.Size = new System.Drawing.Size(163, 72);
            this.btnSaveConfig.TabIndex = 5;
            this.btnSaveConfig.TabStop = false;
            this.btnSaveConfig.Text = "Guardar configuración";
            this.btnSaveConfig.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            // 
            // FrmServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1090, 705);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(986, 705);
            this.Name = "FrmServerSettings";
            this.Text = "FrmUserAdministration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCustom1.ResumeLayout(false);
            this.grpLocalConfig.ResumeLayout(false);
            this.pnlAuth.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.grpConnectionInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.GroupBox grpLocalConfig;
        public System.Windows.Forms.GroupBox grpConnectionInfo;
        public CustomPanel.PanelCustom panelCustom1;
        public CustomPanel.BorderRadiusTXT txtServerURL;
        public CustomPanel.BorderRadiusTXT txtDataBase;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public CustomPanel.BorderRadiusTXT txtPassword;
        public CustomPanel.BorderRadiusTXT txtSQLAuth;
        public CustomPanel.RJButton btnSaveConfig;
        public System.Windows.Forms.Panel pnlAuth;
        public System.Windows.Forms.RadioButton rdoFalse;
        public System.Windows.Forms.RadioButton rdoTrue;
    }
}