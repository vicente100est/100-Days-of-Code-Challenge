using System;

namespace _2_Recursion_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sumatoria de los elementos de un arreglo
            int[] intArray = new int[] { 1, 1, 1, 1, 1, 1, 1 };
            Console.WriteLine(Sum(intArray));
        }

        public static int Sum(int[] array, int position = 0)
        {
            if(position == array.Length)
            {
                return 0;
            }
            else
            {
                return array[position] + Sum(array, position + 1);
            }
        }
    }
}
