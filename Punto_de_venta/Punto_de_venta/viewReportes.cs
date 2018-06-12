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
    public partial class viewReportes : UserControl
    {
        List<producto> listado = new List<producto>();
        List<Venta> ListaDeVentas = new List<Venta>();
        public viewReportes()
        {
            InitializeComponent();
        }

        private void viewReportes_Load(object sender, EventArgs e)
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
                temp.CantidadVentas = Convert.ToInt32(lectura.ReadLine());
                listado.Add(temp); //agrego a la lista de productos
            }
            lectura.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductosMasVendidos();
        }
        public void ProductosMasVendidos() //funcion me ordena los productos que han sido mas vendidos
        {
            listado = listado.OrderByDescending(p => p.CantidadVentas).ToList(); //Me ordena una lista segun un parametro
            dataGridView1.DataSource = null; //vacio el datagrid para que borre los datos anteriores
            dataGridView1.Refresh();
            dataGridView1.DataSource = listado; // lo lleno con los datos del listado que he reunido en la fucion while
            dataGridView1.Refresh();
            dataGridView1.Columns["Costo"].Visible = false;
            dataGridView1.Columns["Codigo"].Visible = false;
            dataGridView1.Columns["Precio"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; //vacio el datagrid para que borre los datos anteriores
            dataGridView1.Refresh();
            List<producto> temporal = new List<producto>();
            for(int i = 0; i < listado.Count; i++)
            {
                if (listado[i].Cantidad < 4) //Regla de reabastecimiento, si hay 4 productos para abajo hay que reabastecer
                {
                    temporal.Add(listado[i]);
                }
            }
            if(temporal.Count() == 0)
            {
                MessageBox.Show("No hay productos por reabastecer, todos tienen mas de 4 proctos");
            }
            else
            {
                dataGridView1.DataSource = temporal; // lo lleno con los datos del listado que he reunido en la fucion while
                dataGridView1.Refresh();
                dataGridView1.Columns["Costo"].Visible = false;
                dataGridView1.Columns["Codigo"].Visible = false;
                dataGridView1.Columns["Precio"].Visible = false;
                dataGridView1.Columns["CantidadVentas"].Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<VentasPorMes> listaDeVentasPorMes = new List<VentasPorMes>();
            int mes = dateTimePicker1.Value.Month;
            string archivo = "venta.txt";
            FileStream leer = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader lectura = new StreamReader(leer);
            while (lectura.Peek() > -1) //Leo todos las filas del archivo
            {
                Venta temp = new Venta();
                clientes temporal = new clientes();
                temp.Codigo = lectura.ReadLine();
                temporal.Nit = lectura.ReadLine();
                temporal.Nombre = lectura.ReadLine();
                temp.Cliente = temporal;
                temp.Fecha = Convert.ToDateTime(lectura.ReadLine());
                Usuario temp3 = new Usuario();
                temp3.Username = lectura.ReadLine();
                temp.Cajero = temp3;
                temp.Total = float.Parse(lectura.ReadLine());
                temp.Dinero = float.Parse(lectura.ReadLine());
                temp.Vuelto = float.Parse(lectura.ReadLine());
                ListaDeVentas.Add(temp); //agrego a la lista de productos
            }
            lectura.Close();
            for (int i =0; i < ListaDeVentas.Count; i++)
            {
                VentasPorMes temp2 = new VentasPorMes();
                if ( mes == ListaDeVentas[i].Fecha.Month)
                {
                    temp2.Fecha = ListaDeVentas[i].Fecha;
                    temp2.NIT1 = ListaDeVentas[i].Cliente.Nit;
                    temp2.Cliente = ListaDeVentas[i].Cliente.Nombre;
                    temp2.Total = ListaDeVentas[i].Total;
                    listaDeVentasPorMes.Add(temp2);
                }
            }
            if(listaDeVentasPorMes.Count == 0)
            {
                MessageBox.Show("No existen ventas en ese mes");
            }
            else
            {
                dataGridView1.DataSource = null; //vacio el datagrid para que borre los datos anteriores
                dataGridView1.Refresh();
                dataGridView1.DataSource = listaDeVentasPorMes; // lo lleno con los datos del listado que he reunido en la fucion while
                dataGridView1.Refresh();
            }
        }
    }
}
