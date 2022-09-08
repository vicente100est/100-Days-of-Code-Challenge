using System;

namespace _2_Recursion_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recorrer un array de forma recursiva
            int[] array = {1, 2, 3, 4, 5 };
            ShowArrayRersivp(array, 0);
        }

        public static void ShowArrayRersivp(int[] array, int indice)
        {
/*            if(indice == array.Length - 1)
            {
                Console.WriteLine(array[indice]);
            }
            else
            {
                Console.WriteLine(array[indice]);
                ShowArrayRersivp(array, indice + 1);
            }*/

            if(indice != array.Length)
            {
                Console.WriteLine(array[indice]);
                ShowArrayRersivp(array, indice + 1);
            }
        }
    }
}
