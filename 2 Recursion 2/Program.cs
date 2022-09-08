using System;

namespace _2_Recursion_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            f = Fib(42);
            Console.WriteLine(f);
        }

        public static int Fib(int n)
        {
            int r = 0;

            if(n > 1)
                r = Fib(n - 1) + Fib(n - 2);

            if (r <= 0)
                r = 1;

            return r;
        }
    }
}
