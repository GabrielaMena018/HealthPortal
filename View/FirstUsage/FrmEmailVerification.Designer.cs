namespace HealthPortal.View.FirstUsage
{
    partial class FrmEmailVerification
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
            this.txtConfirmationCode = new CustomPanel.BorderRadiusTXT();
            this.btnConfirmEmail = new CustomPanel.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Confirmación de Correo";
            // 
            // txtConfirmationCode
            // 
            this.txtConfirmationCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmationCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtConfirmationCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConfirmationCode.BorderRadius = 18;
            this.txtConfirmationCode.BorderSize = 2;
            this.txtConfirmationCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmationCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtConfirmationCode.Location = new System.Drawing.Point(21, 94);
            this.txtConfirmationCode.Margin = new System.Windows.Forms.Padding(20);
            this.txtConfirmationCode.Multiline = false;
            this.txtConfirmationCode.Name = "txtConfirmationCode";
            this.txtConfirmationCode.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtConfirmationCode.PasswordChar = false;
            this.txtConfirmationCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConfirmationCode.PlaceholderText = "";
            this.txtConfirmationCode.Size = new System.Drawing.Size(441, 38);
            this.txtConfirmationCode.TabIndex = 9;
            this.txtConfirmationCode.Texts = "Código de Confirmación";
            this.txtConfirmationCode.UnderlinedStyle = false;
            // 
            // btnConfirmEmail
            // 
            this.btnConfirmEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnConfirmEmail.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnConfirmEmail.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirmEmail.BorderRadius = 30;
            this.btnConfirmEmail.BorderSize = 0;
            this.btnConfirmEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmEmail.FlatAppearance.BorderSize = 0;
            this.btnConfirmEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnConfirmEmail.Location = new System.Drawing.Point(324, 155);
            this.btnConfirmEmail.Margin = new System.Windows.Forms.Padding(176, 3, 20, 20);
            this.btnConfirmEmail.Name = "btnConfirmEmail";
            this.btnConfirmEmail.Size = new System.Drawing.Size(170, 40);
            this.btnConfirmEmail.TabIndex = 15;
            this.btnConfirmEmail.Text = "Confirmar Correo";
            this.btnConfirmEmail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnConfirmEmail.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ingrese el código de confirmación que ha sido enviado a su correo";
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.White;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::HealthPortal.Properties.Resources.quit;
            this.picExit.Location = new System.Drawing.Point(479, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(32, 32);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 17;
            this.picExit.TabStop = false;
            this.picExit.WaitOnLoad = true;
            // 
            // FrmEmailVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 224);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmEmail);
            this.Controls.Add(this.txtConfirmationCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmailVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmailVerification";
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public CustomPanel.BorderRadiusTXT txtConfirmationCode;
        public CustomPanel.RJButton btnConfirmEmail;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox picExit;
    }
}