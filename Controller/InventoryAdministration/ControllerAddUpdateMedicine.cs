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
        FrmInventoryAdministration objInventoryAdministration = new FrmInventoryAdministration();
        FrmAddUpdateMedicine objAddUpdateMedicine;
        private int action;
        private string medicineCategory;
        /// <summary>
        /// Constructor para la inserción de medicamentos
        /// </summary>
        /// <param name="vista"></param>
        /// <param name="accion"></param>
        public ControllerAddUpdateMedicine(FrmAddUpdateMedicine vista, int action)
        {
            objAddUpdateMedicine = vista;
            this.action = action;
            objAddUpdateMedicine.Load += new EventHandler(InitialCharge);

            //Metodos que se ejecutan cuando el programa esta cargando
            CheckAction();

            //Metodos que se ejecutan al ocurrir eventos
            objAddUpdateMedicine.btnAddInventory.Click += new EventHandler(RegisterNewMedicine);
            objAddUpdateMedicine.btnAddImage.Click += new EventHandler(AddImage);
        }

        public void RollBackRegisterMedicine()
        {
            objAddUpdateMedicine.btnAddInventory.Click += new EventHandler(RegisterNewMedicine);
        }

        /// <summary>
        /// Constructor para actualizar datos
        /// </summary>
        /// <param name="vista"></param>
        /// <param name="accion"></param>
        /// <param name="id"></param>
        /// <param name="nameMedicment"></param>
        /// <param name="categoryMedicment"></param>
        /// <param name="expirationDate"></param>
        /// <param name="stock"></param>
        /// <param name="income"></param>
        /// <param name="exit"></param>
        /// <param name="description"></param>

        public ControllerAddUpdateMedicine(FrmAddUpdateMedicine vista, int action, int id, string medicineName, string medicineCategory, DateTime expirationDate, string stock, DateTime entryDate, DateTime exit, string description)
        {
            //Acciones iniciales
            objAddUpdateMedicine = vista;
            this.action = action;
            this.medicineCategory = medicineCategory;
            //Metodos iniciales ejecutados cuando el formulario esta cargando
            objAddUpdateMedicine.Load += new EventHandler(InitialCharge);
            CheckAction();
            ChargeValues(id, medicineName, medicineCategory, expirationDate, stock, entryDate, exit, description);

            //Metodos que se ejecutan al ocurrir eventos
            objAddUpdateMedicine.btnUpdateInventory.Click += new EventHandler(UpdateInventory);
            objAddUpdateMedicine.btnAddImage.Click += new EventHandler(AddImage);
        }
        private void AddImage(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "archivos de imagenes (*. png; *.jpg)| *.png ; *jpg";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                objAddUpdateMedicine.picImage.Image = Image.FromFile(openImage.FileName);
                objAddUpdateMedicine.picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public void InitialCharge(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminInventory
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();

            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombosInventario
            DataSet ds = daoInventoryAdministration.FillCombo();
            //Llenar comboBox de la tabla tbCategoriaMedicamento
            objAddUpdateMedicine.cmbCategory.DataSource = ds.Tables["tbCategoriaMedicamento"];
            objAddUpdateMedicine.cmbCategory.ValueMember = "idCategoriaMedicamento";
            objAddUpdateMedicine.cmbCategory.DisplayMember = "categoriaMedicamento";
            objAddUpdateMedicine.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (action == 2)
            {
                objAddUpdateMedicine.cmbCategory.Text = medicineCategory;
            }
        }

        public void RegisterNewMedicine(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            DateTime vencimiento = fecha.AddDays(31);
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();
            //Datos para la creacion de un nuevo inventario
            daoInventoryAdministration.NombreMedicamento = objAddUpdateMedicine.txtMedicineName.Texts.Trim();
            daoInventoryAdministration.Descripcion = objAddUpdateMedicine.txtDescription.Texts.Trim();
            daoInventoryAdministration.IdCategoria = int.Parse(objAddUpdateMedicine.cmbCategory.SelectedValue.ToString());
            daoInventoryAdministration.FechaVencimiento = objAddUpdateMedicine.dtpExpirationDate.Value.Date;
            daoInventoryAdministration.Existencia = int.Parse(objAddUpdateMedicine.numStock.Text.Trim());
            daoInventoryAdministration.Envases = 1;
            daoInventoryAdministration.Ingreso = objAddUpdateMedicine.dtpEntryDate.Value.Date;
            daoInventoryAdministration.Salida = objAddUpdateMedicine.dtpEntryTime.Value.ToString("HH:mm");
            MemoryStream memoryStream = new MemoryStream();
            Image img = objAddUpdateMedicine.picImage.Image;
            if (objAddUpdateMedicine.txtMedicineName.Texts == "" || objAddUpdateMedicine.dtpExpirationDate.Value.Date <= vencimiento || int.Parse(objAddUpdateMedicine.numStock.Text) == 0 || objAddUpdateMedicine.picImage.Image == null)
            {
                MessageBox.Show("La fecha de vencimineto debe de ser de 31 dias despues de la fecha de hoy, la cantidad de medicamentos ingreados no es valida o hay campos vacios dentro del formulario, favor revisar de nuevo el ingreso de datos para continuar la inserción", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        objAddUpdateMedicine.Close();
                        FrmAddUpdateMedicine openForm = new FrmAddUpdateMedicine(1);
                        openForm.ShowDialog();

                    }
                    else
                    {
                        objAddUpdateMedicine.Close();
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
            daoInventoryAdministration.IdMedicamento = int.Parse(objAddUpdateMedicine.txtID.Text.Trim());
            daoInventoryAdministration.NombreMedicamento = objAddUpdateMedicine.txtMedicineName.Texts.Trim();
            daoInventoryAdministration.IdCategoria = int.Parse(objAddUpdateMedicine.cmbCategory.SelectedValue.ToString());
            daoInventoryAdministration.FechaVencimiento = objAddUpdateMedicine.dtpExpirationDate.Value.Date;
            daoInventoryAdministration.Existencia = int.Parse(objAddUpdateMedicine.numStock.Text.Trim());
            daoInventoryAdministration.Ingreso = objAddUpdateMedicine.dtpEntryDate.Value.Date;
            daoInventoryAdministration.Salida = objAddUpdateMedicine.dtpEntryTime.Value.ToString("HH:mm");
            daoInventoryAdministration.Descripcion = objAddUpdateMedicine.txtDescription.Texts.Trim();

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
            objAddUpdateMedicine.txtID.Text = id.ToString();
            objAddUpdateMedicine.txtMedicineName.Texts = medicineName;
            objAddUpdateMedicine.cmbCategory.Text = medicineCategory;
            objAddUpdateMedicine.dtpExpirationDate.Value = expirationDate;
            objAddUpdateMedicine.numStock.Text = stock;
            objAddUpdateMedicine.dtpEntryDate.Value = entryDate;
            objAddUpdateMedicine.dtpEntryTime.Value = exit;
            objAddUpdateMedicine.txtDescription.Texts = description;
            objAddUpdateMedicine.picImage.Image = Image.FromStream(memoryStream);
        }

        public void CheckAction()
        {
            if (action == 1)
            {
                objAddUpdateMedicine.btnAddInventory.Enabled = true;
                objAddUpdateMedicine.btnUpdateInventory.Enabled = false;
                objAddUpdateMedicine.txtMedicineName.Text = "Nombre del Medicamento";
                objAddUpdateMedicine.txtMedicineName.Enter += new EventHandler(EnterTxtMedicineName);
                objAddUpdateMedicine.txtMedicineName.Leave += new EventHandler(LeaveTxtMedicineName);
            }
            else if (action == 2)
            {
                objAddUpdateMedicine.lblTitle.Text = "Actualización de Inventario";
                objAddUpdateMedicine.btnAddInventory.Enabled = false;
                objAddUpdateMedicine.btnUpdateInventory.Enabled = true;
                objAddUpdateMedicine.btnAddImage.Text = "Actualizar";
                objAddUpdateMedicine.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else if (action == 3)
            {
                objAddUpdateMedicine.lblTitle.Text = "Ficha de Inventario";
                objAddUpdateMedicine.btnAddInventory.Visible = false;
                objAddUpdateMedicine.btnUpdateInventory.Visible = false;
                objAddUpdateMedicine.txtID.Visible = false;
                objAddUpdateMedicine.txtMedicineName.Enabled = false;
                objAddUpdateMedicine.txtMedicineName.BackColor = Color.White;
                objAddUpdateMedicine.txtDescription.Enabled = false;
                objAddUpdateMedicine.txtDescription.BackColor = Color.White;
                objAddUpdateMedicine.dtpExpirationDate.Enabled = false;
                objAddUpdateMedicine.dtpExpirationDate.CalendarTitleBackColor = Color.White;
                objAddUpdateMedicine.dtpEntryTime.Enabled = false;
                objAddUpdateMedicine.dtpEntryTime.CalendarTitleBackColor = Color.White;
                objAddUpdateMedicine.dtpEntryDate.Enabled = false;
                objAddUpdateMedicine.dtpEntryDate.CalendarTitleBackColor = Color.White;
                objAddUpdateMedicine.numStock.Enabled = false;
                objAddUpdateMedicine.numStock.BackColor = Color.White;
                objAddUpdateMedicine.btnAddImage.Visible = false;
                objAddUpdateMedicine.cmbCategory.Enabled = false;
                objAddUpdateMedicine.cmbCategory.BackColor = Color.White;

            }
        }

        public void EnterTxtMedicineName(object sender, EventArgs e)
        {
            if (objAddUpdateMedicine.txtMedicineName.Texts.Trim().Equals("Nombre del medicamento"))
            {
                objAddUpdateMedicine.txtMedicineName.Clear();
                objAddUpdateMedicine.BackColor = Color.White;
                objAddUpdateMedicine.lblName.Visible = true;
            }
        }

        public void LeaveTxtMedicineName(object sender, EventArgs e)
        {
            if (objAddUpdateMedicine.txtMedicineName.Texts.Trim().Equals(" "))
            {
                objAddUpdateMedicine.txtMedicineName.Texts = "Tato";
                objAddUpdateMedicine.txtMedicineName.ForeColor = Color.FromArgb(142, 202, 230);
            }
        }
    }
}