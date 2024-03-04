using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoliazC.Dtos
{
    internal class VentasDto
    {
        long id;
        string nombreVenta = "aaaaa";
        int cantidad = 99999;
        int precio = 99999;
        int total;
        DateTime fecha= DateTime.Now;   
      

        public VentasDto() { }
        public VentasDto(long id,string nombreVenta, int cantidad, int precio)
        {
            this.id = id;
            this.nombreVenta = nombreVenta;
            this.cantidad = cantidad;
            this.precio = precio;
            this.total = cantidad*precio;
            this.fecha = fecha;
            
        }

        public string NombreVenta { get => nombreVenta; set => nombreVenta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
        public long Id { get => id; set => id = value; }
        public int Total { get => total; set => total = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        override 
        public string ToString()
        {
            string a = "……….\n" +
                "Venta numenero: " + this.id + "\n" +
                "Euros: " + this.total + " euros\n" +
                "Instante de compra: " + this.fecha.ToString("dd-MM-yyyy hh:mm:ss");
            return a;

        }
    }
}
