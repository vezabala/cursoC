using System;

namespace curso_.Net_Core_ejercicio_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Estudiante()
            {
                nombre = "Esneyder",
                edad = 20,
                calificacion = 10
            };
            var s2 = new Estudiante()
            {
                nombre = "otro",
                edad = 19,
                calificacion = 3
            };
            var s3 = new Estudiante()
            {
                nombre = "jeison",
                edad = 90,
                calificacion = 7
            };
            var school = new School();
            school.addEstudiante(s1);
            school.addEstudiante(s2);
            school.addEstudiante(s3);

            bool valor = false;

            do
            {
                Console.WriteLine("Ingrese nombre");
                String name = Console.ReadLine();
                valor = school.buscarEstudiantePorNombre(name);
            } while (valor);

        }
    }
}
