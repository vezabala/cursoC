using System;

namespace Curso_.net_core__estructura_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            var valor = true;
            var count = 1;
            //while
            while (valor)
            {
                if (count == 6)
                {
                    valor = false;
                }
                count++;
                Console.WriteLine("{0}",count);
            }
            //do while
            Console.WriteLine("Do while");
            valor = true;
            count = 1;
            do
            {
                if (count == 6)
                {
                    break;
                }
                count++;
                Console.WriteLine("{0}", count);

            } while (valor);
            Console.ReadLine();
        }
    }
}
