using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using RegistroPacientes.Models.DAO;


namespace RegistroPacientes.Controlador
{
    internal class ControllerAdminPatience
    {
        FrmAdminPatience objAdminPatience;
        int abrir;
        private int accion;
        private string TipoPersona;

        public ControllerAdminPatience(FrmAdminPatience Vista) 
        {
            objAdminPatience = Vista;
            objAdminPatience.btnNew.Click += new EventHandler(NewPatience);
            objAdminPatience.Load += new EventHandler(InitialCharge);
        }
        private void InitialCharge(object sender, EventArgs e)
        {
            RefrescarData();    
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdmin = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet dsCategoria = objAdmin.LlenarCombo("tbTipoPersona");
            //Llenar combobox tbRole
            objAdminPatience.CmbCategoria.DataSource = dsCategoria.Tables["tbTipoPersona"];
            objAdminPatience.CmbCategoria.ValueMember = "IdTipoPersona";
            objAdminPatience.CmbCategoria.DisplayMember = "TipoPerona";

            DataSet dsEspRegistro = objAdmin.LlenarCombo("tbEspecialidades");
            //Llenar combobox tbRole
            objAdminPatience.CmbEspecialidad.DataSource = dsEspRegistro.Tables["tbEspecialidades"];
            objAdminPatience.CmbEspecialidad.ValueMember = "IdEspecialidad";
            objAdminPatience.CmbEspecialidad.DisplayMember = "Especialidad";

            DataSet dsGradosRegistros = objAdmin.LlenarCombo("tbGrados");
            //Llenar combobox tbGrados
            objAdminPatience.CmbGrado.DataSource = dsGradosRegistros.Tables["tbGrados"];
            objAdminPatience.CmbGrado.ValueMember = "IdGrado";
            objAdminPatience.CmbGrado.DisplayMember = "Grado";


            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (accion == 2)
            {
                objAdminPatience.CmbCategoria.Text = TipoPersona;
            }

        }

        public void NewPatience(object sender, EventArgs e)  
        {
            FrmAddPatience openForm = new FrmAddPatience();
            openForm.ShowDialog();
            RefrescarData();
            
        }
        public void RefrescarData()
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdmin = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdmin.AdminPatient();
            //Llenar DataGridView
            objAdminPatience.GridViewPatient.DataSource = ds.Tables["ViewAdminPatient"];
        }
    }
}
