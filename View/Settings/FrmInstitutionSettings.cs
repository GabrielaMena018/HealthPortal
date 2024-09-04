﻿using HealthPortal.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPortal.Controller.Settings;

namespace HealthPortal.View.Settings
{
    public partial class FrmInstitutionSettings : Form
    {
        public FrmInstitutionSettings()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CommonMethods.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ControllerInstitutionSettings control = new ControllerInstitutionSettings(this);
        }
    }
}
