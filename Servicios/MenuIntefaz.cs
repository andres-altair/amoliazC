using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliazC.Servicios
{
    /// <summary>
    /// 040324-amd
    /// interfaz encargada de de la gestion de los menus
    /// </summary>
    internal interface MenuIntefaz
    {
        /// <summary>
        /// metodo que se encarga del menu principal
        /// 040324-amd
        /// </summary>
        /// <returns>tipo int</returns>
        public int menu();
        /// <summary>
        /// metodo que se encarga del menu del empleado
        /// 040324-amd
        /// </summary>
        public void menuEmpleado();
        /// <summary>
        /// metodo que se encarga del menu de la gerencia
        /// 040324-amd
        /// </summary>
        public void menuGerencia();
    }
}
