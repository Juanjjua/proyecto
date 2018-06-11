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
    public partial class ListadoProductos : UserControl
    {
        List<producto> listado = new List<producto>(); //creo una variable global tipo producto para guardar todos los productos
        public ListadoProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmProducto().ShowDialog();
        }
    
        private void ListadoProductos_Load(object sender, EventArgs e)
        {
            actualizar();
        }
        public void actualizar () //actualiza los datos que estan en el archivo productos y los agrega a la lista declarada arriba
        {
            string archivo = "productos.txt";
            FileStream leer = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader lectura = new StreamReader(leer);
            while (lectura.Peek() > -1) //Leo todos las filas del archivo
            {
                producto temp = new producto();
                temp.Nombre = lectura.ReadLine();
                temp.Codigo = lectura.ReadLine();
                temp.Costo = float.Parse(lectura.ReadLine());
                temp.Precio = float.Parse(lectura.ReadLine());
                temp.Cantidad = Convert.ToInt32(lectura.ReadLine());
                listado.Add(temp); //agrego a la lista de productos
            }
            lectura.Close();
            dataGridView1.DataSource = null; //vacio el datagrid para que borre los datos anteriores
            dataGridView1.Refresh();
            dataGridView1.DataSource = listado; // lo lleno con los datos del listado que he reunido en la fucion while
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmProducto(listado, dataGridView1.CurrentRow.Index).Show();
            label1.Text = Convert.ToString(dataGridView1.CurrentRow.Index);
        }
    }
}
