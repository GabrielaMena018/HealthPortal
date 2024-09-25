using HealthPortal.Helper;
using HealthPortal.Model.DAO;
using HealthPortal.Model.DTO;
using HealthPortal.View.PatientAdministration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPortal.Controller.PatientAdministration
{
    class ControllerViewPatientInfo : DAOPatientAdministration
    {
        FrmViewPatientInfo ObjPatientInfo;

        int action, respuesta;
        private string typeperson, Grade, specialty, AcademicSection;
        public ControllerViewPatientInfo(FrmViewPatientInfo view, int action) 
        {
            ObjPatientInfo = view;
            this.action = action;
            //Verificar action
            VerifyAction();
            ObjPatientInfo.Load += new EventHandler(InitialLoad);
            //agregar un nuevo paciente
            ObjPatientInfo.btnAddPatient.Click += new EventHandler(NewPatient);
        }

        private void NewPatient(object sender, EventArgs e)
        {
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            //Inserccion de datos de la tabla paciente
            daoPatientAdministration.Name = ObjPatientInfo.txtPatientName.Texts;
            daoPatientAdministration.LastName = ObjPatientInfo.txtPatientLastName.Texts;
            daoPatientAdministration.Role = (int)ObjPatientInfo.cmbRole.SelectedValue;

            //Insercion datos tabla grade seccion
            daoPatientAdministration.Specialty = (int)ObjPatientInfo.cmbRegisterSpecialty.SelectedValue;
            daoPatientAdministration.TechnicalGroup = ObjPatientInfo.txtGrupo.Texts;
            daoPatientAdministration.Grade = (int)ObjPatientInfo.CmBGradoRegistro.SelectedValue;
            daoPatientAdministration.AcademicSection = (int)ObjPatientInfo.cmbSection.SelectedValue;
            daoPatientAdministration.Code = ObjPatientInfo.txtPatientCode.Texts;

            int retorno = daoPatientAdministration.PatientInsert();
            if (retorno == 1)
            {
                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ControllerViewPatientInfo(FrmViewPatientInfo view, int Action, int IdPatient, string PatientName, string PatientLastName, string TypePerson, string codigo, string grupoTecnico, string grade, string seccionAcademica, string Especialidad)
        {
            ObjPatientInfo = view;
            this.action = Action;
            this.typeperson = TypePerson;
            this.Grade = grade;
            this.AcademicSection = seccionAcademica;
            this.specialty = Especialidad;
            ObjPatientInfo.Load += new EventHandler(InitialLoad);
            VerifyAction();
            ChargeValues(IdPatient, PatientName, PatientLastName, codigo, grupoTecnico);
            ObjPatientInfo.btnUpdate.Click += new EventHandler(UpdatePatient);
        }

        

        public void InitialLoad(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet dsRol = daoPatientAdministration.FillCombo("tbTipoPersona", "Pacientes");
            //Llenar combobox tbRole
            ObjPatientInfo.cmbRole.DataSource = dsRol.Tables["tbTipoPersona"];
            ObjPatientInfo.cmbRole.ValueMember = "idTipoPersona";
            ObjPatientInfo.cmbRole.DisplayMember = "tipoPersona";


            DataSet dsEspRegistro = daoPatientAdministration.FillCombo("tbEspecialidades", "Secciones");
            //Llenar combobox tbEspecialidades
            ObjPatientInfo.cmbRegisterSpecialty.DataSource = dsEspRegistro.Tables["tbEspecialidades"];
            ObjPatientInfo.cmbRegisterSpecialty.ValueMember = "idEspecialidad";
            ObjPatientInfo.cmbRegisterSpecialty.DisplayMember = "especialidad";

            DataSet dsGradosRegistros = daoPatientAdministration.FillCombo("tbGrados", "Secciones");
            //Llenar combobox tbGrados
                ObjPatientInfo.CmBGradoRegistro.DataSource = dsGradosRegistros.Tables["tbGrados"];
            ObjPatientInfo.CmBGradoRegistro.ValueMember = "idGrado";
            ObjPatientInfo.CmBGradoRegistro.DisplayMember = "grado";

            DataSet dsSeccionesRegistros = daoPatientAdministration.FillCombo("tbSeccionAcademica", "Secciones");
            //Llenar combobox tbSeccion
            ObjPatientInfo.cmbSection.DataSource = dsSeccionesRegistros.Tables["tbSeccionAcademica"];
            ObjPatientInfo.cmbSection.ValueMember = "idSeccionAcademica";
            ObjPatientInfo.cmbSection.DisplayMember = "seccionAcademica";




            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (action == 2 || action == 3)
            {
                ObjPatientInfo.cmbRole.Text = typeperson;
                ObjPatientInfo.CmBGradoRegistro.Text = Grade;
                ObjPatientInfo.cmbSection.Text = AcademicSection;
                ObjPatientInfo.cmbRegisterSpecialty.Text = specialty;

            }
        }
        public void ChargeValues(int IdPatient, string PatientName, string PatientLastName, string Code, string grupoTecnico)
        {
            ObjPatientInfo.txtIdPerson.Text = IdPatient.ToString();
            ObjPatientInfo.txtPatientName.Texts = PatientName;
            ObjPatientInfo.txtPatientLastName.Texts = PatientLastName;
            ObjPatientInfo.txtPatientCode.Texts = Code;
            ObjPatientInfo.txtGrupo.Texts = grupoTecnico;

        }

        public void VerifyAction()
        {
            if(action == 1){
                ObjPatientInfo.label1.Text = "Agregar nuevo paciente";
                ObjPatientInfo.btnAddPatient.Enabled = true;
                ObjPatientInfo.btnUpdate.Enabled = false;
            }
            else if (action == 2)
            {
                ObjPatientInfo.label1.Text = "Actualizar información del Paciente";
                ObjPatientInfo.btnUpdate.Enabled = true;
                ObjPatientInfo.btnAddPatient.Enabled = true;


            }
            else if (action == 3)
            {
            
                ObjPatientInfo.btnUpdate.Enabled = false;
                ObjPatientInfo.btnUpdate.BackColor = Color.Silver;
                ObjPatientInfo.pictureBox1.BackColor = Color.Silver;
                ObjPatientInfo.txtPatientName.Enabled = false;
                ObjPatientInfo.txtPatientName.BackColor = Color.WhiteSmoke;
                ObjPatientInfo.txtPatientLastName.Enabled = false;
                ObjPatientInfo.txtPatientLastName.BackColor = Color.WhiteSmoke;
                ObjPatientInfo.cmbRole.Enabled = false;
                ObjPatientInfo.txtPatientCode.Enabled = false;
                ObjPatientInfo.txtPatientCode.BackColor = Color.WhiteSmoke;
                ObjPatientInfo.cmbRegisterSpecialty.Enabled = false;
                ObjPatientInfo.txtGrupo.Enabled = false;
                ObjPatientInfo.txtGrupo.BackColor = Color.WhiteSmoke;
                ObjPatientInfo.CmBGradoRegistro.Enabled = false;
                ObjPatientInfo.cmbSection.Enabled = false;
            }
        }

        public void UpdatePatient(object sender, EventArgs e)
        {
            DAOPatientAdministration daoPatientAdministration = new DAOPatientAdministration();
            daoPatientAdministration.IdPatient = int.Parse(ObjPatientInfo.txtIdPerson.Text.Trim());
            daoPatientAdministration.Name = ObjPatientInfo.txtPatientName.Texts.Trim();
            daoPatientAdministration.LastName = ObjPatientInfo.txtPatientLastName.Texts.Trim();
            daoPatientAdministration.Role = (int)ObjPatientInfo.cmbRole.SelectedValue;

            //Actuzalizar Tabla Grade
            daoPatientAdministration.Specialty = (int)ObjPatientInfo.cmbRegisterSpecialty.SelectedValue;
            daoPatientAdministration.TechnicalGroup = ObjPatientInfo.txtGrupo.Texts;
            daoPatientAdministration.Grade = (int)ObjPatientInfo.CmBGradoRegistro.SelectedValue;
            daoPatientAdministration.AcademicSection = (int)ObjPatientInfo.cmbSection.SelectedValue;

            //Insercion de datos tbEstudiantes
            daoPatientAdministration.Code = ObjPatientInfo.txtPatientCode.Texts;


            int valorRetornado = daoPatientAdministration.UpdatePatient();

            if (valorRetornado  == 1)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

       

        

       

    }
}
