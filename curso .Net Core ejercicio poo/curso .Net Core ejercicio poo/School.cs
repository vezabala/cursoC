using System;
using System.Collections.Generic;
using System.Text;

namespace curso_.Net_Core_ejercicio_poo
{
    public class School
    {
        private List<Estudiante> estudiantes;

        public School()
        {
            estudiantes = new List<Estudiante>();
        }

        public void addEstudiante(Estudiante nuevoEstudiante)
        {
            estudiantes.Add(nuevoEstudiante);
        }
        public bool buscarEstudiantePorNombre ( String name)
        {
            bool encontrado = false;
            int i = 0;

            while (encontrado== false && i < estudiantes.Count)
            {
                if (estudiantes[i].nombre.Equals(name))
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            if (encontrado)
            {
                Console.WriteLine($"nombre = {estudiantes[i].nombre} \n " +
                    $"edad = {estudiantes[i].edad} \n " +
                    $"calificacion {estudiantes[i].calificacion}");
                return false;
            }
            else
            {
                Console.WriteLine("No existe el nombre intentelo luego");
                return true;
            }
        }
    }
}
