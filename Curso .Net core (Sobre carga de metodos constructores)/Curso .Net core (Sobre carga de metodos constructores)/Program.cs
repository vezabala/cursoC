using System;

namespace Curso_.Net_core__Sobre_carga_de_metodos_constructores_
{
    class Program
    {

        public Program()
        {

        }
        public Program(String nombre)
        {

        }
        static void Main(string[] args)
        {
            var program = new Program("Esneyder");
            Console.WriteLine("Hello World!");
        }
    }
}
