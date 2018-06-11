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
        List<producto> entrada = new List<producto>();
        int indice = 0; // me dice en que posicion esta el que debo modificar
        int actualizar = 0; //si es 0 es un producto nuevo, si es 1 se va a actualizar  el producto
        public viewProducto() //crea mi formulario sin ningun dato
        {
            actualizar = 0;
            InitializeComponent();
        }
        public viewProducto(List<producto> editar, int posicion) //crea mi formulario pasando los tados del producto y la posicion en la que se encuentra
        {
            entrada = editar;
            indice = posicion;
            actualizar = 1; //voy a modificar los datos que mandan
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            if (actualizar == 1)
            {
                tbNombre.Text = entrada[indice].Nombre;
                txtCodigo.Text = entrada[indice].Codigo;
                tbCosto.Text = Convert.ToString(entrada[indice].Costo);
                tbPrecio.Text = Convert.ToString(entrada[indice].Precio);
                tbCantidad.Text = Convert.ToString(entrada[indice].Cantidad);
            }
            
        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string archivo = "productos.txt";
            if (tbNombre.Text != "") //valido que no este vacio este campo
            {
                if(tbCosto.Text != "") //valido que no este vacio este campo
                {
                    if(tbPrecio.Text != "") //valido que no este vacio este campo
                    {
                        if (tbCantidad.Text != "") //valido que no este vacio este campo
                        {
                            if (actualizar == 0) // es producto nuevo
                            {
                                FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
                                StreamWriter writer = new StreamWriter(stream);
                                // si estos campos estan llenos procedo a guardar los datos
                                writer.WriteLine(tbNombre.Text);
                                writer.WriteLine(txtCodigo.Text);
                                writer.WriteLine(tbCosto.Text);
                                writer.WriteLine(tbPrecio.Text);
                                writer.WriteLine(tbCantidad.Text);
                                MessageBox.Show("Registro  nuevo agregado");
                                writer.Close();
                            }
                            if (actualizar == 1) //se va a editar
                            {
                                FileStream stream = new FileStream(archivo, FileMode.Create, FileAccess.Write);
                                StreamWriter writer = new StreamWriter(stream);
                                entrada[indice].Nombre = tbNombre.Text;
                                entrada[indice].Codigo = txtCodigo.Text;
                                entrada[indice].Costo = float.Parse(tbCosto.Text);
                                entrada[indice].Precio = float.Parse(tbPrecio.Text);
                                entrada[indice].Cantidad = Convert.ToInt32(tbCosto.Text);
                                for (int i =0; i < entrada.Count; i++)
                                {
                                    writer.WriteLine(entrada[i].Nombre);
                                    writer.WriteLine(entrada[i].Codigo);
                                    writer.WriteLine(Convert.ToString(entrada[i].Costo));
                                    writer.WriteLine(Convert.ToString(entrada[i].Precio));
                                    writer.WriteLine(Convert.ToString(entrada[i].Cantidad));
                                }
                                MessageBox.Show("Registro  ACTUALIZADO agregado");
                                writer.Close();
                            }
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
        }

        public void nuevo()
        {

        }
        public void limpiar()
        {
            tbNombre.Text = "";
            tbCosto.Text = "";
            txtCodigo.Text = "";
            tbPrecio.Text = "";
            tbCantidad.Text = "";
        }
    }
}
