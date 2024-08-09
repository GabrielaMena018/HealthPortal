namespace HealthPortal.View.Login
{
    partial class FrmPasswordChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreviousPassword = new CustomPanel.BorderRadiusTXT();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPassword = new CustomPanel.BorderRadiusTXT();
            this.txtNewPasswordConfirmation = new CustomPanel.BorderRadiusTXT();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangePassword = new CustomPanel.RJButton();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cambio de contraseña";
            // 
            // txtPreviousPassword
            // 
            this.txtPreviousPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPreviousPassword.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPreviousPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPreviousPassword.BorderRadius = 15;
            this.txtPreviousPassword.BorderSize = 1;
            this.txtPreviousPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPreviousPassword.Location = new System.Drawing.Point(21, 109);
            this.txtPreviousPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPreviousPassword.Multiline = false;
            this.txtPreviousPassword.Name = "txtPreviousPassword";
            this.txtPreviousPassword.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPreviousPassword.PasswordChar = false;
            this.txtPreviousPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPreviousPassword.PlaceholderText = "";
            this.txtPreviousPassword.Size = new System.Drawing.Size(343, 32);
            this.txtPreviousPassword.TabIndex = 27;
            this.txtPreviousPassword.Texts = "";
            this.txtPreviousPassword.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Contraseña antigua";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(17, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contraseña nueva";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPassword.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNewPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewPassword.BorderRadius = 15;
            this.txtNewPassword.BorderSize = 1;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(21, 187);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewPassword.Multiline = false;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNewPassword.PasswordChar = false;
            this.txtNewPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.PlaceholderText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(343, 32);
            this.txtNewPassword.TabIndex = 30;
            this.txtNewPassword.Texts = "";
            this.txtNewPassword.UnderlinedStyle = false;
            // 
            // txtNewPasswordConfirmation
            // 
            this.txtNewPasswordConfirmation.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPasswordConfirmation.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNewPasswordConfirmation.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewPasswordConfirmation.BorderRadius = 15;
            this.txtNewPasswordConfirmation.BorderSize = 1;
            this.txtNewPasswordConfirmation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPasswordConfirmation.Location = new System.Drawing.Point(21, 265);
            this.txtNewPasswordConfirmation.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewPasswordConfirmation.Multiline = false;
            this.txtNewPasswordConfirmation.Name = "txtNewPasswordConfirmation";
            this.txtNewPasswordConfirmation.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNewPasswordConfirmation.PasswordChar = false;
            this.txtNewPasswordConfirmation.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPasswordConfirmation.PlaceholderText = "";
            this.txtNewPasswordConfirmation.Size = new System.Drawing.Size(343, 32);
            this.txtNewPasswordConfirmation.TabIndex = 32;
            this.txtNewPasswordConfirmation.Texts = "";
            this.txtNewPasswordConfirmation.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(17, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Confirmar contraseña nueva";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnChangePassword.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnChangePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnChangePassword.BorderRadius = 40;
            this.btnChangePassword.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Location = new System.Drawing.Point(148, 337);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(10);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(257, 45);
            this.btnChangePassword.TabIndex = 39;
            this.btnChangePassword.Text = "Confirmar cambio de contraseña";
            this.btnChangePassword.TextColor = System.Drawing.Color.Black;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.White;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::HealthPortal.Properties.Resources.quit;
            this.picExit.Location = new System.Drawing.Point(30, 342);
            this.picExit.Margin = new System.Windows.Forms.Padding(5);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(32, 32);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 40;
            this.picExit.TabStop = false;
            this.picExit.WaitOnLoad = true;
            // 
            // FrmPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtNewPasswordConfirmation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreviousPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPasswordChange";
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public CustomPanel.BorderRadiusTXT txtPreviousPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public CustomPanel.BorderRadiusTXT txtNewPassword;
        public CustomPanel.BorderRadiusTXT txtNewPasswordConfirmation;
        private System.Windows.Forms.Label label4;
        public CustomPanel.RJButton btnChangePassword;
        public System.Windows.Forms.PictureBox picExit;
    }
}