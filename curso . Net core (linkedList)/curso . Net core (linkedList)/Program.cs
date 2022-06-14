using System;
using System.Collections.Generic;

namespace curso_._Net_core__linkedList_
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ListaNodo();
            list.listaVacia();
            list.addNodo(1);
            list.addNodo(3);
            list.addNodo(2);
            list.addNodo(4);
            list.listar();
            list.sustituir(3,6);
            Console.WriteLine(list.sizeMetodo());
            list.listar();
        }
    }
}
