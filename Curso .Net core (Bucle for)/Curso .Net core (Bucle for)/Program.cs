using System;

namespace Curso_.Net_core__Bucle_for_
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] arreglo = { "0", "1", "2", "3", "4" };
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("arreglo {0} = {1}",i,arreglo[i]);
            }

            //foreach

            foreach (var item in arreglo)
            {
                Console.WriteLine("arreglo {0}", item);
            }

            Console.ReadLine();
        }
    }
}
