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
        private int idPaciente;
        private string nombre;
        private string apellido;
        private int rol;

        //Estudiante
        private string codigo;
        private int idGradoSeccion;

        //Grado seccion
        private string grupoTecnico;
        private int especialidad;
        private int grado;
        private int seccionAcademica;

        //Personal de la Institucion
        private string documento;
        private int idArea;

        //Visita
        private int Idpaciente;
        private DateTime fecha;
        private string hora;
        private int medicamento;
        private string observacion;

        //Metodos
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Rol { get => rol; set => rol = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int IdGradoSeccion { get => idGradoSeccion; set => idGradoSeccion = value; }
        public string GrupoTecnico { get => grupoTecnico; set => grupoTecnico = value; }
        public int Especialidad { get => especialidad; set => especialidad = value; }
        public int Grado { get => grado; set => grado = value; }
        public int SeccionAcademica { get => seccionAcademica; set => seccionAcademica = value; }
        public int Idpaciente1 { get => Idpaciente; set => Idpaciente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Medicamento { get => medicamento; set => medicamento = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string Documento { get => documento; set => documento = value; }
        public int IdArea { get => idArea; set => idArea = value; }
    }
}
