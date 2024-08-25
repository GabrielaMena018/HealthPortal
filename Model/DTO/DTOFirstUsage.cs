using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Model.DTO
{
    internal class DTOFirstUsage : dbContext
    {
        // Atributos de tbUsuarios y tbPersonas
        private string name;
        private string lastName;
        private string email;
        private string phone;
        private string username;
        private string password;
        private int personID;

        // Atributos de tbInstitución
        private string institutionName;
        private string institutionAddress;
        private byte[] institutionLogo;
        private byte[] institutionLocation;

        // Atributos de tbTokens
        private string token;
        private DateTime expirationDate;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int PersonID { get => personID; set => personID = value; }
        public string InstitutionName { get => institutionName; set => institutionName = value; }
        public string InstitutionAddress { get => institutionAddress; set => institutionAddress = value; }
        public byte[] InstitutionLogo { get => institutionLogo; set => institutionLogo = value; }
        public byte[] InstitutionLocation { get => institutionLocation; set => institutionLocation = value; }
        public string Token { get => token; set => token = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
    }
}
