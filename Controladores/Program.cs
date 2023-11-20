using ClientesNuevosC_;
using ClientesNuevosC_.Dtos;
using ClientesNuevosC_.Servicios;
using System.Timers;

namespace ClientesNuevosC_
{
    /// <summary>
    /// clase pricipal 
    /// amd-141123
    /// </summary>
    class program
    {
        List<ClienteDto> listaDTO = new List<ClienteDto>();
        /// <summary>
        /// clase pricipal 
        /// amd-141123
        /// </summary>
        public static void Main(string[] args)
        {
            menuI mI = new menuC();
            pedirI pI = new pedirC();
            int elegida = mI.menuCl();
            bool cerrarMenu = false;    
            while (!cerrarMenu)
            {
                switch (elegida)
                {
                    case 0:
                        cerrarMenu = true;  
                        break;
                    case 1:
                        Console.WriteLine("escribe tu apellido");
                        pI.darAltaCliente();
                        foreach(ClienteDto cliente in listaCliente)
                        {
                            Console.WriteLine(cliente.ToString);
                        }
                            break;
                    case 2:
                        Console.WriteLine("");





                }
            }
        }
    }
}
//dar alta una nueva cuenta bancaria ,
//tiene que terner un campo que identifique al usuario de esa cuenta bancaria
//id, isban, codigo switch del banco, a que cliente le pertenece esa cuenta bancaria , fecha alta y baja de la cuenta