using amoliazC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliazC.Servicios
{
    /// <summary>
    /// interfaz encargada en las acciones del empleado
    /// 040324-amd
    /// </summary>
    internal interface EmpleadoInterfaz
    {
        /// <summary>
        /// metodo que se encarga de añadir ventas
        /// 040324-amd
        /// </summary>
        /// <param name="listaventa"> tipo VentasDto</param>
        public void anadirVenta(List<VentasDto> listaventa);
        /// <summary>
        /// metodo que se encarga de calcular el total de ventas diarias
        /// 040324-amd
        /// </summary>
        /// <param name="listaventa">tipo Ventasdto</param>
        public void calculoTotalVentasDiarios(List<VentasDto> listaventa);
    }
}
