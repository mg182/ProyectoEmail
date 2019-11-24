using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoEmail.Modelo
{
    public class TablaUsuarios
    {

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public String nombre { get; set; }
        public String correo { get; set; }
        public String contraseña { get; set; }

        public String cyc
        {
            get
            {
                return correo + " " + contraseña; }
        }

        public String cyu
        {
            get
            {
                return nombre + " " + correo;
            }
        }
    }
}
