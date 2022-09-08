using System;
using System.Diagnostics;

namespace _1_introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 0;
            int cantidad = 1000000;

            //Arreglo aleatorio
            int[] aleatorio = new int[cantidad];

            for (n = 0; n < aleatorio.Length; n++)
            {
                aleatorio[n] = rnd.Next(cantidad);
            }

            Stopwatch sw = new Stopwatch();

            sw.Start();
            Array.Sort(aleatorio);
            sw.Stop();
            Console.WriteLine("Para aleatorio tomo {0:N0}", sw.ElapsedTicks);
            sw.Reset();

            //Arreglo ordenado previamente
            int[] ordenado = new int[cantidad];

            for (n = 0; n < ordenado.Length; n++)
            {
                ordenado[n] = n;
            }

            sw.Start();
            Array.Sort(ordenado);
            sw.Stop();
            Console.WriteLine("Para ordenado tomo {0:N0}", sw.ElapsedTicks);
            sw.Reset();

            //Arreglo ordenado descendente previamente
            int[] descendente = new int[cantidad];
            for (n = 0; n < ordenado.Length; n++)
            {
                ordenado[n] = cantidad - n;
            }

            sw.Start();
            Array.Sort(descendente);
            sw.Stop();
            Console.WriteLine("Para descendente tomo {0:N0}", sw.ElapsedTicks);
            sw.Reset();

            //Arreglos con todos iguales
            int[] iguales = new int[cantidad];

            for (n = 0; n < ordenado.Length; n++)
            {
                ordenado[n] = 100;
            }

            sw.Start();
            Array.Sort(iguales);
            sw.Stop();
            Console.WriteLine("Para iguales tomo {0:N0}", sw.ElapsedTicks);
            sw.Reset();
        }
    }
}
