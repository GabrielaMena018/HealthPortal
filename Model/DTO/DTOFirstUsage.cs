using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Model.DTO
{
    internal class DTOFirstUsage : dbContext
    {
        private string name;
        private string lastName;
        private string email;
        private string phone;
        private string username;
        private string password;
        private int personID;
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int PersonID { get => personID; set => personID = value; }
    }
}
