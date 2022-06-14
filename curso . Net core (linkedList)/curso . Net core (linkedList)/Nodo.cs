using System;
using System.Collections.Generic;
using System.Text;

namespace curso_._Net_core__linkedList_
{
    public class Nodo
    {
        public int dato;
        public Nodo siguiente;
        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
    }
}
