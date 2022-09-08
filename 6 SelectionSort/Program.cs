using System;

namespace _6_SelectionSort
{
    public class Program
    {
        private static CListaLigada miLista = new();
        static void Main(string[] args)
        {
            miLista.Adicionar(3);
            miLista.Adicionar(15);
            miLista.Adicionar(7);
            miLista.Adicionar(19);
            miLista.Adicionar(11);
            miLista.Adicionar(1);

            miLista.Transversa();

            int i = 0;
            int j = 0;
            int iMin = 0;
            int n = miLista.Cantidad();

            //Recorremos el arreglo
            for (i = 0; i < n - 1; i++)
            {
                //El idice menos es la posicion actual desde donde comenzamos
                iMin = i;

                //Encontramos el nuevo indice del menos
                for( j = i + 1; j < n; j++)
                {
                    if (miLista[j] < miLista[iMin])
                        iMin = j;
                }

                //Omtercambiamos la posicion actual con el menos
                Swap(i, iMin);
            }

            miLista.Transversa();
        }

        public static void Swap(int i1, int i2)
        {
            int temp = miLista[i1];
            miLista[i1] = miLista[i2];
            miLista[i2] = temp;
        }
    }
}
