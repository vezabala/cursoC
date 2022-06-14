using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_.net_core__propiedades_
{
    class Estudiante
    {
        public String nombre { get; set; } = "Esneyder";
        private String nombrepriv;
        public String nombre2
        {
            get=>  nombre2;
            
            set=> nombrepriv = value;
        }
    }
}
