using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroPacientes.Models;

namespace RegistroPacientes.Models.DTO
{
     internal class DTOAdminPatience : dbContext
    {
        //Atributos

        //Paciente
        private int idPatient;
        private string name;
        private string lastName;
        private int rol;

        //Estudiante
        private string code;
        private int idGradeSection;

        //Grade seccion
        private string groupTechnical;
        private int specialty;
        private int grade;
        private int seccionAcademica;


        //Visita
        private int Idpaciente;
        private DateTime date;
        private string time;
        private int medicamento;
        private string observacion;

        //Metodos
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Rol { get => rol; set => rol = value; }
        public string Code { get => code; set => code = value; }
        public int IdGradeSection { get => idGradeSection; set => idGradeSection = value; }
        public string GroupTechnical { get => groupTechnical; set => groupTechnical = value; }
        public int Specialty { get => specialty; set => specialty = value; }
        public int Grade { get => grade; set => grade = value; }
        public int SeccionAcademica { get => seccionAcademica; set => seccionAcademica = value; }
        public int Idpaciente1 { get => Idpaciente; set => Idpaciente = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public int Medicamento { get => medicamento; set => medicamento = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int IdPaciente { get => idPatient; set => idPatient = value; }

    }
}
