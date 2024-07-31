using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPacientes.Models.DTO
{
    internal class DTOAdminInventory : dbContext
    {
        private int cantidadMedicamento;
        private int idMedicamento;
        private string nombreMedicamento;
        private string existencia;
        private DateTime fechaVencimiento;
        private DateTime ingreso;
        private string salida;
        private string descripcion;
        private int idCategoria;

        public string NombreMedicamento { get => nombreMedicamento; set => nombreMedicamento = value; }
        public string Existencia { get => existencia; set => existencia = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public DateTime Ingreso { get => ingreso; set => ingreso = value; }
        public string Salida { get => salida; set => salida = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdMedicamento { get => idMedicamento; set => idMedicamento = value; }
        public int CantidadMedicamento { get => cantidadMedicamento; set => cantidadMedicamento = value; }
    }
}
