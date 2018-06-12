using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta
{
    public class producto
    {
        string nombre;
        Int32 cantidad;
        float precio;
        float costo;
        string codigo;
        int cantidadVentas;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public float Costo { get => costo; set => costo = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int CantidadVentas { get => cantidadVentas; set => cantidadVentas = value; }
    }
}
