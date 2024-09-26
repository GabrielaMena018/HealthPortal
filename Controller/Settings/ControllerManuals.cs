using HealthPortal.View.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Controller.Settings
{
    internal class ControllerManuals
    {
        FrmManuals objManual = new FrmManuals();

        public ControllerManuals(FrmManuals view)
        {
            objManual = view;
        }
    }
}
