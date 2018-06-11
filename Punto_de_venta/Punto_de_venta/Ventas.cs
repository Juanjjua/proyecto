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
    public partial class Ventas : UserControl
    {
        List<clientes> listadoClientes = new List<clientes>();
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            string archivo = "clientes.txt";
            FileStream leer = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader lectura = new StreamReader(leer);
            while (lectura.Peek() > -1) //leo todas las filas del archivo de usuarios y voy a guardarla en una lista de tipo clientes
            {
                clientes temp = new clientes();
                temp.Nit = lectura.ReadLine();
                temp.Nombre = lectura.ReadLine();
                listadoClientes.Add(temp); //agrego a mi Lista de Clientes para tenerla lista
            }
            lectura.Close();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e) //funcion para guardar los datos del cliente en un archio
        {
            string archivo = "clientes.txt";
            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            StreamWriter write = new StreamWriter(stream);
            write.WriteLine(textBox1.Text);
            write.WriteLine(textBox2.Text);
            MessageBox.Show("Cliente agregado");
            write.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            for (int i = 0; i < listadoClientes.Count; i++)
            {
                if (listadoClientes[i].Nit == textBox1.Text)
                {
                    textBox2.Text = listadoClientes[i].Nombre;
                    encontrado = true;
                }
            }
            if (encontrado == false)
            {
                DialogResult result = MessageBox.Show("Desea guardar cliente", "Si", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    btnGuardar.Visible = true;
                }
                if (result == DialogResult.No)
                {
                    btnGuardar.Visible = false;
                }
            }
        }
    }
}
