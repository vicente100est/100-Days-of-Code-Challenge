using System;

namespace _5_InsertSort
{
    internal class Program
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

            int cantidad = miLista.Cantidad();
            int i = 0;
            int posAgujero = 0;
            int dato = 0;

            //Recorrer elementos
            for(i = 1; i< cantidad; i++)
            {
                //Obtenemos el dato
                dato = miLista[i];

                //Indicamos la posicion del agujero
                posAgujero = i;

                //Recorremos los elementos hacia el agujero
                while (posAgujero > 0 && miLista[posAgujero - 1] > dato)
                {
                    miLista[posAgujero] = miLista[posAgujero - 1];
                    posAgujero = posAgujero - 1;
                }

                //Le colocamos al agujero el dato correspondiente
                miLista[posAgujero] = dato;
            }

            miLista.Transversa();
        }
    }
}
