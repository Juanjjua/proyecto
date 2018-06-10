using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta
{
    class producto
    {
        string nombre;
        Int32 cantidad;
        float precio;
        float costo;
        string codigo;

        public producto(string nombre, int cantidad, float precio, float costo, string codigo)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Costo = costo;
            this.Codigo = codigo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public float Costo { get => costo; set => costo = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
