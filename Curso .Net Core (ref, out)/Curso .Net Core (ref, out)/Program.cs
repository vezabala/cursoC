using System;

namespace Curso_.Net_Core__ref__out_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            new Program().metodo(ref numero);
            int numero2;
            new Program().metodo2(out numero2);
            Console.WriteLine(numero);
        }

        public void metodo(ref int numero)
        {
            numero = 3;
         
        }
        public void metodo2(out int numero2)
        {
            numero2 = 5;

        }
    }
}
