using RegistroPacientes.Controller.SectionAdministration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RegistroPacientes.View.SectionAdministration
{
    public partial class FrmAddUpdateSection : Form
    {
        public FrmAddUpdateSection(int action, int TabPage)
        {
            InitializeComponent();
            ControllerAddUpdateSection control = new ControllerAddUpdateSection(this, action, TabPage);
        }
        public FrmAddUpdateSection(int action, int IdEspecialidad, string Especialidad)
        {
            InitializeComponent();
            ControllerAddUpdateSection control = new ControllerAddUpdateSection(this, action, IdEspecialidad, Especialidad);
        }
        public FrmAddUpdateSection(int action, int IdSecion, string GrupoTecnico, string Especialidad, string Grado, string SeccionAcademica)
        {
            InitializeComponent();
            ControllerAddUpdateSection control = new ControllerAddUpdateSection(this, action, IdSecion, GrupoTecnico, Especialidad, Grado, SeccionAcademica);
        }
        public FrmAddUpdateSection(int action, int IdSeccion, string nombreSeccionAcademica, int num)
        {
            InitializeComponent();
            ControllerAddUpdateSection control = new ControllerAddUpdateSection(this, action, IdSeccion, nombreSeccionAcademica, num);
        }
    }
}
