using System;

namespace _8_QuickSort
{
    public class Program
    {
        private static CListaLigada _miLista = new CListaLigada();
        static void Main(string[] args)
        {
            _miLista.Adicionar(3);
            _miLista.Adicionar(15);
            _miLista.Adicionar(7);
            _miLista.Adicionar(19);
            _miLista.Adicionar(11);
            _miLista.Adicionar(1);

            _miLista.Transversa();

            QuickSort(0, _miLista.Cantidad() - 1);

            _miLista.Transversa();
        }

        private static void Swap(int i1, int i2)
        {
            int temp = _miLista[i1];
            _miLista[i1] = _miLista[i2];
            _miLista[i2] = temp;
        }

        public static int Particion(int pInicio, int pFin)
        {
            int pivote = 0;
            int iPivote = 0;
            int n = 0;

            //Seleccionamos el ultimo como pivote
            pivote = _miLista[pFin];

            //Recorremos la lista del pivote con el indice del inicio
            iPivote = pInicio;

            //Recorremos la lista en el fragmento indicado
            for (n = pInicio; n < pFin; n++)
            {
                //Si el elemento en el indice n es menor o igual al pivote
                if (_miLista[n] <= pivote)
                {
                    //Intercambiamos el elemento en n con el que se encuentre en el inicio de pivote
                    Swap(n, iPivote);

                    //Incrementamos el indice del pivote
                    iPivote++;
                }
            }

            //Hacemos el swap final para colocar el pivote donde corresponde
            Swap(iPivote, pFin);

            return iPivote;
        }

        public static void QuickSort(int pInicio, int pFin)
        {
            int iPivote = 0;

            //Caso base, un elemento o fragmento invalido
            if (pInicio >= pFin)
                return;

            //Obtener el indice del pivote para el fragmenyo con el que trabajamos
            iPivote = Particion(pInicio, pFin);

            //Casos inductivos
            QuickSort(pInicio, iPivote - 1); //Fragmento a la izquerda del pivote
            QuickSort(iPivote + 1, pFin); //Fragmento a la derecha del pivote
        }
    }
}
