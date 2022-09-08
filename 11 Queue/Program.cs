using System;

namespace _11_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CQueue fila = new CQueue();

            fila.EnQueue(5);
            fila.EnQueue(3);
            fila.EnQueue(7);
            fila.EnQueue(1);

            fila.Trasversa();

            int valor = fila.DeQueue();
            Console.WriteLine("El valor adquirido {0}", valor);
            fila.Trasversa();

            fila.EnQueue(8);
            fila.Trasversa();

            Console.WriteLine("El valor observado es {0}", fila.Peek());
            fila.Trasversa();
        }
    }
}
