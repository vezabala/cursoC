using System;

namespace curso_.net_core_clase_2_operadores_
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 2;
            int valor2 = 3;

            //suma
            var suma = valor1 + valor2;
            Console.WriteLine("la suma de {0} + {1} da {2}",valor1,valor2,suma);

            //resta
            var resta = valor1 - valor2;
            Console.WriteLine("la resta de {0} - {1} da {2}", valor1, valor2, resta);

            //multiplicar
            var multiplicar = valor1 * valor2;
            Console.WriteLine("la multiplicacion de {0} * {1} da {2}", valor1, valor2, multiplicar);

            //dividir
            var dividir = valor1 / valor2;
            Console.WriteLine("la division de {0} / {1} da {2}", valor1, valor2, dividir);

            //residuo
            valor2 %= valor1;
            Console.WriteLine("residuo entre valor1 y el valor2 es {0}",valor2);

            Console.ReadLine();
        }
    }
}

