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
            //objAddUpdateMedicine.btnAgregarImagen.Click += new EventHandler(AddImage);
        }

        //private void AddImage(object sender, EventArgs e)
        // {
        //     FrmAddUpdateMedicine objImage = new FrmAddUpdateMedicine();
        //     OpenFileDialog openImage = new OpenFileDialog();
        //     openImage.Filter = "archivos de imagenes (*. png; *.jpg)| *.png ; *jpg";
        //     if (openImage.ShowDialog() == DialogResult.OK)
        //     {
        //         objImage.PicImage.Image = Image.FromFile(openImage.FileName);
        //         //objImage.PicImage.SizeMode = PictureBoxSizeMode.StretchImage;
        //     }
        // }
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

        public void CheckAction()
        {
            if (action == 1)
            {
                objAddUpdateMedicine.btnAddInventory.Enabled = true;
                objAddUpdateMedicine.btnUpdateInventory.Enabled = false;
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
                objAddUpdateMedicine.txtMedicineName.BackColor = Color.Silver;
                objAddUpdateMedicine.txtDescription.Enabled = false;
                objAddUpdateMedicine.txtDescription.BackColor = Color.Silver;
                objAddUpdateMedicine.dtpExpirationDate.Enabled = false;
                objAddUpdateMedicine.dtpExpirationDate.CalendarTitleBackColor = Color.Silver;
                objAddUpdateMedicine.dtpEntryTime.Enabled = false;
                objAddUpdateMedicine.dtpEntryTime.CalendarTitleBackColor = Color.Silver;
                objAddUpdateMedicine.dtpEntryDate.Enabled = false;
                objAddUpdateMedicine.dtpEntryDate.CalendarTitleBackColor = Color.Silver;
                objAddUpdateMedicine.numStock.Enabled = false;
                objAddUpdateMedicine.numStock.BackColor = Color.Silver;
                objAddUpdateMedicine.btnAddImage.Visible = false;
                objAddUpdateMedicine.cmbCategory.Enabled = false;
                objAddUpdateMedicine.cmbCategory.BackColor = Color.Silver;

            }
        }

        public void RegisterNewMedicine(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            DateTime vencimiento = fecha.AddDays(31);
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();
            //Datos para la creacion de un nuevo inventario
            daoInventoryAdministration.NombreMedicamento = objAddUpdateMedicine.txtMedicineName.Texts.Trim();
            if (objAddUpdateMedicine.txtMedicineName.Texts == "")
            {
                MessageBox.Show("Ingrese nombre del medicamento valido, ya que el medicamento se encuentra vacío", "Error al ingreso de medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                daoInventoryAdministration.Descripcion = objAddUpdateMedicine.txtDescription.Texts.Trim();
                daoInventoryAdministration.IdCategoria = int.Parse(objAddUpdateMedicine.cmbCategory.SelectedValue.ToString());
                daoInventoryAdministration.FechaVencimiento = objAddUpdateMedicine.dtpExpirationDate.Value.Date;
                if (objAddUpdateMedicine.dtpExpirationDate.Value.Date <= vencimiento)
                {
                    MessageBox.Show("Ingrese una fecha de vencimiento valida, de 31 días despues de la fecha de el día de hoy", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    daoInventoryAdministration.Existencia = int.Parse(objAddUpdateMedicine.numStock.Text.Trim());
                    daoInventoryAdministration.Envases = 1;
                    if (int.Parse(objAddUpdateMedicine.numStock.Text) == 0)
                    {
                        MessageBox.Show("Ingrese una cantidad correcta de medicamentos", "Error al ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        daoInventoryAdministration.Ingreso = objAddUpdateMedicine.dtpEntryDate.Value.Date;
                        daoInventoryAdministration.Salida = objAddUpdateMedicine.dtpEntryTime.Value.ToString("HH:mm");
                        int returnedValue = daoInventoryAdministration.RegisterMedicine();
                        if (returnedValue == 2)
                        {
                            MessageBox.Show("Los datos han sido registrados exitosamente",
                                            "Proceso completado",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Los datos no pudieron ser registrados",
                                            "Proceso interrumpido",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                        }
                    }
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
            objAddUpdateMedicine.txtID.Text = id.ToString();
            objAddUpdateMedicine.txtMedicineName.Texts = medicineName;
            objAddUpdateMedicine.cmbCategory.Text = medicineCategory;
            objAddUpdateMedicine.dtpExpirationDate.Value = expirationDate;
            objAddUpdateMedicine.numStock.Text = stock;
            objAddUpdateMedicine.dtpEntryDate.Value = entryDate;
            objAddUpdateMedicine.dtpEntryTime.Value = exit;
            objAddUpdateMedicine.txtDescription.Texts = description;

        }
    }
}