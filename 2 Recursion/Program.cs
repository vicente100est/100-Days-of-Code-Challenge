using System;

namespace _2_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 0;

            f = Factorial(4);

            Console.WriteLine(f);
        }

        public static int Factorial(int n)
        {
            int r = 0;

            if(n > 1)
                r = n * Factorial(n - 1);

            if (n == 1)
                r = 1;

            return r;
        }
    }
}
