using System;

namespace Curso_.Net_Core__variables_staticas_
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Conversor();
            Conversor.velocidad = 3.5;
            var data1 = new Conversor();
            Conversor.conversor1();
            Conversor.conversor2();
        }
        class Conversor
        {
            public static double velocidad;

            public static void conversor1()
            {
                velocidad += 20;
            }
            public static void conversor2()
            {
                velocidad += 78;
            }
        }
    }
}
