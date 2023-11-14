using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesNuevosC_.Dtos
{
    internal class clienteA
    {
        private string nombreCliente;
        private string apellidoCliente;
        private string dni;
        private DateOnly fechaNaciomientoCliente;
        private string emailCliente;
        private int tlfCliente;
        private DateOnly fchAltaCliente;
        private DateOnly fchBajaCliente;

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateOnly FechaNaciomientoCliente { get => fechaNaciomientoCliente; set => fechaNaciomientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public DateOnly FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public DateOnly FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }
    }
}
