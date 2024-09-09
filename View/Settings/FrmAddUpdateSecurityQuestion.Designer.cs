namespace HealthPortal.View.Settings
{
    partial class FrmAddUpdateSecurityQuestion
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
            this.txtQuestion = new CustomControls.CustomTextBox();
            this.btnConfirmQuestion = new CustomControls.RJButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Añadir Pregunta de Seguridad";
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuestion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtQuestion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtQuestion.BorderRadius = 18;
            this.txtQuestion.BorderSize = 2;
            this.txtQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.txtQuestion.Location = new System.Drawing.Point(29, 86);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(20);
            this.txtQuestion.MaxLength = 32767;
            this.txtQuestion.Multiline = false;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Padding = new System.Windows.Forms.Padding(20, 15, 15, 15);
            this.txtQuestion.PasswordChar = false;
            this.txtQuestion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuestion.PlaceholderText = "";
            this.txtQuestion.Size = new System.Drawing.Size(524, 57);
            this.txtQuestion.TabIndex = 9;
            this.txtQuestion.Texts = "Pregunta";
            this.txtQuestion.UnderlinedStyle = false;
            // 
            // btnConfirmQuestion
            // 
            this.btnConfirmQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnConfirmQuestion.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnConfirmQuestion.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirmQuestion.BorderRadius = 30;
            this.btnConfirmQuestion.BorderSize = 0;
            this.btnConfirmQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmQuestion.FlatAppearance.BorderSize = 0;
            this.btnConfirmQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnConfirmQuestion.Location = new System.Drawing.Point(387, 173);
            this.btnConfirmQuestion.Margin = new System.Windows.Forms.Padding(10);
            this.btnConfirmQuestion.Name = "btnConfirmQuestion";
            this.btnConfirmQuestion.Size = new System.Drawing.Size(176, 32);
            this.btnConfirmQuestion.TabIndex = 15;
            this.btnConfirmQuestion.TabStop = false;
            this.btnConfirmQuestion.Text = "Confirmar Pregunta";
            this.btnConfirmQuestion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnConfirmQuestion.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExit.Location = new System.Drawing.Point(536, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 17;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // FrmAddUpdateSecurityQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 224);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirmQuestion);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUpdateSecurityQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmailVerification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public CustomControls.CustomTextBox txtQuestion;
        public CustomControls.RJButton btnConfirmQuestion;
        public System.Windows.Forms.Button btnExit;
    }
}