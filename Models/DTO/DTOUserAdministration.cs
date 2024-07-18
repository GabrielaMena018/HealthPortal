using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPacientes.Models.DTO
{
    internal class DTOUserAdministration : dbContext
    {
        // Atributos de tbRoles
        private int idRol;
        private string nombreRol;

        // Atributos de tbUsuarios
        private string usuario;
        private string contrasena;
        private bool estadoUsuario;
        private int intentosUsuario;

        // Atributos de tbPersonas
        private int idPersona;
        private string nombrePersona;
        private string apellidoPersona;
        private string correoPersona;
        private string telefonoPersona;

        // Getter y Setter de cada atributo
        public int IdRol { get => idRol; set => idRol = value; }
        public string NombreRol { get => nombreRol; set => nombreRol = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public bool EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
        public int IntentosUsuario { get => intentosUsuario; set => intentosUsuario = value; }
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string NombrePersona { get => nombrePersona; set => nombrePersona = value; }
        public string ApellidoPersona { get => apellidoPersona; set => apellidoPersona = value; }
        public string CorreoPersona { get => correoPersona; set => correoPersona = value; }
        public string TelefonoPersona { get => telefonoPersona; set => telefonoPersona = value; }
    }
}
