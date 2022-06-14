using System;
using System.Text;

namespace Curso_.net_core__StringBuilder_
{
    class Program
    {
        static void Main(string[] args)
        {
            var nombres= new StringBuilder("Esneyder Zabala");
            nombres[3] = 'y';
            Console.WriteLine(nombres.ToString());
            Console.ReadLine();
        }
    }
}
