using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoEmail.Modelo
{
    class Coordinador
    {

        public String nombrec { get; set; }  
        public String carrera { get; set; }
        public String email { get; set; }

        public String cyc
        {
            get
            {
                return carrera + " " + email;
            }
        }


    }
}
