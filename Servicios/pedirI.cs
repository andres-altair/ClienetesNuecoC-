using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesNuevosC_.Servicios
{
    /// <summary>
    /// interfaz encargada de pedir cierta informacion del cliente
    /// 151123-amd
    /// </summary>
    internal interface pedirI
    {
        /// <summary>
        /// metodo que pide el nombre
        /// 151123-amd
        /// </summary>
        /// <returns>string</returns>
        public string pedirNombre();
        
        /// <summary>
        /// metodo que pide el apellido
        /// 151123-amd
        /// </summary>
        /// <returns>string</returns>
        public string pedirApellido();
        
        /// <summary>
        /// metodo que pide el dni
        /// 151123-amd
        /// </summary>
        /// <returns>string</returns>
        public string pedirDni();
        
        /// <summary>
        /// metodo que pide fecha de nacimiento e string
        /// 151123-amd
        /// </summary>
        /// <returns>string</returns>
        public string pedirFechaNacimiento();
        
        /// <summary>
        /// metodo que pide el email
        /// 151123-amd
        /// </summary>
        /// <returns>string</returns>
        public string pedirnEmail();
        
        /// <summary>
        /// metodo que pide fecha de alta
        /// 151123-amd
        /// </summary>
        /// <returns>string</returns>
        public string pedirFcAlta();
        
        /// <summary>
        /// metodo que pide el nombre
        /// 151123-amd
        /// </summary>
        /// <returns>string</returns>
        public string pedirFcBaja();

        /// <summary>
        /// metodo que pide el num. de telf.ç
        /// 151123-amd
        /// </summary>
        /// <returns>int</returns>
        public int pediryTlf();


    }
}
