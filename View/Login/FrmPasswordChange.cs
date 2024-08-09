using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Controller.Login;
using HealthPortal.Helper;

namespace HealthPortal.View.Login
{
    public partial class FrmPasswordChange : Form
    {
        public FrmPasswordChange(int procedure)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerPasswordChange control = new ControllerPasswordChange(this, procedure);
        }
        public FrmPasswordChange(int procedure, string username)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerPasswordChange control = new ControllerPasswordChange(this, procedure, username);
        }
    }
}