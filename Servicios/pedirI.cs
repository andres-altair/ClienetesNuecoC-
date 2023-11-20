using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientesNuevosC_.Dtos;

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
        public void darAltaCliente(List<ClienteDto> listaAntigua);


    }
}
