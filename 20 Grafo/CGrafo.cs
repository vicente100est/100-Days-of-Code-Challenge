﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Grafo
{
    public class CGrafo
    {
        int[,] mAdyacencia;
        int[] indegree;
        int nodos;

        public CGrafo(int pNodos)
        {
            nodos = pNodos;

            //Instanciamos matriz de adyacencia
            mAdyacencia = new int[nodos, nodos];

            //Instanciamos arreglo de indegree
            indegree = new int[nodos];
        }

        public void AdicionaArista(int pNodoInicio, int pNodoFinal)
        {
            mAdyacencia[pNodoInicio, pNodoFinal] = 1;
        }

        public void MuestraAdyacencia()
        {
            int n = 0;
            int m = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (n = 0; n < nodos; n++)
                Console.WriteLine("\t{0}", n);
            
            Console.WriteLine();

            for (n = 0; n < nodos; n++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(n);

                for (m = 0; m < nodos; m++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write("\t{0}", mAdyacencia[n, m]);
                }
                Console.WriteLine();
            }
        }

        public void CalcularIndegree()
        {
            int n = 0;
            int m = 0;

            for (n = 0; n < nodos; n++)
            {
                for (m = 0; m < nodos; m++)
                {
                    if (mAdyacencia[m, n] == 1)
                        indegree[n]++;
                }
            }
        }

        public void MostrarIndigree()
        {
            int n = 0;
            Console.ForegroundColor = ConsoleColor.White;
            for (n = 0; n < nodos; n++)
                Console.WriteLine("Nodo: {0}, {1}", n, indegree[n]);
        }

        public int EncuentraIndegree0()
        {
            bool encontrado = false;
            int n = 0;

            for (n = 0; n < nodos; n++)
            {
                if (indegree[n] == 0)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
                return n;
            else
                return -1; //Codigo que indica que no se ha encontrado
        }

        public void DecrementaIndegree(int pNodo)
        {
            indegree[pNodo] = -1;

            int n = 0;

            for (n = 0; n < nodos; n++)
            {
                if (mAdyacencia[pNodo, n] == 1)
                    indegree[n]--;
            }
        }
    }
}
