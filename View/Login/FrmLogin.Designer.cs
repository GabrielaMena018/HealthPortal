namespace RegistroPacientes.View.Login

{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hidepass = new System.Windows.Forms.PictureBox();
            this.lockpic = new System.Windows.Forms.PictureBox();
            this.userpic = new System.Windows.Forms.PictureBox();
            this.checkremember = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtusername = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.Label();
            this.btnLogin = new CustomPanel.RJButton();
            this.BoxUsername = new CustomPanel.BorderRadiusTXT();
            this.BoxPassword = new CustomPanel.BorderRadiusTXT();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidepass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::RegistroPacientes.Properties.Resources.Captura_de_pantalla_2024_07_25_153608;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.hidepass);
            this.panel1.Controls.Add(this.lockpic);
            this.panel1.Controls.Add(this.userpic);
            this.panel1.Controls.Add(this.checkremember);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.BoxUsername);
            this.panel1.Controls.Add(this.BoxPassword);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 420);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // hidepass
            // 
            this.hidepass.BackColor = System.Drawing.Color.White;
            this.hidepass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hidepass.Image = global::RegistroPacientes.Properties.Resources.passwordhide__2_;
            this.hidepass.Location = new System.Drawing.Point(208, 211);
            this.hidepass.Name = "hidepass";
            this.hidepass.Size = new System.Drawing.Size(30, 33);
            this.hidepass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidepass.TabIndex = 19;
            this.hidepass.TabStop = false;
            // 
            // lockpic
            // 
            this.lockpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lockpic.BackColor = System.Drawing.Color.White;
            this.lockpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lockpic.Image = global::RegistroPacientes.Properties.Resources._lock;
            this.lockpic.Location = new System.Drawing.Point(208, 211);
            this.lockpic.Name = "lockpic";
            this.lockpic.Size = new System.Drawing.Size(30, 33);
            this.lockpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockpic.TabIndex = 17;
            this.lockpic.TabStop = false;
            this.lockpic.Click += new System.EventHandler(this.lockpic_Click);
            // 
            // userpic
            // 
            this.userpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userpic.BackColor = System.Drawing.Color.White;
            this.userpic.Image = global::RegistroPacientes.Properties.Resources.user;
            this.userpic.Location = new System.Drawing.Point(208, 148);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(30, 33);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userpic.TabIndex = 16;
            this.userpic.TabStop = false;
            this.userpic.Click += new System.EventHandler(this.userpic_Click);
            // 
            // checkremember
            // 
            this.checkremember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkremember.AutoSize = true;
            this.checkremember.BackColor = System.Drawing.Color.White;
            this.checkremember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkremember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkremember.ForeColor = System.Drawing.Color.Gold;
            this.checkremember.Location = new System.Drawing.Point(170, 257);
            this.checkremember.Name = "checkremember";
            this.checkremember.Size = new System.Drawing.Size(126, 22);
            this.checkremember.TabIndex = 15;
            this.checkremember.Text = "Remember Me";
            this.checkremember.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Location = new System.Drawing.Point(315, 258);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 18);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            // 
            // txtusername
            // 
            this.txtusername.AutoSize = true;
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(205, 127);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(77, 18);
            this.txtusername.TabIndex = 20;
            this.txtusername.Text = "Username";
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.Location = new System.Drawing.Point(205, 190);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(75, 18);
            this.txtpassword.TabIndex = 21;
            this.txtpassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gold;
            this.btnLogin.BackGroundColor = System.Drawing.Color.Gold;
            this.btnLogin.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.BorderRadius = 40;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(233, 314);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.Black;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // BoxUsername
            // 
            this.BoxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.BoxUsername.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BoxUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.BoxUsername.BorderRadius = 0;
            this.BoxUsername.BorderSize = 2;
            this.BoxUsername.Location = new System.Drawing.Point(208, 148);
            this.BoxUsername.Multiline = false;
            this.BoxUsername.Name = "BoxUsername";
            this.BoxUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.BoxUsername.PasswordChar = false;
            this.BoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.BoxUsername.PlaceholderText = "";
            this.BoxUsername.Size = new System.Drawing.Size(221, 33);
            this.BoxUsername.TabIndex = 23;
            this.BoxUsername.Texts = "       Username";
            this.BoxUsername.UnderlinedStyle = false;
            // 
            // BoxPassword
            // 
            this.BoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.BoxPassword.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BoxPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.BoxPassword.BorderRadius = 0;
            this.BoxPassword.BorderSize = 2;
            this.BoxPassword.Location = new System.Drawing.Point(208, 211);
            this.BoxPassword.Multiline = false;
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.BoxPassword.PasswordChar = true;
            this.BoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.BoxPassword.PlaceholderText = "";
            this.BoxPassword.Size = new System.Drawing.Size(221, 33);
            this.BoxPassword.TabIndex = 24;
            this.BoxPassword.Texts = "Password";
            this.BoxPassword.UnderlinedStyle = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 420);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidepass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.CheckBox checkremember;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.PictureBox lockpic;
        public System.Windows.Forms.PictureBox hidepass;
        public System.Windows.Forms.Label txtpassword;
        public System.Windows.Forms.Label txtusername;
        public CustomPanel.BorderRadiusTXT BoxUsername;
        public CustomPanel.BorderRadiusTXT BoxPassword;
        public CustomPanel.RJButton btnLogin;
    }
}