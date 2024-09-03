using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HealthPortal.Model.DTO
{
     class DTOSectionAdministration : dbContext
    {
        //Atributos
        private int idSeccion;
        private string grupoTecnico;
        private int idGrado;
        private string seccionAcademica;
        private string especialidad;
        private int idEspecialidad;
        private int idSeccionAcademica;

        public int IdSeccion { get => idSeccion; set => idSeccion = value; }
        public string GrupoTecnico { get => grupoTecnico; set => grupoTecnico = value; }
        public int IdGrado { get => idGrado; set => idGrado = value; }
        public string SeccionAcademica { get => seccionAcademica; set => seccionAcademica = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public int IdSeccionAcademica { get => idSeccionAcademica; set => idSeccionAcademica = value; }
    }
}
