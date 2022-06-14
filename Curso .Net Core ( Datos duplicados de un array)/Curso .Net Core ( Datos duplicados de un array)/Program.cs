using System;

namespace Curso_.Net_Core___Datos_duplicados_de_un_array_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 3, 4, 5, 5, 6, 7, 5, 7, 8, 7 };
            int[] list = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        if (numero(array[i]))
                        {
                            list[i] = array[i];
                        }
                    }
                }
                if (list[i]!= 0)
                {
                    Console.WriteLine(list[i] + " se repite " + count);
                }
            }
            bool numero(int num)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i]== num)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
