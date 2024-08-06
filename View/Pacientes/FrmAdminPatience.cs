using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Controlador;

namespace RegistroPacientes
{
    public partial class FrmAdminPatience : Form
    {
        public FrmAdminPatience()
        {
            InitializeComponent();
            ControllerAdminPatience control = new ControllerAdminPatience(this);
        }
    }
}