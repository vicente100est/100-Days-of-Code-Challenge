using System;

namespace _9_Stack__Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CStack pila = new CStack();

            pila.Push(5);
            pila.Push(3);
            pila.Push(666);

            pila.Transversa();

            Console.WriteLine(pila.Pop());

            pila.Transversa();

            Console.WriteLine(pila.Peek());
            Console.WriteLine(pila.Peek());

            pila.Transversa();
        }
    }
}
