using amoliazC.Servicios;

namespace amoliazC.Controladores
{
    /// <summary>
    /// clase pricipal
    /// 040324-amd
    /// </summary>
    class Program
    {
        /// <summary>
        /// metodo principal
        /// 040324-amd
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            MenuIntefaz mi = new MenuImplementacion();
            int eleccion;
            bool abrir = false;
            while(!abrir)
            {
                eleccion = mi.menu();
                switch(eleccion) 
                { 
                    case 0: abrir = true; 
                        break;
                    case 1: mi.menuEmpleado();
                        break;
                    case 2: mi.menuGerencia();
                        break;
                    default:Console.WriteLine("eleccion no reconocida");
                        break;

                }

            }
        }
    }
}
