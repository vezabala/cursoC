using System;

namespace Curso_.Net_core__modificador_private_
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Program();
            Console.WriteLine(data.metodoPrivado());
            Console.ReadLine();
            data.metodoPublico();
        }
        private string metodoPrivado()
        {
            string oracion="Estoy en un metodo privado";
            return oracion;
        }
        public void metodoPublico()
        {
            Console.WriteLine("Estoy en un metodo publico");
            Console.ReadLine();
        }
    }
}
