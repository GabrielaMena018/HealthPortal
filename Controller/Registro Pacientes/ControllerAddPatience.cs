using RegistroPacientes.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RegistroPacientes.Controlador
{
     class ControllerAddPatience
    {
        FrmAddPatience ObjAddPatience;
        int accion;
        private string role;
        string TipoPersona;
        int Id;

        public ControllerAddPatience( FrmAddPatience Vista, int accion ) 
        {
            ObjAddPatience = Vista;
            this.accion = accion;
            //Verificar accion
            verificarAccion();
            ObjAddPatience.Load += new EventHandler(InitialCharge);
            //agregar un nuevo paciente
            ObjAddPatience.btnAgregarPaciente.Click += new EventHandler(NewPatience);
            //Opcion del comboBox en este se puede cambiar si es uin estudiante o un alumno para mostrar los datos que se tienen que llenar
            ObjAddPatience.CmbRol.SelectedIndexChanged += new EventHandler(CmbRole_SelectChange);
        }
        public ControllerAddPatience(FrmAddPatience Vista, int accion, int id, string rol) 
        {
            ObjAddPatience = Vista;
            this.accion = accion;
            this.role = rol;
            this.Id = id;
            ObjAddPatience.Load += new EventHandler(InitialCharge);
            verificarAccion();
            ChargeValues(Id, rol);
            ObjAddPatience.BtnActuzalizar.Click += new EventHandler(UpdatePatient);
        }

        public void UpdatePatient(object sender, EventArgs e)
        {
           DAOAdminPatience DaoUpdate = new DAOAdminPatience();
            DaoUpdate.IdPaciente = int.Parse(ObjAddPatience.txtId.Text.Trim());
            DaoUpdate.Nombre = ObjAddPatience.TxtNombrePaciente.Texts.Trim();
            DaoUpdate.Apellido = ObjAddPatience.TxtApellidoPaciente.Texts.Trim();
            DaoUpdate.Rol = (int)ObjAddPatience.CmbRol.SelectedValue;
            DaoUpdate.Fecha = ObjAddPatience.PickFechaRegistro.Value;
            DaoUpdate.Hora = ObjAddPatience.PickHoraRegistro.Value.ToString("HH:mm");
            DaoUpdate.Medicamento = (int)ObjAddPatience.CmbMedicamentoRegistro.SelectedValue;
            DaoUpdate.Observacion = ObjAddPatience.TxtObservaciones.Texts.Trim();
            if (DaoUpdate.Rol == 1) 
            {
                //Actuzalizar Tabla Grado
                DaoUpdate.Especialidad = (int)ObjAddPatience.CmbEspecidalidadRegistro.SelectedValue;
                DaoUpdate.GrupoTecnico = ObjAddPatience.txtGrupo.Texts;
                DaoUpdate.Grado = (int)ObjAddPatience.CmBGradoRegistro.SelectedValue;
                DaoUpdate.SeccionAcademica = (int)ObjAddPatience.CmbSeccionRegistro.SelectedValue;

                //Insercion de datos tbEstudiantes
                DaoUpdate.Codigo = ObjAddPatience.TxtCodigoPaciente.Texts;

            }
            else 
            {
                DaoUpdate.Documento = ObjAddPatience.mksDocumento.Text;
                DaoUpdate.IdArea = (int)ObjAddPatience.CmbAreaPersonal.SelectedValue;
            }
            int valorRetornado = DaoUpdate.UpdatePatient();

            if (valorRetornado == 2)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (valorRetornado == 1)
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

        public void verificarAccion()
        {
            if (accion == 1)
            {
                ObjAddPatience.btnAgregarPaciente.Enabled = true;
                ObjAddPatience.BtnActuzalizar.Enabled = false;
            }
            else if (accion == 2)
            {
                ObjAddPatience.btnAgregarPaciente.Enabled = false;
                ObjAddPatience.btnAgregarPaciente.Enabled = true;
           
            }
        }

        private void NewPatience(object sender, EventArgs e)
        {
            //Enviar los datos de los componentes del DTO
            DAOAdminPatience daoInsertPatient = new DAOAdminPatience();

            //Inserccion de datos de la tabla paciente
            daoInsertPatient.Nombre = ObjAddPatience.TxtNombrePaciente.Texts;
            daoInsertPatient.Apellido = ObjAddPatience.TxtApellidoPaciente.Texts;
            daoInsertPatient.Rol = (int)ObjAddPatience.CmbRol.SelectedValue;

            if(ObjAddPatience.CmbRol.SelectedIndex == 0) 
            {
                //Insercion datos tabla grado seccion
                daoInsertPatient.Especialidad = (int)ObjAddPatience.CmbEspecidalidadRegistro.SelectedValue;
                daoInsertPatient.GrupoTecnico = ObjAddPatience.txtGrupo.Texts;
                daoInsertPatient.Grado = (int)ObjAddPatience.CmBGradoRegistro.SelectedValue;
                daoInsertPatient.SeccionAcademica = (int)ObjAddPatience.CmbSeccionRegistro.SelectedValue;



                //Insercion de datos tbEstudiantes
                daoInsertPatient.Codigo = ObjAddPatience.TxtCodigoPaciente.Texts;
            }
            else 
            {
                daoInsertPatient.Documento = ObjAddPatience.mksDocumento.Text;
                daoInsertPatient.IdArea = (int)ObjAddPatience.CmbAreaPersonal.SelectedValue;
            }
            

            //Insercion de datos tbVisitas
            daoInsertPatient.Fecha = ObjAddPatience.PickFechaRegistro.Value.Date;
            daoInsertPatient.Hora = ObjAddPatience.PickHoraRegistro.Value.ToString("HH:mm");
            daoInsertPatient.Medicamento = (int)ObjAddPatience.CmbMedicamentoRegistro.SelectedValue;
            daoInsertPatient.Observacion = ObjAddPatience.TxtObservaciones.Texts;


            int retorno = daoInsertPatient.PatientRegistration();
            if (retorno == 1)
            {
                MessageBox.Show("Datos ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron ingresar los datos", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public void InitialCharge(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminPatience objAdmin = new DAOAdminPatience();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet dsRol = objAdmin.LlenarCombo("tbTipoPersona");
            //Llenar combobox tbRole
            ObjAddPatience.CmbRol.DataSource = dsRol.Tables["tbTipoPersona"];
            ObjAddPatience.CmbRol.ValueMember = "IdTipoPersona";
            ObjAddPatience.CmbRol.DisplayMember = "TipoPerona";


            DataSet dsEspRegistro = objAdmin.LlenarCombo("tbEspecialidades");
            //Llenar combobox tbEspecialidades
            ObjAddPatience.CmbEspecidalidadRegistro.DataSource = dsEspRegistro.Tables["tbEspecialidades"];
            ObjAddPatience.CmbEspecidalidadRegistro.ValueMember = "IdEspecialidad";
            ObjAddPatience.CmbEspecidalidadRegistro.DisplayMember = "Especialidad";

            DataSet dsGradosRegistros = objAdmin.LlenarCombo("tbGrados");
            //Llenar combobox tbGrados
            ObjAddPatience.CmBGradoRegistro.DataSource = dsGradosRegistros.Tables["tbGrados"];
            ObjAddPatience.CmBGradoRegistro.ValueMember = "IdGrado";
            ObjAddPatience.CmBGradoRegistro.DisplayMember = "Grado";

            DataSet dsSeccionesRegistros = objAdmin.LlenarCombo("tbSeccionAcademica");
            //Llenar combobox tbSeccion
            ObjAddPatience.CmbSeccionRegistro.DataSource = dsSeccionesRegistros.Tables["tbSeccionAcademica"];
            ObjAddPatience.CmbSeccionRegistro.ValueMember = "IdSeccionAcademica";
            ObjAddPatience.CmbSeccionRegistro.DisplayMember = "SeccionAcademica";

            //Llenar combox tbMedicamento
            DataSet dsMedicamentoRegistros = objAdmin.LlenarCombo("tbMedicamentos");
            ObjAddPatience.CmbMedicamentoRegistro.DataSource = dsMedicamentoRegistros.Tables["tbMedicamentos"];
            ObjAddPatience.CmbMedicamentoRegistro.ValueMember = "IdMedicamento";
            ObjAddPatience.CmbMedicamentoRegistro.DisplayMember = "nombreMedicamento";

            //Llenar combox Area de tarbajo tbAreaPersonal
            DataSet dsAreaPersonalRegistros = objAdmin.LlenarCombo("tbAreaPersonal");
            ObjAddPatience.CmbAreaPersonal.DataSource = dsAreaPersonalRegistros.Tables["tbAreaPersonal"];
            ObjAddPatience.CmbAreaPersonal.ValueMember = "IdArea";
            ObjAddPatience.CmbAreaPersonal.DisplayMember = "TipoArea";


            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (accion == 2)
            {
                ObjAddPatience.CmbRol.Text = TipoPersona;
            }
        }


        public void CmbRole_SelectChange(object sender, EventArgs e) 
        {
            if (ObjAddPatience.CmbRol.SelectedIndex == 0)
            {
                ObjAddPatience.groupStudent.Visible = true;
            }
            else 
            {
                ObjAddPatience.groupPersonalInstitucion.Visible = true;
                ObjAddPatience.groupStudent.Visible = false;
            }
        }

        public void ChargeValues( int Id,string rol )
        {
            DAOAdminPatience objLLenarCampos = new DAOAdminPatience();
            
            objLLenarCampos.IdPaciente = Id;
            
            if (rol == "Estudiante")
            {
                objLLenarCampos.Rol = 1;
                objLLenarCampos.ObtenerDatosAddPatient();
                ObjAddPatience.txtId.Text = objLLenarCampos.IdPaciente.ToString();
                ObjAddPatience.TxtNombrePaciente.Text = objLLenarCampos.Nombre;
                ObjAddPatience.TxtApellidoPaciente.Texts = objLLenarCampos.Apellido;

            }
            else if( rol == "Personal de la Institucion") 
            {
                objLLenarCampos.Rol = 2;
            }
            else 
            {
                MessageBox.Show("Rol ingresado no valido", "Error Verificacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            

        }




    }
}
