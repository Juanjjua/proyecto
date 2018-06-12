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
        Venta ventaRealizada = new Venta();
        List<DetalleVenta> listadeventa = new List<DetalleVenta>();
        List<clientes> listadoClientes = new List<clientes>();
        List<producto> listado = new List<producto>(); //creo una variable global tipo producto para guardar todos los productos
        string codigoDeVenta = ""; //Servira para tener un codigo para un detalle y este lo vincule a los datos generales de la venta
        Usuario  vendedorActual;
        float cambio;
        public Ventas()
        {
            InitializeComponent();
        }
        public Ventas(Usuario vendedor)
        {
            vendedorActual = vendedor;
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            actualizar();
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
        public void actualizar() //actualiza los datos que estan en el archivo productos y los agrega a la lista declarada arriba
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
            ActualizarProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            int monto = Convert.ToInt32(tbCantidad.Text);
            if (monto > listado[index].Cantidad) // si la cantidad que solicita no hay suficiente en el inventario, no se prodece a vender
            {
                MessageBox.Show("No se puede realizar operacion, verifique cantidad");
            }
            else
            {
                float total = monto * listado[index].Precio;
                DetalleVenta temp = new DetalleVenta();
                temp.Producto = listado[index].Nombre;
                temp.Precio = listado[index].Precio;
                temp.Cantidad = monto;
                listado[index].Cantidad = listado[index].Cantidad - monto; //Modifico la cantidad de productos que hay, restando el monto que solicitan comprar
                listado[index].CantidadVentas = listado[index].CantidadVentas + monto; //actualizo cuantos productos se van vendiendo.
                temp.Total = total;
                listadeventa.Add(temp);
                ActualizarDetalleVentas();
                ActualizarProductos();
                CalcularSubTotal();
            }
        }

        public void ActualizarProductos ()
        {
            dataGridView1.DataSource = null; //vacio el datagrid para que borre los datos anteriores
            dataGridView1.Refresh();
            dataGridView1.DataSource = listado; // lo lleno con los datos del listado que he reunido en la fucion while
            dataGridView1.Refresh();
            dataGridView1.Columns["Costo"].Visible = false;
            dataGridView1.Columns["CantidadVentas"].Visible = false;
        }

        public void ActualizarDetalleVentas()
        {
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            dataGridView2.DataSource = listadeventa;
            dataGridView2.Refresh();
        }

        public void CalcularSubTotal()
        {
            float subTotal = 0;
            for (int x =0; x < listadeventa.Count; x++)
            {
                subTotal = subTotal + listadeventa[x].Total;
            }
            label7.Text = Convert.ToString(subTotal);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cambio = 0;
            float dinero = float.Parse(textBox4.Text);
            float subTotal = float.Parse(label7.Text);
            if (dinero < subTotal)
            {
                MessageBox.Show("No se puede realizar operacion, verifique cantidad");
            }
            else
            {
                cambio = dinero - subTotal;
                label8.Text = Convert.ToString(cambio);
            }
            
        }

        private void button3_Click(object sender, EventArgs e) //GUARDA TODOS LOS CAMBIOS
        {
            actualizarArchivoProductos();
            registarDetalleVenta();
            registrarVentA();
        }

        public void actualizarArchivoProductos()
        {
            string archivo = "productos.txt";
            FileStream stream = new FileStream(archivo, FileMode.Create, FileAccess.Write); //este tipo porque voy a reescribir el archivo con los nuevos productos
            StreamWriter writer = new StreamWriter(stream);
            for (int i = 0; i < listado.Count; i++) // en listado esta la lista actualizada de todos los productos
            {
                writer.WriteLine(listado[i].Nombre);
                writer.WriteLine(listado[i].Codigo);
                writer.WriteLine(listado[i].Costo);
                writer.WriteLine(listado[i].Precio);
                writer.WriteLine(listado[i].Cantidad);
                writer.WriteLine(listado[i].CantidadVentas);
            }
            writer.Close();
        }

        public void registarDetalleVenta()
        {
            string archivo = "detalleVenta.txt";
            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            //Generare un codigo aleatorio
            Random rnd = new Random();
            codigoDeVenta = Convert.ToString(rnd.Next(999999999)); // me da un numero de 0 a 99999999 para que la probabildad sea poca de que me de un numero igual
            writer.WriteLine(codigoDeVenta);
            // si estos campos estan llenos procedo a guardar los datos
            for ( int y = 0; y< listadeventa.Count; y++)
            {
                writer.WriteLine(listadeventa[y].Producto);
                writer.WriteLine(listadeventa[y].Precio);
                writer.WriteLine(listadeventa[y].Cantidad);
                writer.WriteLine(listadeventa[y].Total);
            }
            writer.WriteLine("-1"); //Me servira para saber cuando termina un detalle de venta
            writer.Close();
        }

        public void registrarVentA()
        {
            //creo un tipo de variable Venta que tiene todos los datos de la venta.
            Venta guardar = new Venta();
            guardar.Codigo = codigoDeVenta;
            clientes registrar = new clientes();
            registrar.Nombre = textBox2.Text;
            registrar.Nit = textBox1.Text;
            guardar.Cliente = registrar;
            guardar.Total = float.Parse(label7.Text);
            guardar.Dinero = float.Parse(textBox4.Text);
            guardar.Fecha = DateTime.Now;
            guardar.Vuelto = cambio;
            guardar.Cajero = vendedorActual;
            string archivo = "venta.txt";
            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(guardar.Codigo);
            writer.WriteLine(guardar.Cliente.Nit);
            writer.WriteLine(guardar.Cliente.Nombre);
            writer.WriteLine(guardar.Fecha);
            writer.WriteLine(guardar.Cajero.Username);
            writer.WriteLine(guardar.Total);
            writer.WriteLine(guardar.Dinero);
            writer.WriteLine(guardar.Vuelto);
            writer.Close();
        }
    }
}