using System;

namespace _20_Grafo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nodo = 0;

            var miGrafo = new CGrafo(7);

            miGrafo.AdicionaArista(0, 1);
            miGrafo.AdicionaArista(0, 2);
            miGrafo.AdicionaArista(0, 3);
            miGrafo.AdicionaArista(1, 3);
            miGrafo.AdicionaArista(1, 4);
            miGrafo.AdicionaArista(2, 5);
            miGrafo.AdicionaArista(3, 2);
            miGrafo.AdicionaArista(3, 5);
            miGrafo.AdicionaArista(3, 6);
            miGrafo.AdicionaArista(4, 3);
            miGrafo.AdicionaArista(4, 6);
            miGrafo.AdicionaArista(6, 5);

            miGrafo.MuestraAdyacencia();

            miGrafo.CalcularIndegree();
            miGrafo.MostrarIndigree();


            Console.ForegroundColor = ConsoleColor.Cyan;
            do
            {
                //Encontramos el nodo con el indegree 0
                nodo = miGrafo.EncuentraIndegree0();

                if (nodo != -1)
                {
                    //imprimimos el nodo
                    Console.Write("{0}-> ", nodo);

                    //Decrementamos los siguientes
                    miGrafo.DecrementaIndegree(nodo);
                }

            } while (nodo != -1);

            Console.WriteLine();
        }
    }
}
