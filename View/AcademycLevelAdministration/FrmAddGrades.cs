using RegistroPacientes.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.View.AcademycLevelAdministration;
using RegistroPacientes.Controller.AcademycLevelAdministration;
using System.Windows.Forms.DataVisualization.Charting;

namespace RegistroPacientes.View.AcademycLevelAdministration
{
    public partial class FrmAddGrades : Form
    {
        public FrmAddGrades(int action, int TabPage)
        {
            InitializeComponent();
            ControllerAddGrade objAddGrade = new ControllerAddGrade(this, action, TabPage);
        }

        public FrmAddGrades(int action, int IdEspecialidad, string Especialidad)
        {
            InitializeComponent();
            ControllerAddGrade objAddGrade = new ControllerAddGrade(this, action, IdEspecialidad, Especialidad);
        }

        public FrmAddGrades(int action, int IdSecion, string GrupoTecnico, string Especialidad, string Grado, string SeccionAcademica)
        {
            InitializeComponent();
            ControllerAddGrade objAddGrade = new ControllerAddGrade(this, action, IdSecion, GrupoTecnico, Especialidad, Grado, SeccionAcademica);
        }

        public FrmAddGrades(int action, int IdSeccion, string nombreSeccionAcademica, int num)
        {
            InitializeComponent();
            ControllerAddGrade objAddGrade = new ControllerAddGrade(this, action, IdSeccion, nombreSeccionAcademica, num);
        }


    }
}
