using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using RegistroPacientes.Model.DAO;
using RegistroPacientes.View.InventoryAdministration;
using System.Collections.Specialized;

namespace RegistroPacientes.Controller.InventoryAdministration
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
            objAddUpdateMedicine.btnAgregarInventario.Click += new EventHandler(RegisterNewMedicine);
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
        }
        public void InitialCharge(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminInventory
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();

            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombosInventario
            DataSet ds = daoInventoryAdministration.FillCombo();
            //Llenar comboBox de la tabla tbCategoriaMedicamento
            objAddUpdateMedicine.cmbCategoria.DataSource = ds.Tables["tbCategoriaMedicamento"];
            objAddUpdateMedicine.cmbCategoria.ValueMember = "idCategoriaMedicamento";
            objAddUpdateMedicine.cmbCategoria.DisplayMember = "categoriaMedicamento";
            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (action == 2)
            {
                objAddUpdateMedicine.cmbCategoria.Text = medicineCategory;
            }
        }

        public void CheckAction()
        {
            if (action == 1)
            {
                objAddUpdateMedicine.btnAgregarInventario.Enabled = true;
                objAddUpdateMedicine.btnUpdateInventory.Enabled = false;
            }
            else if (action == 2)
            {
                objAddUpdateMedicine.btnAgregarInventario.Enabled = false;
                objAddUpdateMedicine.btnUpdateInventory.Enabled = true;
            }
        }

        public void RegisterNewMedicine(object sender, EventArgs e)
        {
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();
            //Datos para la creacion de un nuevo inventario
            daoInventoryAdministration.NombreMedicamento = objAddUpdateMedicine.TxtNombreMedicamento.Texts.Trim();
            daoInventoryAdministration.Descripcion = objAddUpdateMedicine.TxtDescripcion.Texts.Trim();
            daoInventoryAdministration.IdCategoria = int.Parse(objAddUpdateMedicine.cmbCategoria.SelectedValue.ToString());
            daoInventoryAdministration.FechaVencimiento = objAddUpdateMedicine.PickFechaVencimiento.Value.Date;
            daoInventoryAdministration.Existencia = int.Parse(objAddUpdateMedicine.TxtCantidadExistencia.Texts.Trim());
            daoInventoryAdministration.Ingreso = objAddUpdateMedicine.PickIngreso.Value.Date;
            daoInventoryAdministration.Salida = objAddUpdateMedicine.PickHora.Value.ToString("HH:mm");
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

        public void UpdateInventory(object sender, EventArgs e)
        {
            DAOInventoryAdministration daoInventoryAdministration = new DAOInventoryAdministration();
            daoInventoryAdministration.IdMedicamento = int.Parse(objAddUpdateMedicine.TxTId.Text.Trim());
            daoInventoryAdministration.NombreMedicamento = objAddUpdateMedicine.TxtNombreMedicamento.Texts.Trim();
            daoInventoryAdministration.IdCategoria = int.Parse(objAddUpdateMedicine.cmbCategoria.SelectedValue.ToString());
            daoInventoryAdministration.FechaVencimiento = objAddUpdateMedicine.PickFechaVencimiento.Value.Date;
            daoInventoryAdministration.Existencia = int.Parse(objAddUpdateMedicine.TxtCantidadExistencia.Texts.Trim());
            daoInventoryAdministration.Ingreso = objAddUpdateMedicine.PickIngreso.Value.Date;
            daoInventoryAdministration.Salida = objAddUpdateMedicine.PickHora.Value.ToString("HH:mm");
            daoInventoryAdministration.Descripcion = objAddUpdateMedicine.TxtDescripcion.Texts.Trim();

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
            objAddUpdateMedicine.TxTId.Text = id.ToString();
            objAddUpdateMedicine.TxtNombreMedicamento.Texts = medicineName;
            objAddUpdateMedicine.cmbCategoria.Text = medicineCategory;
            objAddUpdateMedicine.PickFechaVencimiento.Value = expirationDate;
            objAddUpdateMedicine.TxtCantidadExistencia.Texts = stock;
            objAddUpdateMedicine.PickIngreso.Value = entryDate;
            objAddUpdateMedicine.PickHora.Value = exit;
            objAddUpdateMedicine.TxtDescripcion.Texts = description;

        }
    }
}
