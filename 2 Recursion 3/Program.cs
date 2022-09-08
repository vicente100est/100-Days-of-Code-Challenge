using System;

namespace _2_Recursion_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1 Suma del 1 a n de forma recursiva
             */
            Console.WriteLine(Suma(5));
            Console.ReadLine();
        }

        public static int Suma(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + Suma(n - 1);
            }
        }
    }
}
