using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta
{
    public class ListaVendorFecha
    {
        private DateTime fecha;
        private float total;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Total { get => total; set => total = value; }
    }
}
