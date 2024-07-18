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
            objAdminPatience.tabControl.SelectedIndexChanged
            //Llenar DataGridView
            objAdminPatience.GridViewPatient.DataSource = ds.Tables["ViewAdminPatient"];
            objAdminPatience.GridViewPatient.Columns[0].HeaderText = "ID Paciente";
            objAdminPatience.GridViewPatient.Columns[0].Width = 33;
            objAdminPatience.GridViewPatient.Columns[1].HeaderText = "Nombre";
            objAdminPatience.GridViewPatient.Columns[1].Width = 80;
            objAdminPatience.GridViewPatient.Columns[2].HeaderText = "Apellido";
            objAdminPatience.GridViewPatient.Columns[2].Width = 85;
            objAdminPatience.GridViewPatient.Columns[3].Visible = false;
            objAdminPatience.GridViewPatient.Columns[4].Visible = false;
            objAdminPatience.GridViewPatient.Columns[5].HeaderText = "Codigo";
            objAdminPatience.GridViewPatient.Columns[6].Visible = false;
            objAdminPatience.GridViewPatient.Columns[7].Width = 50;
            objAdminPatience.GridViewPatient.Columns[8].Visible = false;
            objAdminPatience.GridViewPatient.Columns[9].Width = 140;
            objAdminPatience.GridViewPatient.Columns[10].HeaderText = "Fecha";
            objAdminPatience.GridViewPatient.Columns[11].HeaderText = "Hora";
            objAdminPatience.GridViewPatient.Columns[12].Visible = false;
            objAdminPatience.GridViewPatient.Columns[13].Visible = false;

            
            
        }
        private void UpdatePatient(object sender, EventArgs e) 
        {
            int pos = objAdminPatience.GridViewPatient.CurrentRow.Index;
            int id;
            string  rol;
            id = int.Parse(objAdminPatience.GridViewPatient[0, pos].Value.ToString());
            rol = objAdminPatience.GridViewPatient[3, pos].Value.ToString();
            FrmAddPatience openForm = new FrmAddPatience(2,id, rol);
            openForm.ShowDialog();
            RefrescarData();
        }
    }
}
