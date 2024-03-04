using amoliazC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliazC.Servicios
{
    /// <summary>
    /// interfaz encraga de las acciones del gerente
    /// 040324-amd
    /// </summary>
    internal interface GerenteInterfaz
    {
        /// <summary>
        /// metodo que se encarga de crear un fichero
        /// 040324-amd
        /// </summary>
        /// <param name="listaVenta">tipo VentasDto</param>
        public void escribirFichero(List<VentasDto> listaVenta);
        /// <summary>
        /// metodo que se encarga de hacer un pedido
        /// 040324-amd
        /// </summary>
        /// <param name="listaEncargos">tipo EncargosDto</param>
        public void hacerPedido(List<EncargosDto> listaEncargos);
    }
}
