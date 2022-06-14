using System;

namespace Curso_.net_core__Inmutabilidad_de_los_objetos_String_
{
    class Program
    {
        static void Main(string[] args)
        {
            // inmutabilidad de objetos string
            string name1= "Vanyhony";
            string name2 = "Esneyder";
            name1 += name2;
            Console.WriteLine("nombre: {0}",name1);


            // Formato de cadenas (Interpolacion de cadenas)
            Console.WriteLine(" ");
            Console.WriteLine("Formato de cadenas:");
            Console.WriteLine(" ");

            var nombres = (nombre1: "Vanyhony", nombre2: "Esneyder", age: 20);
            Console.WriteLine($"{nombres.nombre1} tengo {nombres.age} años");

            // Subcadenas de string
            Console.WriteLine(" ");
            Console.WriteLine("Subcadena");
            Console.WriteLine(" ");

            var oracion = "Me duele el corazon";
            var oracion2 = "Esneyder";

            Console.WriteLine("{0}", oracion.Substring(9));

            var sub = oracion.Replace("el corazon", "el alma");
            Console.WriteLine("{0}", sub);

            //Iterando cadena de texto
            Console.WriteLine(" ");
            Console.WriteLine("Iterando Cadena de texto");
            Console.WriteLine(" ");

            var data = oracion.IndexOf('d');
            Console.WriteLine("{0}", data);
            //Para convertir la cadena en array se usa ToCharArray
            var data2 = oracion.ToCharArray();
            Console.WriteLine("{0}", data2[3]);

            // Para convertir toda la cadena en minuscula se usa ToLower
            var data3 = oracion.ToLower();
            Console.WriteLine("{0}", data3);

            // Para convertir toda la cadena en Mayuscula se usa ToLower
            var data4 = oracion.ToUpper();
            Console.WriteLine("{0}", data4);

            // Para comparar dos cadenas
            var data5 = oracion.Equals(oracion2);
            Console.WriteLine("{0}", data5);
            Console.ReadLine();
        }
    }
}
