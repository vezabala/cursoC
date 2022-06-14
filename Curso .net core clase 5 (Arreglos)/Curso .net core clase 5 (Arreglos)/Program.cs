using System;

namespace Curso_.net_core_clase_5__Arreglos_
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] cadena = new String[5];
            cadena[0] = "posicion0";
            cadena[1] = "posicion1";
            cadena[2] = "posicion2";
            cadena[3] = "posicion3";
            cadena[4] = "posicion4";
            Console.WriteLine("Esta es la cadena {0}", cadena.Length);
        }
    }
}
