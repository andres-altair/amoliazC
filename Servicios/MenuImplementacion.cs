using amoliazC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliazC.Servicios
{
    /// <summary>
    /// implementacion que implementa a menuInterfaz
    /// 040324-amd
    /// </summary>
    internal class MenuImplementacion : MenuIntefaz
    {
        List<VentasDto> listaVentas = new List<VentasDto>();
        List<EncargosDto> listaEncargos = new List<EncargosDto>();
        public int menu()
        {
            Console.WriteLine("0.cerrar");
            Console.WriteLine("1. menu Empledo");
            Console.WriteLine("2. menu gerente");
            int eleccion= Convert.ToInt32(Console.ReadLine());
            return eleccion;
        }
        /// <summary>
        /// metodo que se ncarga de la eleccion del menu empleado
        /// 040324-amd
        /// </summary>
        /// <returns>tipo int</returns>
        private int menuPrivadoEmpleado()
        {
            Console.WriteLine("0. volver");
            Console.WriteLine("1. añadir venta");
            Console.WriteLine("2. cálculo total de ventas diario");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            return eleccion;
        }
        public void menuEmpleado()
        {
            EmpleadoInterfaz ei = new EmpledoImplementacion();
            int eleccion = menuPrivadoEmpleado();
            switch(eleccion)
            {
                case 0: break;
                case 1: ei.anadirVenta(listaVentas); 
                    break;
                case 2: ei.calculoTotalVentasDiarios(listaVentas);  
                    break;
                default: Console.WriteLine("eleccion no reconocida"); 
                    break;

            }
        }
        /// <summary>
        /// metodo que se ncarga de la eleccion del menu gerente
        /// 040324-amd
        /// </summary>
        /// <returns>tipo int</returns>
        private int menuPrivadoGerente()
        {
            Console.WriteLine("0. volver");
            Console.WriteLine("1. escribir en un fichero todas las ventas del día");
            Console.WriteLine("2. crear un nuevo pedido para proveedores");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            return eleccion;
        }
        public void menuGerencia()
        {
            GerenteInterfaz gi = new GerenteImplementacion();
           int eleccion=menuPrivadoGerente();
            switch(eleccion)
            {
                case 0: break;
                case 1: gi.escribirFichero(listaVentas); 
                    break;
                case 2: gi.hacerPedido(listaEncargos); 
                    break;
                default:Console.WriteLine("eleccion no reconocida");
                    break;

            }
        }
    }
}
