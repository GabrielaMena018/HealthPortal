//*3*
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegistroPacientes.Models.DTO
{
     class DTOAdminGrade : dbContext
    {
        //Atributos
        private int idSeccion;
        private string grupoTecnico;
        private int idgrado;
        private string SeccionAcademica;
        private string Especialidad;
        private int idEspecialidad;
        private int idSeccionAcademica;
        
 

        public int IdSeccion { get => idSeccion; set => idSeccion = value; }
        public string GrupoTecnico { get => grupoTecnico; set => grupoTecnico = value; }
        public int IdGrado { get => idgrado; set => idgrado = value; }
        public string SeccionAcademica1 { get => SeccionAcademica; set => SeccionAcademica = value; }
        public string Especialidad1 { get => Especialidad; set => Especialidad = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public int IdSeccionAcademica { get => idSeccionAcademica; set => idSeccionAcademica = value; }
    }
}
