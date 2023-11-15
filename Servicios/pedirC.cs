using ClientesNuevosC_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesNuevosC_.Servicios
{
    internal class pedirC : pedirI
    {
        clienteA cI = new clienteA();
        public string pedirApellido()
        {
            Console.WriteLine("escribe un apellido");
            string apellido = Console.ReadLine();
            cI.ApellidoCliente = apellido;
            return apellido;
        }

        public string pedirDni()
        {
            Console.WriteLine("");
        }

        public string pedirFcAlta()
        {
            Console.WriteLine("");
        }

        public string pedirFcBaja()
        {
            Console.WriteLine("");
        }

        public string pedirFechaNacimiento()
        {
            Console.WriteLine("");
        }

        public string pedirNombre()
        {
            Console.WriteLine("");
        }

        
        public void darAltaCliente(List<clienteA> listaAntigua)
        {
            Console.WriteLine("");
        }

        public string pedirnEmail()
        {
            Console.WriteLine("");
        }

        public int pediryTlf()
        {
            Console.WriteLine("");
        }
    }
}
