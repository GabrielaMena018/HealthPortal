﻿namespace HealthPortal.View.InventoryAdministration
{
    partial class FrmAddUpdateCategory
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new CustomControls.RJButton();
            this.btnUpdate = new CustomControls.RJButton();
            this.txtMedicineCategory = new CustomControls.CustomTextBox();
            this.btnExitAddUpdateCategory = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(24, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(418, 56);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Añadir Categoría";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.BackGroundColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.BorderRadius = 30;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(497, 29);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.BackGroundColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.BorderRadius = 30;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(490, 29);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 44);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtMedicineCategory
            // 
            this.txtMedicineCategory.BackColor = System.Drawing.SystemColors.Window;
            this.txtMedicineCategory.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMedicineCategory.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMedicineCategory.BorderRadius = 15;
            this.txtMedicineCategory.BorderSize = 1;
            this.txtMedicineCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMedicineCategory.Location = new System.Drawing.Point(34, 114);
            this.txtMedicineCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMedicineCategory.MaxLength = 50;
            this.txtMedicineCategory.Multiline = false;
            this.txtMedicineCategory.Name = "txtMedicineCategory";
            this.txtMedicineCategory.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtMedicineCategory.PasswordChar = false;
            this.txtMedicineCategory.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedicineCategory.PlaceholderText = "";
            this.txtMedicineCategory.SelectionLength = 0;
            this.txtMedicineCategory.SelectionStart = 0;
            this.txtMedicineCategory.Size = new System.Drawing.Size(570, 47);
            this.txtMedicineCategory.TabIndex = 1;
            this.txtMedicineCategory.Tag = "name";
            this.txtMedicineCategory.Texts = "";
            this.txtMedicineCategory.UnderlinedStyle = false;
            // 
            // btnExitAddUpdateCategory
            // 
            this.btnExitAddUpdateCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitAddUpdateCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitAddUpdateCategory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitAddUpdateCategory.FlatAppearance.BorderSize = 0;
            this.btnExitAddUpdateCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExitAddUpdateCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExitAddUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitAddUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnExitAddUpdateCategory.Image = global::HealthPortal.Properties.Resources.quit;
            this.btnExitAddUpdateCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitAddUpdateCategory.Location = new System.Drawing.Point(648, 24);
            this.btnExitAddUpdateCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitAddUpdateCategory.Name = "btnExitAddUpdateCategory";
            this.btnExitAddUpdateCategory.Size = new System.Drawing.Size(51, 52);
            this.btnExitAddUpdateCategory.TabIndex = 61;
            this.btnExitAddUpdateCategory.TabStop = false;
            this.btnExitAddUpdateCategory.UseVisualStyleBackColor = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 269);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 62;
            this.txtID.Visible = false;
            // 
            // FrmAddUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(724, 297);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnExitAddUpdateCategory);
            this.Controls.Add(this.txtMedicineCategory);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public CustomControls.RJButton btnAdd;
        public CustomControls.RJButton btnUpdate;
        public CustomControls.CustomTextBox txtMedicineCategory;
        public System.Windows.Forms.Button btnExitAddUpdateCategory;
        public System.Windows.Forms.TextBox txtID;
    }
}