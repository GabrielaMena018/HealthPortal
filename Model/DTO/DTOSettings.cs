using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPortal.Model.DTO
{
    internal class DTOSettings : dbContext
    {
        private int questionID;
        private string question;

        public int QuestionID { get => questionID; set => questionID = value; }
        public string Question { get => question; set => question = value; }
    }
}
