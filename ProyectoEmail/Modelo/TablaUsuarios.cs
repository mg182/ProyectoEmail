using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoEmail.Modelo
{
    class TablaUsuarios
    {

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public String nombre;
        public String correo;
        public String contraseña;
    }
}
