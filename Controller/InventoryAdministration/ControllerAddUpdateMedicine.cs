using System;
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

namespace HealthPortal.Controller.InventoryAdministration
{
    internal class ControllerAddUpdateMedicine
    {
        FrmAddUpdateMedicine frmAddUpdateMedicine;
        private int action;
        private string medicineCategory;
        /// <summary>
        /// Constructor para la inserción de medicamentos
        /// </summary>
        /// <param name="vista"></param>
        /// <param name="accion"></param>
        public ControllerAddUpdateMedicine(FrmAddUpdateMedicine vista, int action)
        {
            frmAddUpdateMedicine = vista;
            this.action = action;
            frmAddUpdateMedicine.Load += new EventHandler(InitialLoad);

            //Metodos que se ejecutan cuando el programa esta cargando
            CheckAction();

            //Metodos que se ejecutan al ocurrir eventos
            frmAddUpdateMedicine.btnAddInventory.Click += new EventHandler(RegisterNewMedicine);
            frmAddUpdateMedicine.btnAddImage.Click += new EventHandler(AddImage);
        }
        public ControllerAddUpdateMedicine(FrmAddUpdateMedicine vista, int action, int id, string medicineName, string medicineCategory, DateTime expirationDate, string stock, DateTime entryDate, DateTime exit, string description)
        {
            //Acciones iniciales
            frmAddUpdateMedicine = vista;
            this.action = action;
            this.medicineCategory = medicineCategory;
            //Metodos iniciales ejecutados cuando el formulario esta cargando
            frmAddUpdateMedicine.Load += new EventHandler(InitialLoad);
            CheckAction();
            ChargeValues(id, medicineName, medicineCategory, expirationDate, stock, entryDate, exit, description);

            //Metodos que se ejecutan al ocurrir eventos
            frmAddUpdateMedicine.btnUpdateInventory.Click += new EventHandler(UpdateInventory);
            frmAddUpdateMedicine.btnAddImage.Click += new EventHandler(AddImage);
        }
        private void AddImage(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "archivos de imagenes (*. png; *.jpg)| *.png ; *jpg";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                frmAddUpdateMedicine.picImage.Image = Image.FromFile(openImage.FileName);
                frmAddUpdateMedicine.picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public void InitialLoad(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminInventory
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();

            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombosInventario
            DataSet ds = daoInventoryAdministration.FillCombo();
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
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();
            //Datos para la creacion de un nuevo inventario
            daoInventoryAdministration.NombreMedicamento = frmAddUpdateMedicine.txtMedicineName.Texts.Trim();
            daoInventoryAdministration.Descripcion = frmAddUpdateMedicine.txtDescription.Texts.Trim();
            daoInventoryAdministration.IdCategoria = int.Parse(frmAddUpdateMedicine.cmbCategory.SelectedValue.ToString());
            daoInventoryAdministration.FechaVencimiento = frmAddUpdateMedicine.dtpExpirationDate.Value.Date;
            daoInventoryAdministration.Existencia = int.Parse(frmAddUpdateMedicine.numStock.Text.Trim());
            daoInventoryAdministration.Envases = 1;
            daoInventoryAdministration.Ingreso = frmAddUpdateMedicine.dtpEntryDate.Value.Date;
            daoInventoryAdministration.Salida = frmAddUpdateMedicine.dtpEntryTime.Value.ToString("HH:mm");
            MemoryStream memoryStream = new MemoryStream();
            Image img = frmAddUpdateMedicine.picImage.Image;
            if (frmAddUpdateMedicine.txtMedicineName.Texts == "" || frmAddUpdateMedicine.dtpExpirationDate.Value.Date <= vencimiento || int.Parse(frmAddUpdateMedicine.numStock.Text) == 0 || frmAddUpdateMedicine.picImage.Image == null)
            {
                MessageBox.Show("La fecha de vencimiento debe de ser de 31 días despues de la fecha de hoy, la cantidad de medicamentos ingreados no es valida o hay campos vacios dentro del formulario, favor revisar de nuevo el ingreso de datos para continuar la inserción", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                img.Save(memoryStream, img.RawFormat);
                daoInventoryAdministration.Imagen = memoryStream.ToArray();
                int returnedValue = daoInventoryAdministration.RegisterMedicine();
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
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();
            daoInventoryAdministration.IdMedicamento = int.Parse(frmAddUpdateMedicine.txtID.Text.Trim());
            daoInventoryAdministration.NombreMedicamento = frmAddUpdateMedicine.txtMedicineName.Texts.Trim();
            daoInventoryAdministration.IdCategoria = int.Parse(frmAddUpdateMedicine.cmbCategory.SelectedValue.ToString());
            daoInventoryAdministration.FechaVencimiento = frmAddUpdateMedicine.dtpExpirationDate.Value.Date;
            daoInventoryAdministration.Existencia = int.Parse(frmAddUpdateMedicine.numStock.Text.Trim());
            daoInventoryAdministration.Ingreso = frmAddUpdateMedicine.dtpEntryDate.Value.Date;
            daoInventoryAdministration.Salida = frmAddUpdateMedicine.dtpEntryTime.Value.ToString("HH:mm");
            daoInventoryAdministration.Descripcion = frmAddUpdateMedicine.txtDescription.Texts.Trim();

            int returnedValue = daoInventoryAdministration.UpdateInventory();
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
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();
            daoInventoryAdministration.IdMedicamento = id;
            MemoryStream memoryStream = new MemoryStream(daoInventoryAdministration.GetImageBytes());
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