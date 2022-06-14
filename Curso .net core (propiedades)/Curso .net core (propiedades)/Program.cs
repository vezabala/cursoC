using System;

namespace Curso_.net_core__propiedades_
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Estudiante();
            var nombre = data.nombre;
            //var nombre2 = data.nombre2;
            data.nombre2 = "Vanyhony";
            Console.WriteLine(data.nombre2);
        }
    }
}
