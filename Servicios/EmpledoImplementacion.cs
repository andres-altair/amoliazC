using amoliazC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliazC.Servicios
{
    /// <summary>
    /// 040324-amd
    /// implemtacion de EmpleadoInterfaz
    /// </summary>
    internal class EmpledoImplementacion : EmpleadoInterfaz
    {
        /// <summary>
        /// metodo que se encarga de crear un id automaticamente
        /// 040324-amd
        /// </summary>
        /// <param name="listaVenta">tipo VentaDto</param>
        /// <returns>tipo long</returns>
        private long crearId(List<VentasDto> listaVenta)
        {
            long id = 0;
            int tamanio =listaVenta.Count;
            foreach(VentasDto ventas in listaVenta)
            {
                if (tamanio == 0)
                {
                    id= 0;  
                }
                else
                {
                    id = ventas.Id + 1;
                }
            }
            return id;
        }
        public void anadirVenta(List<VentasDto> listaventa)
        {
            
            long id = crearId(listaventa);
            Console.WriteLine("nombre de la venta");
            string nombre = Console.ReadLine();
            Console.WriteLine("cantidad a vender");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("precio del producto");
            int precio= Convert.ToInt32(Console.ReadLine());
            VentasDto venta = new VentasDto(id,nombre,cantidad,precio);
            listaventa.Add(venta);
        }

        public void calculoTotalVentasDiarios(List<VentasDto> listaventa)
        {
            Console.WriteLine("ecribe una fecha(dd-MM-yyyy)");
            DateTime fechaIntroducida = Convert.ToDateTime(Console.ReadLine());
            foreach(VentasDto ventas in listaventa)
            {
                DateTime fecha1=DateTime.Now;
                DateTime fecha2=DateTime.Now;
                if (ventas.Fecha == fechaIntroducida)
                {
                    if(ventas.Id == 1)
                    {
                        DateTime id1= ventas.Fecha ;
                        fecha1 = id1;
                    }
                    if(ventas.Id == listaventa.Count)
                    {
                        DateTime id2 = ventas.Fecha ;
                        fecha2 = id2;   
                    }
                    TimeSpan duracion = fecha1 - fecha2;
                    double sd = duracion.TotalSeconds;
                    int s = (int)sd;
                    double md = duracion.TotalMinutes;
                    int m = (int)md;
                    double hd = duracion.TotalHours;
                    int h = (int)hd;
                    Console.WriteLine("Total ventas: " + ventas.Total + "\n"+
                     "Tiempo transcurrido: " + h + " horas " + s + " minutos " + s + " segundos");
                }
            }
        }
    }
}
