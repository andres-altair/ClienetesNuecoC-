using ClientesNuevosC_;
using ClientesNuevosC_.Servicios;

namespace ClientesNuevosC_
{
    class program
    {
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

                }
            }
        }
    }
}