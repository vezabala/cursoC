using System;

namespace curso_.net_core_clase_4__condicionales_
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 2;
            int valor2 = 3;
            var data = valor1 != valor2;
            String name;
            if(valor1 < valor2 && valor1 == valor2)
            {
                Console.WriteLine("Hello World!");
            }else
            {
                Console.WriteLine("pelle");
            }

            name = data ? "verdad" : "falso";
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
