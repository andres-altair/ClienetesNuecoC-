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
        private string fechaNaciomientoCliente;
        private string emailCliente;
        private int tlfCliente;
        private string fchAltaCliente;
        private string fchBajaCliente;

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FechaNaciomientoCliente { get => fechaNaciomientoCliente; set => fechaNaciomientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }

        public clienteA(string nombreCliente, string apellidoCliente, string dni, string fechaNaciomientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente, string fchBajaCliente)
        {
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.dni = dni;
            this.fechaNaciomientoCliente = fechaNaciomientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
            this.fchBajaCliente = fchBajaCliente;
        }
        public string tostring()
        {
            string objstring = "   " + this.nombreCliente + "   " + this.apellidoCliente + "   " + this.dni + "   " + this.fechaNaciomientoCliente + this.emailCliente + this.
        }
    }
}
