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

        //Constructor
        public ControllerAdminPatience(FrmAdminPatience Vista) 
        {
            objAdminPatience = Vista;
            objAdminPatience.btnNew.Click += new EventHandler(NewPatience);
            objAdminPatience.Load += new EventHandler(InitialCharge);
            objAdminPatience.cmsActualizar.Click += new EventHandler(UpdatePatient);
            objAdminPatience.tabControl.SelectedIndexChanged += new EventHandler(RefrescarDataPersonal);
        }

     
        //Esta es la carga inicial la cual se encarga de llenar los combobox
        private void InitialCharge(object sender, EventArgs e)
        {
            RefrescarDataPaciente();    
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

            DataSet dsAreaPersonal = objAdmin.LlenarCombo("tbAreaPersonal");
            //Llenar combobox tbGrados
            objAdminPatience.cmbAreaPersonal.DataSource = dsAreaPersonal.Tables["tbAreaPersonal"];
            objAdminPatience.cmbAreaPersonal.ValueMember = "IdArea";
            objAdminPatience.cmbAreaPersonal.DisplayMember = "TipoArea";


            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (accion == 2)
            {
                objAdminPatience.CmbCategoria.Text = TipoPersona;
            }

        }

        //Sirve para abrir la vista addPatient para poder agregar un nuevo paciente
        public void NewPatience(object sender, EventArgs e)  
        {
            FrmAddPatience openForm = new FrmAddPatience(1);
            openForm.ShowDialog();
            RefrescarDataPaciente();
        }
        //Con este metodo se puede ver la información de la vista ViewAdminPatientque llena el datGrid de de los estudiantes
        public void RefrescarDataPaciente()
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdmin = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdmin.AdminPatient();
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
            objAdminPatience.GridViewPatient.Columns[5].HeaderText = "Código";
            objAdminPatience.GridViewPatient.Columns[6].Visible = false;
            objAdminPatience.GridViewPatient.Columns[7].Width = 50;
            objAdminPatience.GridViewPatient.Columns[8].Visible = false;
            objAdminPatience.GridViewPatient.Columns[9].Width = 140;
            objAdminPatience.GridViewPatient.Columns[10].HeaderText = "Fecha de visita";
            objAdminPatience.GridViewPatient.Columns[11].HeaderText = "Hora de visita";
            objAdminPatience.GridViewPatient.Columns[12].Visible = false;
            objAdminPatience.GridViewPatient.Columns[13].Visible = false;
 
        }
        //Con este metodo se puede ver la información de la vista ViewPersonalInstitucion que llena el datGrid de del personal de la institucion
        public void RefrescarDataPersonal(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdminPersonal = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdminPersonal.AdminPatientPersonalInstitucion();
            //Llenar DataGridView
            objAdminPatience.dataGridViewPersonal.DataSource = ds.Tables["ViewPersonalInstitucion"];
            objAdminPatience.dataGridViewPersonal.Columns[0].HeaderText = "ID Paciente";
            objAdminPatience.dataGridViewPersonal.Columns[1].HeaderText = "Nombre";
            objAdminPatience.dataGridViewPersonal.Columns[2].HeaderText = "Apellido";
            objAdminPatience.dataGridViewPersonal.Columns[3].Visible = false;
            objAdminPatience.dataGridViewPersonal.Columns[4].HeaderText = "Documento";
            objAdminPatience.dataGridViewPersonal.Columns[5].HeaderText = "Área del trabajador";
            objAdminPatience.dataGridViewPersonal.Columns[6].HeaderText = "Fecha de Visita";
            objAdminPatience.dataGridViewPersonal.Columns[7].HeaderText = "Hora de Visita";
            objAdminPatience.dataGridViewPersonal.Columns[8].Visible = false;
            objAdminPatience.dataGridViewPersonal.Columns[9].Visible = false;

        }
        //MAndar la información del data grid para empezar el priceso de update 
        private void UpdatePatient(object sender, EventArgs e) 
        {
            int pos = objAdminPatience.GridViewPatient.CurrentRow.Index;
            int IdPaciente;
            string  nombrePaciente, apellidoPaciente,TipoPersona,codigo, grupoTecnico, grado, seccionAcademica, Especialidad, horaVisita, nombreMedicamento, Observaciones;
            DateTime FechaVisita;

            IdPaciente = int.Parse(objAdminPatience.GridViewPatient[0, pos].Value.ToString());
            nombrePaciente = objAdminPatience.GridViewPatient[1,pos].Value.ToString();
            apellidoPaciente = objAdminPatience.GridViewPatient[2, pos].Value.ToString();
            TipoPersona = objAdminPatience.GridViewPatient[3,pos].Value.ToString();
            codigo = objAdminPatience.GridViewPatient[5, pos].Value.ToString();
            grupoTecnico = objAdminPatience.GridViewPatient[6, pos].Value.ToString();
            grado = objAdminPatience.GridViewPatient[7,pos].Value.ToString();
            seccionAcademica = objAdminPatience.GridViewPatient[8,pos].Value.ToString() ;
            Especialidad = objAdminPatience.GridViewPatient[9, pos].Value.ToString();
            FechaVisita= DateTime.Parse(objAdminPatience.GridViewPatient[10, pos].Value.ToString());
            horaVisita = objAdminPatience.GridViewPatient[11, pos].Value.ToString();
            nombreMedicamento = objAdminPatience.GridViewPatient[12, pos].Value.ToString();
            Observaciones = objAdminPatience.GridViewPatient[13, pos].Value.ToString();

            FrmAddPatience openFrom = new FrmAddPatience(2, IdPaciente, nombrePaciente, apellidoPaciente, TipoPersona, codigo, grupoTecnico, grado, seccionAcademica, Especialidad, FechaVisita, horaVisita, nombreMedicamento, Observaciones);
            openFrom.ShowDialog();
            RefrescarDataPaciente();
        }
    }
}
