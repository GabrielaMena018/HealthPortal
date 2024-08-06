using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroPacientes.Helper;
using RegistroPacientes.Controller.Login;
using System.Drawing.Text;

namespace RegistroPacientes.View.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            ControllerLogin control = new ControllerLogin(this);
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            picShowPassword.Visible = false;
        }
    }
}
