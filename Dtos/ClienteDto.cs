using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesNuevosC_.Dtos
{
    /// <summary>
    /// clase que se guarada las listas
    /// </summary>
    internal class ClienteDto
    {
        long idCliente;//PK
        private string nombreCliente= "aaaaa";
        private string apellidoCliente ="aaaaa";
        private string dni = "aaaaa";//UNIVOCO
        private string fechaNaciomientoCliente= "9999/12/31";
        private string emailCliente = "aaaaa";
        private int tlfCliente = 111111111;
        private string fchAltaCliente = "9999/12/31";
        private string fchBajaCliente = "9999/12/31";


        //getters y setters
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FechaNaciomientoCliente { get => fechaNaciomientoCliente; set => fechaNaciomientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }



        //constructores(metodo que crea objetos)
        /// <summary>
        /// metodo, constructor de la lista cliente
        /// </summary>
        /// <param name="nombreCliente"></param>
        /// <param name="apellidoCliente"></param>
        /// <param name="dni"></param>
        /// <param name="fechaNaciomientoCliente"></param>
        /// <param name="emailCliente"></param>
        /// <param name="tlfCliente"></param>
        /// <param name="fchAltaCliente"></param>
        /// <param name="fchBajaCliente"></param>
        public ClienteDto(string nombreCliente, string apellidoCliente, string dni, string fechaNaciomientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente, string fchBajaCliente)
        {
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.dni = dni;
            this.fechaNaciomientoCliente = fechaNaciomientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
        }
        /// <summary>
        /// metodo, contructor por defecto
        /// 151123-amd
        /// </summary>
        public ClienteDto() { }
        //ToString
        override
            public string ToString()
        {
            string clienteString = "Nombre:   " + this.nombreCliente +
                "Apellidos:   " + this.apellidoCliente +
                "DNI:   " + this.dni +
                "fecha de nacimiento:   " + this.FechaNaciomientoCliente +
                "email:   " + this.tlfCliente +
                "fecha alta cliente" + this.fchAltaCliente
                + "fecha baja cliente:   " + this.fchBajaCliente;
            return clienteString;
        }
    
        
   /*    public string tostring()
        {
            string objstring = "   " + this.nombreCliente + "   " + this.apellidoCliente + "   " + this.dni + "   " + this.fechaNaciomientoCliente + "   " + this.emailCliente + "   " + this.fchAltaCliente + "   " + this.fchBajaCliente;
            return objstring;
        }
    */}
}
