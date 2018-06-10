using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class viewProducto : UserControl
    {
        public viewProducto()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string archivo = "productos.txt";
            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            if (tbNombre.Text != "") //valido que no este vacio este campo
            {
                if(tbCosto.Text != "") //valido que no este vacio este campo
                {
                    if(tbPrecio.Text != "") //valido que no este vacio este campo
                    {
                        if (tbCantidad.Text != "") //valido que no este vacio este campo
                        {
                            // si estos campos estan llenos procedo a guardar los datos
                            writer.WriteLine(tbNombre.Text);
                            writer.WriteLine(txtCodigo.Text);
                            writer.WriteLine(tbCosto.Text);
                            writer.WriteLine(tbPrecio.Text);
                            writer.WriteLine(tbCantidad.Text);
                            MessageBox.Show("Registro agregado");
                        }
                        else
                        {
                            MessageBox.Show("Error ingrese Cantidad");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error ingrese precio");
                    }

                }
                else
                {
                    MessageBox.Show("Error ingrese Costo");
                }
            }
            else
            {
                MessageBox.Show("Error ingrese Nombre");
            }
            writer.Close();
            tbNombre.Text = "";
            tbCosto.Text = "";
            txtCodigo.Text = "";
            tbPrecio.Text = "";
            tbCantidad.Text = "";
            
        }
    }
}
