using System;

namespace Curso_.Net_Core__pasar_arreglo_como_parametro_
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] parametros = { "Esneyder", 20 , true};
            new Program().metodo(parametros);
            Console.WriteLine("Hello World!");
        }
        public void metodo(Object[] parametros)
        {
            String nombre = (String)parametros[0];
            int age = (int)parametros[1];
            bool sentencia = (bool)parametros[2];
        }
    }
}
