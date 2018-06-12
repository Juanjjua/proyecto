using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta
{
    class Venta
    {
        string codigo;
        clientes cliente;
        DateTime fecha;
        Usuario cajero;
        float total;
        float dinero;
        float vuelto;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Dinero { get => dinero; set => dinero = value; }
        public float Vuelto { get => vuelto; set => vuelto = value; }
        public float Total { get => total; set => total = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        internal clientes Cliente { get => cliente; set => cliente = value; }
        internal Usuario Cajero { get => cajero; set => cajero = value; }
    }
}
