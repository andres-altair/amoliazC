﻿using amoliazC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliazC.Servicios
{
    /// <summary>
    /// implemtacion que implementa GerenteInterfaz
    /// 040324-amd
    /// </summary>
    internal class GerenteImplementacion : GerenteInterfaz
    {
        public void escribirFichero(List<VentasDto> listaVenta)
        {
            Console.WriteLine("ecribe una fecha(dd-MM-yyyy)");
            DateTime fechaIntroducida = Convert.ToDateTime(Console.ReadLine());
            string file= fechaIntroducida.ToString()+".txt";
            StreamWriter sw = new StreamWriter(file);
            foreach (VentasDto ventas in listaVenta)
            {
                if (fechaIntroducida == ventas.Fecha)
                {
                    sw.WriteLine(ventas.ToString());
                }              
            };
            sw.Close();
        }
        /// <summary>
        /// metodo que se encarga de crear un id automaticamente
        /// 040324-amd
        /// </summary>
        /// <param name="listaVenta">tipo EncargosDto</param>
        /// <returns>tipo long</returns>
        private long crearId(List<EncargosDto> listaEncargos)
        {
            long id = 0;
            int tamanio = listaEncargos.Count;
            foreach (EncargosDto encargos in listaEncargos)
            {
                if (tamanio == 0)
                {
                    id = 0;
                }
                else
                {
                    id = encargos.Id + 1;
                }
            }
            return id;
        }
        public void hacerPedido(List<EncargosDto> listaEncargos)
        {
            string a = "si";
            do
            {
                long id =crearId(listaEncargos);
                Console.WriteLine("escribe el nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("cantidad");
                int cantidad= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("fecha (dd-MM-yyyy)");
                DateTime fecha= Convert.ToDateTime(Console.ReadLine());
                EncargosDto encargosDto = new EncargosDto(id,nombre,cantidad,fecha);
                Console.WriteLine("quieres seguir(si/no)");
                a =Console.ReadLine();

            } while (a == "si");
            EncargosDto encargos = new EncargosDto();
            Console.WriteLine(encargos.ToString());
            
        }
    }
}
