﻿using System.Drawing;
using System.Drawing.Text;
using HealthPortal.Helper;

namespace HealthPortal.View.Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel5 = new System.Windows.Forms.Panel();
            this.picHidePassword = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picTestConnection = new System.Windows.Forms.PictureBox();
            this.btnLogin = new CustomPanel.RJButton();
            this.llbForgotPassword = new System.Windows.Forms.LinkLabel();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.picShowPassword = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.txtPassword = new CustomPanel.BorderRadiusTXT();
            this.txtUsername = new CustomPanel.BorderRadiusTXT();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTestConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.picHidePassword);
            this.panel5.Controls.Add(this.picExit);
            this.panel5.Controls.Add(this.picTestConnection);
            this.panel5.Controls.Add(this.btnLogin);
            this.panel5.Controls.Add(this.llbForgotPassword);
            this.panel5.Controls.Add(this.chkRememberMe);
            this.panel5.Controls.Add(this.picShowPassword);
            this.panel5.Controls.Add(this.picUsername);
            this.panel5.Controls.Add(this.txtPassword);
            this.panel5.Controls.Add(this.txtUsername);
            this.panel5.Location = new System.Drawing.Point(82, 108);
            this.panel5.Margin = new System.Windows.Forms.Padding(82, 108, 82, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(556, 563);
            this.panel5.TabIndex = 5;
            // 
            // picHidePassword
            // 
            this.picHidePassword.BackColor = System.Drawing.Color.White;
            this.picHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHidePassword.Image = global::HealthPortal.Properties.Resources.hide32;
            this.picHidePassword.Location = new System.Drawing.Point(115, 286);
            this.picHidePassword.Name = "picHidePassword";
            this.picHidePassword.Size = new System.Drawing.Size(32, 32);
            this.picHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHidePassword.TabIndex = 12;
            this.picHidePassword.TabStop = false;
            this.picHidePassword.WaitOnLoad = true;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.White;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(431, 469);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(32, 32);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 11;
            this.picExit.TabStop = false;
            this.picExit.WaitOnLoad = true;
            // 
            // picTestConnection
            // 
            this.picTestConnection.BackColor = System.Drawing.Color.White;
            this.picTestConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picTestConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTestConnection.Image = ((System.Drawing.Image)(resources.GetObject("picTestConnection.Image")));
            this.picTestConnection.Location = new System.Drawing.Point(93, 469);
            this.picTestConnection.Name = "picTestConnection";
            this.picTestConnection.Size = new System.Drawing.Size(32, 32);
            this.picTestConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTestConnection.TabIndex = 10;
            this.picTestConnection.TabStop = false;
            this.picTestConnection.WaitOnLoad = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnLogin.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnLogin.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.BorderRadius = 30;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnLogin.Location = new System.Drawing.Point(176, 443);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(176, 3, 176, 111);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(204, 58);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // llbForgotPassword
            // 
            this.llbForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.llbForgotPassword.AutoSize = true;
            this.llbForgotPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.llbForgotPassword.Location = new System.Drawing.Point(302, 349);
            this.llbForgotPassword.Name = "llbForgotPassword";
            this.llbForgotPassword.Size = new System.Drawing.Size(161, 17);
            this.llbForgotPassword.TabIndex = 8;
            this.llbForgotPassword.TabStop = true;
            this.llbForgotPassword.Text = "¿Olvidó su contraseña?";
            this.llbForgotPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.chkRememberMe.Checked = true;
            this.chkRememberMe.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRememberMe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.chkRememberMe.Location = new System.Drawing.Point(93, 348);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(179, 21);
            this.chkRememberMe.TabIndex = 7;
            this.chkRememberMe.Text = "¿Guardar información?";
            this.chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // picShowPassword
            // 
            this.picShowPassword.BackColor = System.Drawing.Color.White;
            this.picShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("picShowPassword.Image")));
            this.picShowPassword.Location = new System.Drawing.Point(115, 286);
            this.picShowPassword.Name = "picShowPassword";
            this.picShowPassword.Size = new System.Drawing.Size(32, 32);
            this.picShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowPassword.TabIndex = 5;
            this.picShowPassword.TabStop = false;
            this.picShowPassword.Visible = false;
            this.picShowPassword.WaitOnLoad = true;
            // 
            // picUsername
            // 
            this.picUsername.BackColor = System.Drawing.Color.White;
            this.picUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUsername.Image = ((System.Drawing.Image)(resources.GetObject("picUsername.Image")));
            this.picUsername.InitialImage = ((System.Drawing.Image)(resources.GetObject("picUsername.InitialImage")));
            this.picUsername.Location = new System.Drawing.Point(115, 163);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(32, 35);
            this.picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsername.TabIndex = 4;
            this.picUsername.TabStop = false;
            this.picUsername.WaitOnLoad = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 20;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtPassword.Location = new System.Drawing.Point(93, 269);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(93, 3, 93, 3);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(80, 20, 20, 20);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(370, 66);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Texts = "Contraseña";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsername.BorderRadius = 20;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtUsername.Location = new System.Drawing.Point(93, 149);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(93, 3, 93, 3);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(80, 20, 20, 20);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(370, 66);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Texts = "Usuario";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HealthPortal.Properties.Resources.loginInterface;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.panel5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTestConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public CustomPanel.BorderRadiusTXT txtUsername;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox picUsername;
        public CustomPanel.BorderRadiusTXT txtPassword;
        public CustomPanel.RJButton btnLogin;
        public System.Windows.Forms.PictureBox picTestConnection;
        public System.Windows.Forms.PictureBox picExit;
        public System.Windows.Forms.PictureBox picShowPassword;
        public System.Windows.Forms.PictureBox picHidePassword;
        public System.Windows.Forms.CheckBox chkRememberMe;
        public System.Windows.Forms.LinkLabel llbForgotPassword;
    }
}