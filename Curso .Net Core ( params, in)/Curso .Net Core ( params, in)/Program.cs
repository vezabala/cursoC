using System;

namespace Curso_.Net_Core___params__in_
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] parametros = { "Esneyder", 20, true };
            new Program().metodo("Esneyder", 20, true);
            int numero = 2;
            new Program().metodo2(numero);
        }
        public void metodo(params Object[] parametros)
        {
            String nombre = (String)parametros[0];
            int age = (int)parametros[1];
            bool sentencia = (bool)parametros[2];
        }

        public void metodo2(in int numero)
        {
            numero = 3;
            Console.WriteLine(numero);
        }
    }
}
