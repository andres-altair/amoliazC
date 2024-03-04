using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliazC.Dtos
{
    internal class EncargosDto
    {
        long id;
        string nombre = "aaaaa";
        int cantidad = 99999;
        DateTime fecha = new DateTime(9999,12,31,23,59,59);

        public EncargosDto() { }
        public EncargosDto(long id,string nombre, int cantidad,DateTime fecha)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public long Id { get => id; set => id = value; }

        override
        public string ToString()
        {
            string a = "   \n" +
                "Producto: " + this.nombre + "\n" +
                "Cantidad: " + this.cantidad + " unidades\n" +
                "Fecha de entrega: " + this.fecha.ToString("dd-MM-yyyy ");
            return a;

        }
    }
}
