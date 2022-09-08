using System;

namespace _7_MergeSort
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

            /*
            CListaLigada l = new();

            l.Adicionar(6);
            l.Adicionar(7);
            l.Adicionar(9);
            l.Adicionar(11);

            CListaLigada r = new();
            
            r.Adicionar(8);
            r.Adicionar(10);
            r.Adicionar(12);
            r.Adicionar(13);

            CListaLigada merged = Merge(l, r);
            merged.Transversa();
            */

            CListaLigada ordenada = MergeSort(_miLista);
            ordenada.Transversa();
        }

        public static CListaLigada Merge(CListaLigada listIzq, CListaLigada listDer)
        {
            //Recordar que para que el merge funcione la lista derecha e izquierda ya deben de estar ordenadas

            //Lista donde se unen
            CListaLigada unida = new CListaLigada();

            //Indices en cada lista
            int indiceI = 0;
            int indiceD = 0;

            //Cantidad de elementos en cada lista
            int cantI = listIzq.Cantidad();
            int cantD = listDer.Cantidad();

            //Recorremos mientas las dos listas tengan elementos sin procesar
            while(indiceI < cantI && indiceD < cantD)
            {
                //Si el de la izquerda es menor o igual adicionamos el de la izquerda
                if (listIzq[indiceI] <= listDer[indiceD])
                {
                    unida.Adicionar(listIzq[indiceI]);

                    //Avanzamos el indice izquierdo
                    indiceI++;
                }
                else //Si el de la derecha es menor adicionamos el de la derecha
                {
                    unida.Adicionar(listDer[indiceD]);

                    //Avanzamos el indice derecho
                    indiceD++;
                }
            }

            //Si sobraron elementos en la lista izquerda los ponemos todos
            while(indiceI < cantI)
            {
                unida.Adicionar(listIzq[indiceI]);
                indiceI++;
            }

            //Si sobraron elementos en la lista derecha los ponemos todos
            while(indiceD < cantD)
            {
                unida.Adicionar(listDer[indiceD]);
                indiceD++;
            }

            //Regresamos nuesta lista uida
            return unida;
        }

        public static CListaLigada MergeSort(CListaLigada pLista)
        {
            //Cantidad de elementos en la lista
            int cantidad = pLista.Cantidad();
            int n = 0;

            //Caso base, una lista de un solo elemento ya esta ordenada
            if (cantidad < 2)
                return pLista;

            //Obtenemos el punto medio de la lista
            int mitad = cantidad / 2;

            CListaLigada izquierda = new CListaLigada();
            CListaLigada derecha = new CListaLigada();

            //Adicionamos a la izquerda desd el indice hasta antes de la mitad
            for (n = 0; n < mitad; n++)
                izquierda.Adicionar(pLista[n]);

            //Adicionamos a la derecha desde la mitad hasta el final de la lista
            for (n = mitad; n < cantidad; n++)
                derecha.Adicionar(pLista[n]);

            //Casos inductivos
            //Hacemos el MergeSort de las listas izquerdas y derechas
            CListaLigada tempI = MergeSort(izquierda);
            CListaLigada tempD = MergeSort(derecha);

            //Hacemos el merge de lo que nos regresa el caso inductivo
            CListaLigada ordenada = Merge(tempI, tempD);

            //Regresamos la lista ordenada
            return ordenada;
        }
    }
}
