﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroPacientes.Models;

namespace RegistroPacientes.Models.DTO
{
     class DTOAdminPatience : dbContext
    {
        //***** PACIENTE ********
        private int TipoPersona;
        private string nombrePaciente;
        private string apellidoPaciente;
        private int IdTipoPersona;
        //****** Estudiante *****
        private int idPaciente;
        private string codigo;
        private int idEspecialidad;
        private int idGrado;
        private int idSeccion;
        //****** Personal de la Institución *****

        //private int 


        public int TipoPersona1 { get => TipoPersona; set => TipoPersona = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string ApellidoPaciente { get => apellidoPaciente; set => apellidoPaciente = value; }
        public int IdTipoPersona1 { get => IdTipoPersona; set => IdTipoPersona = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public int IdGrado { get => idGrado; set => idGrado = value; }
        public int IdSeccion { get => idSeccion; set => idSeccion = value; }
    }
}
