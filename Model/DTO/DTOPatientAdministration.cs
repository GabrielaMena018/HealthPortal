using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroPacientes.Model;

namespace RegistroPacientes.Model.DTO
{
     internal class DTOPatientAdministration : dbContext
    {
        //Atributos

        //Paciente
        private int idPatient;
        private string name;
        private string lastName;
        private int role;

        //Estudiante
        private string code;
        private int idGradeSection;

        //Grade seccion
        private string technicalGroup;
        private int specialty;
        private int grade;
        private int academicSection;


        //Visita
        private DateTime date;
        private string time;
        private int medicine;
        private string observation;

        //Metodos
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Role { get => role; set => role = value; }
        public string Code { get => code; set => code = value; }
        public int IdGradeSection { get => idGradeSection; set => idGradeSection = value; }
        public string TechnicalGroup { get => technicalGroup; set => technicalGroup = value; }
        public int Specialty { get => specialty; set => specialty = value; }
        public int Grade { get => grade; set => grade = value; }
        public int AcademicSection { get => academicSection; set => academicSection = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public int Medicine { get => medicine; set => medicine = value; }
        public string Observation { get => observation; set => observation = value; }
        public int IdPatient { get => idPatient; set => idPatient = value; }

    }
}
