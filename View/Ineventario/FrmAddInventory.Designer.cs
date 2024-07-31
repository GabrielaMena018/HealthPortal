namespace RegistroPacientes.View.Ineventario
{
    partial class FrmAddInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddInventory));
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PickFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PicImagenMedicamento = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxTId = new System.Windows.Forms.MenuStrip();
            this.PickIngreso = new System.Windows.Forms.DateTimePicker();
            this.PickHora = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateInventory = new CustomPanel.RJButton();
            this.btnAgregarImagen = new CustomPanel.RJButton();
            this.btnAgregarInventario = new CustomPanel.RJButton();
            this.TxtDescripcion = new CustomPanel.BorderRadiusTXT();
            this.TxtCantidadExistencia = new CustomPanel.BorderRadiusTXT();
            this.TxtNombreMedicamento = new CustomPanel.BorderRadiusTXT();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingreso de Inventario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(371, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(249, 32);
            this.label12.TabIndex = 28;
            this.label12.Text = "Fecha de vencimineto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(651, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cantidad en Existencia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(376, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre del Medicamento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PickFechaVencimiento
            // 
            this.PickFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickFechaVencimiento.Location = new System.Drawing.Point(382, 469);
            this.PickFechaVencimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PickFechaVencimiento.Name = "PickFechaVencimiento";
            this.PickFechaVencimiento.Size = new System.Drawing.Size(206, 35);
            this.PickFechaVencimiento.TabIndex = 30;
            this.PickFechaVencimiento.Value = new System.DateTime(2024, 6, 24, 12, 39, 57, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(651, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Hora de Ingreso";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(376, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fecha de ingreso";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(26, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Descripción";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(820, 850);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 32);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(141, 467);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 32);
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // PicImagenMedicamento
            // 
            this.PicImagenMedicamento.Location = new System.Drawing.Point(25, 104);
            this.PicImagenMedicamento.Name = "PicImagenMedicamento";
            this.PicImagenMedicamento.Size = new System.Drawing.Size(328, 346);
            this.PicImagenMedicamento.TabIndex = 5;
            this.PicImagenMedicamento.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(376, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 32);
            this.label7.TabIndex = 41;
            this.label7.Text = "Categoria del Medicamento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(374, 257);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(507, 37);
            this.cmbCategoria.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 857);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 32);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // TxTId
            // 
            this.TxTId.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.TxTId.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TxTId.Location = new System.Drawing.Point(0, 0);
            this.TxTId.Name = "TxTId";
            this.TxTId.Size = new System.Drawing.Size(904, 24);
            this.TxTId.TabIndex = 45;
            this.TxTId.Text = "menuStrip1";
            // 
            // PickIngreso
            // 
            this.PickIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickIngreso.Location = new System.Drawing.Point(382, 357);
            this.PickIngreso.Name = "PickIngreso";
            this.PickIngreso.Size = new System.Drawing.Size(216, 34);
            this.PickIngreso.TabIndex = 46;
            // 
            // PickHora
            // 
            this.PickHora.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.PickHora.Location = new System.Drawing.Point(657, 470);
            this.PickHora.Name = "PickHora";
            this.PickHora.Size = new System.Drawing.Size(205, 34);
            this.PickHora.TabIndex = 47;
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateInventory.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateInventory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnUpdateInventory.BorderRadius = 40;
            this.btnUpdateInventory.BorderSize = 0;
            this.btnUpdateInventory.FlatAppearance.BorderSize = 0;
            this.btnUpdateInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInventory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateInventory.Location = new System.Drawing.Point(522, 847);
            this.btnUpdateInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(165, 49);
            this.btnUpdateInventory.TabIndex = 43;
            this.btnUpdateInventory.Text = "Actualizar";
            this.btnUpdateInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateInventory.TextColor = System.Drawing.Color.Black;
            this.btnUpdateInventory.UseVisualStyleBackColor = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAgregarImagen.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAgregarImagen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnAgregarImagen.BorderRadius = 40;
            this.btnAgregarImagen.BorderSize = 0;
            this.btnAgregarImagen.FlatAppearance.BorderSize = 0;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarImagen.Location = new System.Drawing.Point(32, 457);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(153, 47);
            this.btnAgregarImagen.TabIndex = 38;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarImagen.TextColor = System.Drawing.Color.Black;
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            // 
            // btnAgregarInventario
            // 
            this.btnAgregarInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAgregarInventario.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAgregarInventario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.btnAgregarInventario.BorderRadius = 40;
            this.btnAgregarInventario.BorderSize = 0;
            this.btnAgregarInventario.FlatAppearance.BorderSize = 0;
            this.btnAgregarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarInventario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInventario.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarInventario.Location = new System.Drawing.Point(721, 840);
            this.btnAgregarInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarInventario.Name = "btnAgregarInventario";
            this.btnAgregarInventario.Size = new System.Drawing.Size(141, 49);
            this.btnAgregarInventario.TabIndex = 37;
            this.btnAgregarInventario.Text = "Agregar";
            this.btnAgregarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarInventario.TextColor = System.Drawing.Color.Black;
            this.btnAgregarInventario.UseVisualStyleBackColor = false;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDescripcion.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtDescripcion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtDescripcion.BorderRadius = 20;
            this.TxtDescripcion.BorderSize = 1;
            this.TxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtDescripcion.Location = new System.Drawing.Point(25, 569);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.TxtDescripcion.PasswordChar = false;
            this.TxtDescripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtDescripcion.PlaceholderText = "";
            this.TxtDescripcion.Size = new System.Drawing.Size(856, 248);
            this.TxtDescripcion.TabIndex = 36;
            this.TxtDescripcion.Texts = "";
            this.TxtDescripcion.UnderlinedStyle = false;
            // 
            // TxtCantidadExistencia
            // 
            this.TxtCantidadExistencia.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCantidadExistencia.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtCantidadExistencia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtCantidadExistencia.BorderRadius = 20;
            this.TxtCantidadExistencia.BorderSize = 1;
            this.TxtCantidadExistencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtCantidadExistencia.Location = new System.Drawing.Point(657, 357);
            this.TxtCantidadExistencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCantidadExistencia.Multiline = false;
            this.TxtCantidadExistencia.Name = "TxtCantidadExistencia";
            this.TxtCantidadExistencia.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.TxtCantidadExistencia.PasswordChar = false;
            this.TxtCantidadExistencia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtCantidadExistencia.PlaceholderText = "";
            this.TxtCantidadExistencia.Size = new System.Drawing.Size(205, 47);
            this.TxtCantidadExistencia.TabIndex = 29;
            this.TxtCantidadExistencia.Texts = "";
            this.TxtCantidadExistencia.UnderlinedStyle = false;
            // 
            // TxtNombreMedicamento
            // 
            this.TxtNombreMedicamento.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombreMedicamento.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtNombreMedicamento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNombreMedicamento.BorderRadius = 20;
            this.TxtNombreMedicamento.BorderSize = 1;
            this.TxtNombreMedicamento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtNombreMedicamento.Location = new System.Drawing.Point(375, 153);
            this.TxtNombreMedicamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNombreMedicamento.Multiline = false;
            this.TxtNombreMedicamento.Name = "TxtNombreMedicamento";
            this.TxtNombreMedicamento.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.TxtNombreMedicamento.PasswordChar = false;
            this.TxtNombreMedicamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtNombreMedicamento.PlaceholderText = "";
            this.TxtNombreMedicamento.Size = new System.Drawing.Size(514, 47);
            this.TxtNombreMedicamento.TabIndex = 26;
            this.TxtNombreMedicamento.Texts = "";
            this.TxtNombreMedicamento.UnderlinedStyle = false;
            // 
            // FrmAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(904, 922);
            this.Controls.Add(this.PickHora);
            this.Controls.Add(this.PickIngreso);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdateInventory);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.btnAgregarInventario);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PickFechaVencimiento);
            this.Controls.Add(this.TxtCantidadExistencia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtNombreMedicamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PicImagenMedicamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxTId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.TxTId;
            this.Name = "FrmAddInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddInventory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicImagenMedicamento;
        public CustomPanel.BorderRadiusTXT TxtCantidadExistencia;
        private System.Windows.Forms.Label label12;
        public CustomPanel.BorderRadiusTXT TxtNombreMedicamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public CustomPanel.BorderRadiusTXT TxtDescripcion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        public CustomPanel.RJButton btnAgregarImagen;
        private System.Windows.Forms.Label label7;
        public CustomPanel.RJButton btnAgregarInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        public CustomPanel.RJButton btnUpdateInventory;
        public System.Windows.Forms.DateTimePicker PickFechaVencimiento;
        public System.Windows.Forms.ComboBox cmbCategoria;
        public System.Windows.Forms.MenuStrip TxTId;
        public System.Windows.Forms.DateTimePicker PickIngreso;
        public System.Windows.Forms.DateTimePicker PickHora;
    }
}