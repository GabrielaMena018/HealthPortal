﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using HealthPortal.Model.DAO;
using HealthPortal.View.InventoryAdministration;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using HealthPortal.Helper;
using HealthPortal.Properties;

namespace HealthPortal.Controller.InventoryAdministration
{
    internal class ControllerAddUpdateMedicine
    {
        FrmAddUpdateMedicine frmAddUpdateMedicine;
        private int action;
        private string medicineCategory;
        private Dictionary<string, Tuple<Bitmap, Bitmap>> imageMapping;
        /// <summary>
        /// Constructor para la inserción de medicamentos
        /// </summary>
        /// <param name="view"></param>
        /// <param name="accion"></param>
        public ControllerAddUpdateMedicine(FrmAddUpdateMedicine view, int action)
        {
            frmAddUpdateMedicine = view;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            this.action = action;
            frmAddUpdateMedicine.Load += new EventHandler(InitialLoad);

            //Metodos que se ejecutan cuando el programa esta cargando
            CheckAction();

            //Metodos que se ejecutan al ocurrir eventos
            frmAddUpdateMedicine.btnAddInventory.Click += new EventHandler(RegisterNewMedicine);
            frmAddUpdateMedicine.btnAddImage.Click += new EventHandler(AddImage);

            frmAddUpdateMedicine.txtMedicineName.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateMedicine.txtDescription.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            frmAddUpdateMedicine.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateMedicine.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);

            frmAddUpdateMedicine.btnExit.Click += new EventHandler(CloseForm);
        }
        public ControllerAddUpdateMedicine(FrmAddUpdateMedicine view, int action, int id, string medicineName, string medicineCategory, DateTime expirationDate, string stock, DateTime entryDate, DateTime exit, string description)
        {
            //Acciones iniciales
            frmAddUpdateMedicine = view;

            imageMapping = new Dictionary<string, Tuple<Bitmap, Bitmap>>()
            {
                { "btnExit", Tuple.Create(Resources.quit, Resources.hoverQuit) }
            };

            this.action = action;
            this.medicineCategory = medicineCategory;
            //Metodos iniciales ejecutados cuando el formulario esta cargando
            frmAddUpdateMedicine.Load += new EventHandler(InitialLoad);
            CheckAction();
            ChargeValues(id, medicineName, medicineCategory, expirationDate, stock, entryDate, exit, description);

            //Metodos que se ejecutan al ocurrir eventos
            frmAddUpdateMedicine.btnUpdateInventory.Click += new EventHandler(UpdateInventory);
            frmAddUpdateMedicine.btnAddImage.Click += new EventHandler(AddImage);

            frmAddUpdateMedicine.txtMedicineName.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);
            frmAddUpdateMedicine.txtDescription.KeyPress += new KeyPressEventHandler(CommonMethods.TextBoxKeyPress);

            frmAddUpdateMedicine.btnExit.MouseEnter += new EventHandler(MouseEnterPictureButton);
            frmAddUpdateMedicine.btnExit.MouseLeave += new EventHandler(MouseLeavePictureButton);

            frmAddUpdateMedicine.btnExit.Click += new EventHandler(CloseForm);
        }
        private void CloseForm(object sender, EventArgs e)
        {
            frmAddUpdateMedicine.Dispose();
        }
        private void MouseEnterPictureButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item2;
                btn.ForeColor = Color.FromArgb(31, 43, 91);
            }
        }
        private void MouseLeavePictureButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && imageMapping.ContainsKey(btn.Name))
            {
                btn.Image = imageMapping[btn.Name].Item1;
                btn.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
        private void AddImage(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "archivos de imagenes (*. png; *.jpg)| *.png ; *jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                frmAddUpdateMedicine.picImage.Image = Image.FromFile(ofd.FileName);
                frmAddUpdateMedicine.picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public void InitialLoad(object sender, EventArgs e)
        {
            CommonMethods.EnableFormDrag(frmAddUpdateMedicine, frmAddUpdateMedicine);
            //Objeto de la clase DAOAdminInventory
            DAOInventoryAdministration dao = new DAOInventoryAdministration();

            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombosInventario
            DataSet ds = dao.FillCombo();
            //Llenar comboBox de la tabla tbCategoriaMedicamento
            frmAddUpdateMedicine.cmbCategory.DataSource = ds.Tables["tbCategoriaMedicamento"];
            frmAddUpdateMedicine.cmbCategory.ValueMember = "idCategoriaMedicamento";
            frmAddUpdateMedicine.cmbCategory.DisplayMember = "categoriaMedicamento";
            frmAddUpdateMedicine.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (action == 2)
            {
                frmAddUpdateMedicine.cmbCategory.Text = medicineCategory;
            }
        }
        public void RegisterNewMedicine(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            DateTime vencimiento = fecha.AddDays(31);
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            //Datos para la creacion de un nuevo inventario
            dao.NombreMedicamento = frmAddUpdateMedicine.txtMedicineName.Texts.Trim();
            dao.Descripcion = frmAddUpdateMedicine.txtDescription.Texts.Trim();
            dao.IdCategoria = int.Parse(frmAddUpdateMedicine.cmbCategory.SelectedValue.ToString());
            dao.FechaVencimiento = frmAddUpdateMedicine.dtpExpirationDate.Value.Date;
            dao.Existencia = int.Parse(frmAddUpdateMedicine.numStock.Text.Trim());
            dao.Envases = 1;
            dao.Ingreso = frmAddUpdateMedicine.dtpEntryDate.Value.Date;
            dao.Salida = frmAddUpdateMedicine.dtpEntryTime.Value.ToString("HH:mm");
            MemoryStream memoryStream = new MemoryStream();
            Image img = frmAddUpdateMedicine.picImage.Image;
            if (frmAddUpdateMedicine.txtMedicineName.Texts == "" || frmAddUpdateMedicine.dtpExpirationDate.Value.Date <= vencimiento || int.Parse(frmAddUpdateMedicine.numStock.Text) == 0 || frmAddUpdateMedicine.picImage.Image == null)
            {
                MessageBox.Show("La fecha de vencimiento debe de ser de 31 días despues de la fecha de hoy, la cantidad de medicamentos ingreados no es valida o hay campos vacios dentro del formulario, favor revisar de nuevo el ingreso de datos para continuar la inserción", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img.Save(memoryStream, img.RawFormat);
                dao.Imagen = memoryStream.ToArray();
                int returnedValue = dao.RegisterMedicine();
                if (returnedValue == 2)
                {
                    MessageBox.Show("Los datos han sido registrados exitosamente",
                                                             "Proceso completado",
                                                             MessageBoxButtons.OK,
                                                      MessageBoxIcon.Information);
                    if (MessageBox.Show("Desea ingresar un nuevo medicamento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                                                                                                             == DialogResult.Yes)
                    {
                        frmAddUpdateMedicine.Close();
                        FrmAddUpdateMedicine openForm = new FrmAddUpdateMedicine(1);
                        openForm.ShowDialog();

                    }
                    else
                    {
                        frmAddUpdateMedicine.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser registrados", "Proceso Interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public void UpdateInventory(object sender, EventArgs e)
        {
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            dao.IdMedicamento = int.Parse(frmAddUpdateMedicine.txtID.Text.Trim());
            dao.NombreMedicamento = frmAddUpdateMedicine.txtMedicineName.Texts.Trim();
            dao.IdCategoria = int.Parse(frmAddUpdateMedicine.cmbCategory.SelectedValue.ToString());
            dao.FechaVencimiento = frmAddUpdateMedicine.dtpExpirationDate.Value.Date;
            dao.Existencia = int.Parse(frmAddUpdateMedicine.numStock.Text.Trim());
            dao.Ingreso = frmAddUpdateMedicine.dtpEntryDate.Value.Date;
            dao.Salida = frmAddUpdateMedicine.dtpEntryTime.Value.ToString("HH:mm");
            dao.Descripcion = frmAddUpdateMedicine.txtDescription.Texts.Trim();

            int returnedValue = dao.UpdateInventory();
            if (returnedValue == 2)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (returnedValue == 1)
            {

                MessageBox.Show("Los datos no pudieron ser actualizados completamente",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void ChargeValues(int id, string medicineName, string medicineCategory, DateTime expirationDate, string stock, DateTime entryDate, DateTime exit, string description)
        {
            DAOInventoryAdministration dao = new DAOInventoryAdministration();
            dao.IdMedicamento = id;
            MemoryStream memoryStream = new MemoryStream(dao.GetImageBytes());
            frmAddUpdateMedicine.txtID.Text = id.ToString();
            frmAddUpdateMedicine.txtMedicineName.Texts = medicineName;
            frmAddUpdateMedicine.cmbCategory.Text = medicineCategory;
            frmAddUpdateMedicine.dtpExpirationDate.Value = expirationDate;
            frmAddUpdateMedicine.numStock.Text = stock;
            frmAddUpdateMedicine.dtpEntryDate.Value = entryDate;
            frmAddUpdateMedicine.dtpEntryTime.Value = exit;
            frmAddUpdateMedicine.txtDescription.Texts = description;
            frmAddUpdateMedicine.picImage.Image = Image.FromStream(memoryStream);
        }

        public void CheckAction()
        {
            if (action == 1)
            {
                frmAddUpdateMedicine.btnAddInventory.Enabled = true;
                frmAddUpdateMedicine.btnUpdateInventory.Enabled = false;
                frmAddUpdateMedicine.txtMedicineName.Text = "Nombre del Medicamento";
                frmAddUpdateMedicine.txtMedicineName.Enter += new EventHandler(EnterTxtMedicineName);
                frmAddUpdateMedicine.txtMedicineName.Leave += new EventHandler(LeaveTxtMedicineName);
            }
            else if (action == 2)
            {
                frmAddUpdateMedicine.lblTitle.Text = "Actualización de Inventario";
                frmAddUpdateMedicine.btnAddInventory.Enabled = false;
                frmAddUpdateMedicine.btnUpdateInventory.Enabled = true;
                frmAddUpdateMedicine.btnAddImage.Text = "Actualizar";
                frmAddUpdateMedicine.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else if (action == 3)
            {
                frmAddUpdateMedicine.lblTitle.Text = "Ficha de Inventario";
                frmAddUpdateMedicine.btnAddInventory.Visible = false;
                frmAddUpdateMedicine.btnUpdateInventory.Visible = false;
                frmAddUpdateMedicine.txtID.Visible = false;
                frmAddUpdateMedicine.txtMedicineName.Enabled = false;
                frmAddUpdateMedicine.txtMedicineName.BackColor = Color.White;
                frmAddUpdateMedicine.txtDescription.Enabled = false;
                frmAddUpdateMedicine.txtDescription.BackColor = Color.White;
                frmAddUpdateMedicine.dtpExpirationDate.Enabled = false;
                frmAddUpdateMedicine.dtpExpirationDate.CalendarTitleBackColor = Color.White;
                frmAddUpdateMedicine.dtpEntryTime.Enabled = false;
                frmAddUpdateMedicine.dtpEntryTime.CalendarTitleBackColor = Color.White;
                frmAddUpdateMedicine.dtpEntryDate.Enabled = false;
                frmAddUpdateMedicine.dtpEntryDate.CalendarTitleBackColor = Color.White;
                frmAddUpdateMedicine.numStock.Enabled = false;
                frmAddUpdateMedicine.numStock.BackColor = Color.White;
                frmAddUpdateMedicine.btnAddImage.Visible = false;
                frmAddUpdateMedicine.cmbCategory.Enabled = false;
                frmAddUpdateMedicine.cmbCategory.BackColor = Color.White;

            }
        }

        public void EnterTxtMedicineName(object sender, EventArgs e)
        {
            if (frmAddUpdateMedicine.txtMedicineName.Texts.Trim().Equals("Nombre del medicamento"))
            {
                frmAddUpdateMedicine.txtMedicineName.Clear();
                frmAddUpdateMedicine.BackColor = Color.White;
                frmAddUpdateMedicine.lblName.Visible = true;
            }
        }

        public void LeaveTxtMedicineName(object sender, EventArgs e)
        {
            if (frmAddUpdateMedicine.txtMedicineName.Texts.Trim().Equals(" "))
            {
                frmAddUpdateMedicine.txtMedicineName.Texts = "Tato";
                frmAddUpdateMedicine.txtMedicineName.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
    }
}