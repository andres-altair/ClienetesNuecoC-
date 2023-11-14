using ClientesNuevosC_;
using ClientesNuevosC_.Dtos;
using ClientesNuevosC_.Servicios;

namespace ClientesNuevosC_
{
    /// <summary>
    /// clase pricipal 
    /// amd-141123
    /// </summary>
    class program
    {
        List<clienteA> listadto = new List<clienteA>();
        /// <summary>
        /// clase pricipal 
        /// amd-141123
        /// </summary>
        public static void Main(string[] args)
        {
            menuI mI = new menuC();
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
                        listadto.Add();
                        



                }
            }
        }
    }
}