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
    public partial class Home : Form
    {
        int tipoUsuario = 0;// sI ES 1 es administrador , si es 2 es vendedor
        public Home()
        {
            InitializeComponent();
        }
        public Home(int type)
        {
            InitializeComponent();
            tipoUsuario = type;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); //limpio el panel para agregar un nuevo View
            var productos = new ListadoProductos();
            panel2.Controls.Add(productos); //agrego el view al panel
            productos.Dock = DockStyle.Fill; // hace que la pantalla se ajuste al espacio
        }

        private void Home_Load(object sender, EventArgs e)
        {
            mostrarBotones(tipoUsuario);
        }

        public void mostrarBotones(int tipo)
        {
            if (tipo == 2)
            {
                btn_Productos.Enabled = false;
                btn_Productos.Visible = false;
            }
        }

        private void bt_ventas_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
        }
    }
}
