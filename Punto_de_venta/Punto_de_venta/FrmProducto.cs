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
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); //limpio el panel para agregar un nuevo View
            var formulario = new viewProducto();
            panel1.Controls.Add(formulario); //agrego el view al panel
            formulario.Dock = DockStyle.Fill; ///hace que la pantalla se ajuste al espacio
        }
    }
}
