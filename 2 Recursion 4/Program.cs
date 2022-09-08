using System;

namespace _2_Recursion_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 Saca el factorial de n de forma recursiva
            Console.WriteLine(Factorial(5));
        }

        public static int Factorial(int n)
        {
            if (n ==1)
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
