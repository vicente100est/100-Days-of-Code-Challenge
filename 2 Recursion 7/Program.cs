using System;

namespace _2_Recursion_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recorrer un arreglo

            int[] intArray = new int[] { 1, 2, 3, 4, 5, 666, 10, 56 };

            Recorrer(intArray);
        }

        public static void Recorrer(int[] array, int position = 0)
        {
            if (position == array.Length)
                return;

            Console.WriteLine(array[position]);
            Recorrer(array, position+1);
        }
    }
}
