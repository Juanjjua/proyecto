﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class Login : Form
    {
        Usuario usuarioLogin = new Usuario();
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void loginAdmin(string usuario, string pass)
        {
            Boolean ok = false; //Sirve para saber si coincide es usuario y contraseña guardados en el archivo
            string archivoUsuario = "usuarios.txt";
            FileStream leer = new FileStream(archivoUsuario, FileMode.Open, FileAccess.Read);
            StreamReader lectura = new StreamReader(leer);
            while(lectura.Peek() > -1)
            {
                Usuario nuevo = new Usuario(); //Creamos un objeto de tipo Usuario
                nuevo.Username = lectura.ReadLine();
                nuevo.Pasword = lectura.ReadLine();
                nuevo.Type = Convert.ToInt32( lectura.ReadLine());
                if ((nuevo.Username == usuario) && (nuevo.Pasword == pass))
                {
                    ok = true;
                    usuarioLogin = nuevo;
                }
            }
            lectura.Close();
            if(ok == true) //valido que hallan coincidido el usuario y contraseña almenos una vez
            {
                this.Hide();
                new Home(usuarioLogin.Type, usuarioLogin).ShowDialog();
                this.Close();

            }
            else
            {
                label3.Text = "No se ha podido iniciar sesion";
            }
            
        }
        public void loginVendedor(string usuario, string pass)
        {
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            try //Excepcion por si existe error
            {
                string usuario = txtUsuario.Text.Trim();
                string password2 = txtPassword.Text;
                loginAdmin(usuario, password2);
            }
            catch
            {

            }
        }
    }
}
