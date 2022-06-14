using System;

namespace Curso_.net_core_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = 5;
            switch (data)
            {
                case 5:
                    Console.WriteLine ("caso {0}", data);
                    break;
                default:
                    Console.WriteLine("No encontrado");
                    break;
            }

            // expresion 1
            Console.WriteLine(" ");

            var data2 = 2;
            var resultado = data2 switch
            {
                1 => "Vanyhony",
                2 => "Esneyder",
                3 => "Otro",
            };
            Console.WriteLine(resultado);

            //expresion 2
            Console.WriteLine(" ");

            var (a,b,opcion) =(2,6, "+");
            var resultado1 = opcion switch
            {
                "+" => a+b,
                "-"=> a-b,
                "*"=> a*b
            };
            Console.WriteLine(resultado1);


            Console.ReadLine();
        }
    }
}
