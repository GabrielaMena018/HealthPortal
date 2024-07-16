using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using RegistroPacientes.Models.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;


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
            objAdminPatience.cmsActualizar.Click += new EventHandler(UpdatePatient);
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
            FrmAddPatience openForm = new FrmAddPatience(1);
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
        private void UpdatePatient(object sender, EventArgs e) 
        {
            int pos = objAdminPatience.GridViewPatient.CurrentRow.Index;
            int id;
            string nombrePaciente, apellidosPaciente, rol, horaVisita, documento;
            DateTime fechavisita;
            id = int.Parse(objAdminPatience.GridViewPatient[0, pos].Value.ToString());
            nombrePaciente = objAdminPatience.GridViewPatient[1, pos].Value.ToString();
            apellidosPaciente = objAdminPatience.GridViewPatient[2, pos].Value.ToString();
            rol = objAdminPatience.GridViewPatient[3, pos].Value.ToString();
            fechavisita = DateTime.Parse(objAdminPatience.GridViewPatient[4, pos].Value.ToString());
            horaVisita = objAdminPatience.GridViewPatient[5, pos].Value.ToString();
            documento= objAdminPatience.GridViewPatient[6, pos].Value.ToString();

            FrmAddPatience openForm = new FrmAddPatience(2,id,nombrePaciente, apellidosPaciente, rol,fechavisita,horaVisita,documento);
            openForm.ShowDialog();
            RefrescarData();
        }
    }
}
