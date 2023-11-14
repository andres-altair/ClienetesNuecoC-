using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesNuevosC_.Servicios
{
    internal class menuC : menuI
    {
        public int menuCl()
        {
            int seleccion;
            Console.WriteLine("0. cerrar");
            Console.WriteLine("1. añadir cliente");           
            seleccion = Console.ReadKey(true).KeyChar - ('0');
            return seleccion;
        }
    }
}
