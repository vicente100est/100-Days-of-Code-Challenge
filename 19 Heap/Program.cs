using System;

namespace _19_Heap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CHeap miHeam = new CHeap(12);

            miHeam.Insertar(1);
            miHeam.Insertar(2);
            miHeam.Insertar(13);
            miHeam.Insertar(4);
            miHeam.Insertar(5);
            miHeam.Insertar(6);
            miHeam.Insertar(7);

            miHeam.Transversa();

            Console.WriteLine("Mi minimo {0}", miHeam.BorrarMin());
            miHeam.Transversa();

            Console.WriteLine("Mi minimo {0}", miHeam.BorrarMin());
            miHeam.Transversa();
            Console.WriteLine("Mi minimo {0}", miHeam.BorrarMin());
            miHeam.Transversa();
            Console.WriteLine("Mi minimo {0}", miHeam.BorrarMin());
            miHeam.Transversa();
            Console.WriteLine("Mi minimo {0}", miHeam.BorrarMin());
            miHeam.Transversa();
            Console.WriteLine("Mi minimo {0}", miHeam.BorrarMin());
            miHeam.Transversa();
        }
    }
}
