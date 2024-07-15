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
            this.TxtCantidadExistencia = new CustomPanel.BorderRadiusTXT();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNombreMedicamento = new CustomPanel.BorderRadiusTXT();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PickFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxTSalida = new CustomPanel.BorderRadiusTXT();
            this.TxTIngreso = new CustomPanel.BorderRadiusTXT();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new CustomPanel.BorderRadiusTXT();
            this.btnAgregarImagen = new CustomPanel.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PicImagenMedicamento = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarInventario = new CustomPanel.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateInventory = new CustomPanel.RJButton();
            this.TxTId = new System.Windows.Forms.MenuStrip();
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
            // TxtCantidadExistencia
            // 
            this.TxtCantidadExistencia.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCantidadExistencia.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtCantidadExistencia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtCantidadExistencia.BorderRadius = 20;
            this.TxtCantidadExistencia.BorderSize = 1;
            this.TxtCantidadExistencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtCantidadExistencia.Location = new System.Drawing.Point(642, 471);
            this.TxtCantidadExistencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCantidadExistencia.Multiline = false;
            this.TxtCantidadExistencia.Name = "TxtCantidadExistencia";
            this.TxtCantidadExistencia.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.TxtCantidadExistencia.PasswordChar = false;
            this.TxtCantidadExistencia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtCantidadExistencia.PlaceholderText = "";
            this.TxtCantidadExistencia.Size = new System.Drawing.Size(250, 47);
            this.TxtCantidadExistencia.TabIndex = 29;
            this.TxtCantidadExistencia.Texts = "";
            this.TxtCantidadExistencia.UnderlinedStyle = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(376, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(249, 32);
            this.label12.TabIndex = 28;
            this.label12.Text = "Fecha de vencimineto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNombreMedicamento
            // 
            this.TxtNombreMedicamento.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombreMedicamento.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtNombreMedicamento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNombreMedicamento.BorderRadius = 20;
            this.TxtNombreMedicamento.BorderSize = 1;
            this.TxtNombreMedicamento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtNombreMedicamento.Location = new System.Drawing.Point(378, 158);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(636, 398);
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
            this.PickFechaVencimiento.Location = new System.Drawing.Point(375, 483);
            this.PickFechaVencimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PickFechaVencimiento.Name = "PickFechaVencimiento";
            this.PickFechaVencimiento.Size = new System.Drawing.Size(250, 35);
            this.PickFechaVencimiento.TabIndex = 30;
            this.PickFechaVencimiento.Value = new System.DateTime(2024, 6, 24, 12, 39, 57, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(636, 562);
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
            this.label5.Location = new System.Drawing.Point(369, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fecha de ingreso";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxTSalida
            // 
            this.TxTSalida.BackColor = System.Drawing.SystemColors.Window;
            this.TxTSalida.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxTSalida.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxTSalida.BorderRadius = 20;
            this.TxTSalida.BorderSize = 1;
            this.TxTSalida.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxTSalida.Location = new System.Drawing.Point(642, 634);
            this.TxTSalida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxTSalida.Multiline = false;
            this.TxTSalida.Name = "TxTSalida";
            this.TxTSalida.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.TxTSalida.PasswordChar = false;
            this.TxTSalida.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxTSalida.PlaceholderText = "";
            this.TxTSalida.Size = new System.Drawing.Size(250, 47);
            this.TxTSalida.TabIndex = 33;
            this.TxTSalida.Texts = "";
            this.TxTSalida.UnderlinedStyle = false;
            // 
            // TxTIngreso
            // 
            this.TxTIngreso.BackColor = System.Drawing.SystemColors.Window;
            this.TxTIngreso.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxTIngreso.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxTIngreso.BorderRadius = 20;
            this.TxTIngreso.BorderSize = 1;
            this.TxTIngreso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxTIngreso.Location = new System.Drawing.Point(375, 634);
            this.TxTIngreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxTIngreso.Multiline = false;
            this.TxTIngreso.Name = "TxTIngreso";
            this.TxTIngreso.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.TxTIngreso.PasswordChar = false;
            this.TxTIngreso.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxTIngreso.PlaceholderText = "";
            this.TxTIngreso.Size = new System.Drawing.Size(250, 47);
            this.TxTIngreso.TabIndex = 34;
            this.TxTIngreso.Texts = "";
            this.TxTIngreso.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(19, 684);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Descripción";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDescripcion.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtDescripcion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtDescripcion.BorderRadius = 20;
            this.TxtDescripcion.BorderSize = 1;
            this.TxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtDescripcion.Location = new System.Drawing.Point(25, 734);
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
            this.btnAgregarImagen.Location = new System.Drawing.Point(25, 633);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(153, 47);
            this.btnAgregarImagen.TabIndex = 38;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarImagen.TextColor = System.Drawing.Color.Black;
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(839, 1027);
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
            this.pictureBox4.Location = new System.Drawing.Point(134, 643);
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
            this.PicImagenMedicamento.Size = new System.Drawing.Size(328, 522);
            this.PicImagenMedicamento.TabIndex = 5;
            this.PicImagenMedicamento.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(376, 248);
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
            this.cmbCategoria.Location = new System.Drawing.Point(382, 316);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(507, 37);
            this.cmbCategoria.TabIndex = 42;
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
            this.btnAgregarInventario.Location = new System.Drawing.Point(740, 1017);
            this.btnAgregarInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarInventario.Name = "btnAgregarInventario";
            this.btnAgregarInventario.Size = new System.Drawing.Size(141, 49);
            this.btnAgregarInventario.TabIndex = 37;
            this.btnAgregarInventario.Text = "Agregar";
            this.btnAgregarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarInventario.TextColor = System.Drawing.Color.Black;
            this.btnAgregarInventario.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(671, 1027);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 32);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
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
            this.btnUpdateInventory.Location = new System.Drawing.Point(548, 1017);
            this.btnUpdateInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(165, 49);
            this.btnUpdateInventory.TabIndex = 43;
            this.btnUpdateInventory.Text = "Actualizar";
            this.btnUpdateInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateInventory.TextColor = System.Drawing.Color.Black;
            this.btnUpdateInventory.UseVisualStyleBackColor = false;
            // 
            // TxTId
            // 
            this.TxTId.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.TxTId.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TxTId.Location = new System.Drawing.Point(0, 0);
            this.TxTId.Name = "TxTId";
            this.TxTId.Size = new System.Drawing.Size(904, 32);
            this.TxTId.TabIndex = 45;
            this.TxTId.Text = "menuStrip1";
            // 
            // FrmAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 1079);
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
            this.Controls.Add(this.TxTIngreso);
            this.Controls.Add(this.TxTSalida);
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
            this.MainMenuStrip = this.TxTId;
            this.Name = "FrmAddInventory";
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
        public CustomPanel.BorderRadiusTXT TxTSalida;
        public CustomPanel.BorderRadiusTXT TxTIngreso;
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
    }
}