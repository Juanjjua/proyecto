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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void loginAdmin(string usuario, string pass)
        {
        }
        public void loginVendedor(string usuario, string pass)
        {
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text.Trim();
                string password = txtPassword.Text;
                string codigo = usuario.Substring(0, 5);
                if (codigo == "admin")
                {
                    loginAdmin(usuario, password);
                }
                else
                {
                    loginVendedor(usuario, password);
                }
                label3.Text = codigo;

            }
            catch
            {

            }
        }
    }
}
