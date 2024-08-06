using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Controller.UserAdministration;

namespace RegistroPacientes.View.UserAdministration
{
    public partial class FrmUserAdministration : Form
    {
        public FrmUserAdministration()
        {
            InitializeComponent();
            ControllerUserAdministration control = new ControllerUserAdministration(this);
        }
    }
}
