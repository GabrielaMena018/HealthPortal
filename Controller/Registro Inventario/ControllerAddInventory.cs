using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using RegistroPacientes.Models.DAO;
using RegistroPacientes.View.Ineventario;
using System.Collections.Specialized;

namespace RegistroPacientes.Controller.Registro_Inventario
{
    internal class ControllerAddInventory
    {
        FrmAddInventory objAddInventory;
        private int accion;
        private string categoryMedicment;
        /// <summary>
        /// Constructor para la inserción de medicamentos
        /// </summary>
        /// <param name="vista"></param>
        /// <param name="accion"></param>
         public ControllerAddInventory(FrmAddInventory vista, int accion)
        {
            objAddInventory = vista;
            this.accion = accion;

            //Metodos que se ejecutan cuando el programa esta cargando
            CheckAction();
            objAddInventory.Load += new EventHandler(InitialCharge);

            //Metodos que se ejecutan al ocurrir eventos
            objAddInventory.btnAgregarInventario.Click += new EventHandler(NewRegisterInventory);
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

        public ControllerAddInventory(FrmAddInventory vista, int accion, int id, string nameMedicment, string categoryMedicment, DateTime expirationDate, string stock, string income, string exit, string description)
        {
            //Acciones iniciales
            objAddInventory = vista;
            this.accion = accion;
            this.categoryMedicment = categoryMedicment;

            //Metodos iniciales ejecutados cuando el formulario esta cargando
            objAddInventory.Load += new EventHandler(InitialCharge);
            CheckAction();
            ChargeValues(id, nameMedicment, categoryMedicment, expirationDate, stock, income, exit, description);

            //Metodos que se ejecutan al ocurrir eventos
            objAddInventory.btnUpdateInventory.Click += new EventHandler(UpdateInventory);
        }
        public void InitialCharge(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminInventory
            DAOAdminInventory objAdmin = new DAOAdminInventory();

            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombosInventario
            DataSet dsInventory = objAdmin.LlenarCombosInventario();
            //Llenar comboBox de la tabla tbCategoriaMedicamento
            objAddInventory.cmbCategoria.DataSource = dsInventory.Tables["tbCategoriaMedicamento"];
            objAddInventory.cmbCategoria.ValueMember = "IdCategoriaMedicamento";
            objAddInventory.cmbCategoria.DisplayMember = "CategoriaMedicamento";
            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (accion == 2)
            {
                objAddInventory.cmbCategoria.Text = categoryMedicment;
            }
        }

        public void CheckAction()
        {
            if (accion == 1)
            {
                objAddInventory.btnAgregarInventario.Enabled = true;
                objAddInventory.btnUpdateInventory.Enabled = false;  
            }
            else if (accion == 2)
            {
                objAddInventory.btnAgregarInventario.Enabled = false;
                objAddInventory.btnUpdateInventory.Enabled = true;
                objAddInventory.TxtDescripcion.Enabled = false;
            }
        }

        public void NewRegisterInventory(object sender, EventArgs e)
        {
            DAOAdminInventory daoAdmin = new DAOAdminInventory();
            //Datos para la creacion de un nuevo inventario
            daoAdmin.NombreMedicamento = objAddInventory.TxtNombreMedicamento.Text.Trim();
            daoAdmin.IdCategoria = int.Parse(objAddInventory.cmbCategoria.SelectedValue.ToString());
            daoAdmin.FechaVencimiento = objAddInventory.PickFechaVencimiento.Value.Date;
            daoAdmin.Existencia = objAddInventory.TxtCantidadExistencia.Text.Trim();
            daoAdmin.Ingreso = objAddInventory.TxTIngreso.Texts.Trim();
            daoAdmin.Salida = objAddInventory.TxTSalida.Text.Trim();
            int returnedValue = daoAdmin.ObtenerInfoCombos();
            if ( returnedValue == 1)
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
            DAOAdminInventory daoUpdate = new DAOAdminInventory();
            daoUpdate.IdCategoria = int.Parse(objAddInventory.TxTId.Text.Trim());
            daoUpdate.NombreMedicamento = objAddInventory.TxtNombreMedicamento.Text.Trim();
            daoUpdate.IdCategoria = int.Parse(objAddInventory.cmbCategoria.SelectedValue.ToString());
            daoUpdate.FechaVencimiento = objAddInventory.PickFechaVencimiento.Value.Date;
            daoUpdate.Existencia = objAddInventory.TxtCantidadExistencia.Text.Trim();
            daoUpdate.Ingreso = objAddInventory.TxTIngreso.Texts.Trim();
            daoUpdate.Salida = objAddInventory.TxTSalida.Text.Trim();

            int returnedValue = daoUpdate.UpdateInventory();
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

        public void ChargeValues(int id, string nameMedicment, string categoryMedicment, DateTime expirationDate, string stock, string income, string exit, string description)
        {
            objAddInventory.TxTId.Text = id.ToString();
            objAddInventory.TxtNombreMedicamento.Text = nameMedicment;
            objAddInventory.cmbCategoria.Text = categoryMedicment;
            objAddInventory.PickFechaVencimiento.Value = expirationDate;
            objAddInventory.TxtCantidadExistencia.Text = stock;
            objAddInventory.TxTIngreso.Text = income;
            objAddInventory.TxTSalida.Text = exit;
            objAddInventory.TxtDescripcion.Text = description;  

        }
    }
}
