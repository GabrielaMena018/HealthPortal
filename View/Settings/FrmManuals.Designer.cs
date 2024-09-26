namespace HealthPortal.View.Settings
{
    partial class FrmManuals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManuals));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDowland1 = new CustomControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDowland2 = new CustomControls.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manual Técnico";
            // 
            // btnDowland1
            // 
            this.btnDowland1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDowland1.BackColor = System.Drawing.Color.LightBlue;
            this.btnDowland1.BackGroundColor = System.Drawing.Color.LightBlue;
            this.btnDowland1.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnDowland1.BorderRadius = 40;
            this.btnDowland1.BorderSize = 0;
            this.btnDowland1.FlatAppearance.BorderSize = 0;
            this.btnDowland1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDowland1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDowland1.ForeColor = System.Drawing.Color.Black;
            this.btnDowland1.Location = new System.Drawing.Point(18, 46);
            this.btnDowland1.Name = "btnDowland1";
            this.btnDowland1.Size = new System.Drawing.Size(175, 40);
            this.btnDowland1.TabIndex = 10;
            this.btnDowland1.Text = "Descarga";
            this.btnDowland1.TextColor = System.Drawing.Color.Black;
            this.btnDowland1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Manual del usuario";
            // 
            // btnDowland2
            // 
            this.btnDowland2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDowland2.BackColor = System.Drawing.Color.LightBlue;
            this.btnDowland2.BackGroundColor = System.Drawing.Color.LightBlue;
            this.btnDowland2.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnDowland2.BorderRadius = 40;
            this.btnDowland2.BorderSize = 0;
            this.btnDowland2.FlatAppearance.BorderSize = 0;
            this.btnDowland2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDowland2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDowland2.ForeColor = System.Drawing.Color.Black;
            this.btnDowland2.Location = new System.Drawing.Point(18, 147);
            this.btnDowland2.Name = "btnDowland2";
            this.btnDowland2.Size = new System.Drawing.Size(175, 40);
            this.btnDowland2.TabIndex = 12;
            this.btnDowland2.Text = "Descarga";
            this.btnDowland2.TextColor = System.Drawing.Color.Black;
            this.btnDowland2.UseVisualStyleBackColor = false;
            // 
            // FrmManuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 243);
            this.Controls.Add(this.btnDowland2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDowland1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManuals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manuales del sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RJButton btnDowland1;
        private System.Windows.Forms.Label label2;
        public CustomControls.RJButton btnDowland2;
    }
}