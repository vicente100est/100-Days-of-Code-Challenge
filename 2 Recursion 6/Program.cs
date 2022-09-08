using System;

namespace _2_Recursion_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Buscra un elemento en un array de forma recursiva
            int[] array = { 12, 3, 4, 5 };
            int elementoBuscar = 3;
            int pos = PosicionElementoRecursivo(array, elementoBuscar, 0);
            Console.WriteLine(pos);
        }

        public static int PosicionElementoRecursivo(int[] array, int elementoBuscar, int indice)
        {
            if(indice == array.Length)
            {
                return -1;
            }else if (array[indice] == elementoBuscar)
            {
                return indice;
            }
            else
            {
                return PosicionElementoRecursivo(array, elementoBuscar, indice + 1);
            }
        }
    }
}
