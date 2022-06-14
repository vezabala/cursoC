using System;

namespace Curso_.Net_Core__metodo_constructor
{
    class Program
    {
        private String oracion;
        private int numeroCadena;
        private String []letMayus;
        private String[] letMayusTemp;
        private String []letMinus;
        private String[] letMinusTemp;
        private String verMayus = "";
        private String verMinus = "";

        public Program(String oracion)
        {
            this.oracion = oracion;
            numeroCadena = oracion.Length;
            letMayus = new String[numeroCadena];
            letMayusTemp = new String[numeroCadena];
            letMinus = new String[numeroCadena];
            letMinusTemp = new String[numeroCadena];
        }

        private String letrasMayusculas()
        {
            for (int i = 0; i < numeroCadena; i++)
            {
                if (char.IsUpper(oracion[i]))
                {
                    letMayusTemp[i] = Convert.ToString(oracion[i]);
                }
            }
            for (int i = 0; i < letMayusTemp.Length; i++)
            {
                if (letMayusTemp[i] != null)
                {
                    letMayus[i] = letMayusTemp[i];
                    verMayus = $"{verMayus},{letMayus[i]}";
                }
            }
            return verMayus;
        }

        private String letrasMinusculas()
        {
            for (int i = 0; i < numeroCadena; i++)
            {
                if (char.IsLower(oracion[i]))
                {
                    letMinusTemp[i] = Convert.ToString(oracion[i]);
                }
            }
            for (int i = 0; i < letMinusTemp.Length; i++)
            {
                if (letMinusTemp[i] != null)
                {
                    letMinus [i] = letMinusTemp[i];
                    verMinus = $"{verMinus},{letMinus[i]}";
                }
            }
            return verMinus;
        }


        static void Main(string[] args)
        {
            Program data = new Program(Console.ReadLine());
            Console.WriteLine($"Las letras mayusculas son {data.letrasMayusculas()} \n\n " +
                $"Las letras minusculas son {data.letrasMinusculas()}");
        }
    }
}
