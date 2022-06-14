using System;

namespace Curso_.Net_core_ejercicio_triangulo_de_pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;
            int[] arreglo = new int[1];
            Console.WriteLine("Ingrese la cantidad de pisos");
            pisos = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= pisos; i++)
            {
                int[] pascal = new int[i];
                //Ciclo for que decrementa para formar el triangulo
                for (int j = pisos; j < i; j--)
                {
                    Console.Write(" ");
                }
                //Ciclo for que genera la suma de las cifras
                for (int k = 0; k < i; k++)
                {
                    // Condicion que evalua la variable del ciclo for
                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        //Suma de los numeros que estan en cada posicion
                        //del arreglo para formar el triangulo
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    Console.Write("["+ pascal[k]+"]");
                }
                arreglo = pascal;
                Console.WriteLine(" ");
            }
        }
    }
}
