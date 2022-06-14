using System;

namespace Curso_.Net_Core__Funciones_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            new Program().metodo(ref numero);
            Console.WriteLine(numero);
            int numero2;
            new Program().metodo2(out numero2);
        }

        public void metodo(ref int numero)
        {
            numero = 3;

        }
        public void metodo2(out int numero2)
        {
            numero2 = 5;

            funcion(numero2);
            void funcion(int numero2)
            {
                Console.WriteLine($"Estoy dentro de la funcion del metodo 2 la variable en el metodo2 es {numero2}");
                Console.ReadLine();
            }

            //funcion statica
            static int funcion2()=>  6;
        }
    }
}
