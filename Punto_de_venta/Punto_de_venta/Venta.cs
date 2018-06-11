using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta
{
    class Venta
    {
        DetalleVenta detalle;
        clientes cliente;
        DateTime fecha;
        float dinero;
        float vuelto;
        Usuario cajero;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Dinero { get => dinero; set => dinero = value; }
        public float Vuelto { get => vuelto; set => vuelto = value; }
        internal DetalleVenta Detalle { get => detalle; set => detalle = value; }
        internal clientes Cliente { get => cliente; set => cliente = value; }
        internal Usuario Cajero { get => cajero; set => cajero = value; }
    }
}
