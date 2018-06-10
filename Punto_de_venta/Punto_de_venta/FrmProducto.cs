using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class FrmProducto : Form
    {
        List<producto> entrada = new List<producto>(); //Lista de productos total
        int indice = 0; // me dice en que posicion esta el que debo modificar
        int actualizar = 0;
        public FrmProducto()
        {
            InitializeComponent();
        }
        public FrmProducto(List<producto> editar, int posicion)
        {
            actualizar = 1;
            entrada = editar;
            indice = posicion;
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); //limpio el panel para agregar un nuevo View
            if (actualizar == 0)
            {
                var formulario = new viewProducto();
                panel1.Controls.Add(formulario); //agrego el view al panel
                formulario.Dock = DockStyle.Fill; ///hace que la pantalla se ajuste al espacio
            }
            else
            {
                var formulario = new viewProducto(entrada, indice);
                panel1.Controls.Add(formulario); //agrego el view al panel
                formulario.Dock = DockStyle.Fill; ///hace que la pantalla se ajuste al espacio
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
