using System;

namespace Curso_.net_core_clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String numero= "20";
            int entero = Convert.ToInt16(numero);
            double decimale = 3.5;
            decimal deci =7.45M;
            float flotante = 66F;
            bool valor = true;
            char letra = 'E';
            Console.WriteLine("Hello World! yo tengo {0} años y {1} es un numero double, {2} es decimal y {3} es flotante",entero,decimale,deci,flotante);

            Console.ReadLine();
        }
    }
}
