using ClientesNuevosC_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientesNuevosC_.Dtos;

namespace ClientesNuevosC_.Servicios
{
    internal class pedirC : pedirI
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            
        }
        private ClienteDto crearNuevoCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("introduzca el id");
            nuevoCliente.IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("introduzca el nombre");
            nuevoCliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("introduzca el apellido");
            nuevoCliente.ApellidoCliente = Console.ReadLine();
            Console.WriteLine("introduzca el DNI   ");
            nuevoCliente.Dni = Console.ReadLine();
            Console.WriteLine("introduzca el fecha de naciomiento");
            nuevoCliente.FechaNaciomientoCliente = Console.ReadLine();
            Console.WriteLine("introduzca el email");
            nuevoCliente.EmailCliente = Console.ReadLine();
            Console.WriteLine("introduzca el numero de telefono");
            nuevoCliente.TlfCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca el fecha alat de cliente");
            nuevoCliente.FchAltaCliente = Console.ReadLine();

        } 
    }
}
        