using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta
{
    class VentasPorMes
    {
        DateTime fecha;
        string NIT;
        string cliente;
        float total;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string NIT1 { get => NIT; set => NIT = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public float Total { get => total; set => total = value; }
    }
}
