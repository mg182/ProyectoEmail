using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoEmail.Modelo
{
    class TablaFavoritos
    {
        [PrimaryKey , AutoIncrement]
        public int id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String facultad { get; set; }
        public String puesto { get; set; }
        public String email { get; set; }

    }
}
