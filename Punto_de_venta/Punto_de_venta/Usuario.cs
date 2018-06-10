﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta
{
    class Usuario
    {
        string username;
        string pasword;
        int type;

        public Usuario(string username, string pasword, int type)
        {
            this.username = username;
            this.pasword = pasword;
            this.type = type;
        }

        public string Username { get => username; set => username = value; }
        public string Pasword { get => pasword; set => pasword = value; }
        public int Type { get => type; set => type = value; }
    }
}
