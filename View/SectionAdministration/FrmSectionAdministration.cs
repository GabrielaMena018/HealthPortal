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

namespace RegistroPacientes.View.SectionAdministration
{
    public partial class FrmSectionAdministration : Form
    {
        public FrmSectionAdministration()
        {
            InitializeComponent();
            ControllerSectionAdministration control = new ControllerSectionAdministration(this);
        }
    }
}
