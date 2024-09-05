using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Model.DTO
{
    internal class DTOSettings
    {
        private string customServer;
        private string customDataBase;
        private string customUsername;
        private string customPassword;

        public string CustomServer { get => customServer; set => customServer = value; }
        public string CustomDataBase { get => customDataBase; set => customDataBase = value; }
        public string CustomUsername { get => customUsername; set => customUsername = value; }
        public string CustomPassword { get => customPassword; set => customPassword = value; }
    }
}
