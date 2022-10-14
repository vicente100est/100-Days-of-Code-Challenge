using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Estructura_de_Datos_II
{
    public class CArbolBB
    {
        private CNodo _raiz;
        private CNodo _trabajo;

        private int _i = 0;

        public CArbolBB()
        {
            _raiz = null;
        }

        internal CNodo Raiz { get => _raiz; set => _raiz = value; }

        //Insertar

        public CNodo Insertar(int pDato, CNodo pNodo)
        {
            CNodo temp = null;

            //Si no hay a quien insertar entonces creamos el nodo
            if (pNodo == null)
            {
                temp = new CNodo();
                temp.Dato = pDato;

                return temp;
            }

            if (pDato < pNodo.Dato)
            {
                pNodo.Izq = Insertar(pDato, pNodo.Izq);
            }
            if (pDato > pNodo.Dato)
            {
                pNodo.Der = Insertar(pDato, pNodo.Der);
            }

            return pNodo;
        }

        // Trasversa
        public void Trasversa(CNodo pNodo)
        {
            if (pNodo == null)
                return;

            //Me proceso primero a i
            for (int n = 0; n < _i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);

            //Si tengo izquierda, proceso a la izquierda
            if (pNodo.Izq != null)
            {
                _i++;
                Console.Write("I ");
                Trasversa(pNodo.Izq);
                _i--;
            }

            //Si tengo derecha, proceso a la derecha
            if (pNodo.Der != null)
            {
                _i++;
                Console.Write("D ");
                Trasversa(pNodo.Der);
                _i--;
            }
        }

        public int EncuentraMinimo(CNodo pNodo)
        {
            if (pNodo == null)
                return 0;

            _trabajo = pNodo;
            int minimo = _trabajo.Dato;

            while (_trabajo.Izq != null)
            {
                _trabajo = _trabajo.Izq;
                minimo = _trabajo.Dato;
            }

            return minimo;
        }

        public int EncuentraMaximo(CNodo pNodo)
        {
            if (pNodo == null)
                return 0;

            _trabajo = pNodo;
            int maximo = _trabajo.Dato;

            while (_trabajo.Der != null)
            {
                _trabajo = _trabajo.Der;
                maximo = _trabajo.Dato;
            }

            return maximo;
        }

        public void TransversaInOrder(CNodo pNodo)
        {
            if (pNodo == null)
                return;

            //Si tengo izquierda, proceso a la izquierda
            if (pNodo.Izq != null)
            {
                _i++;
                TransversaInOrder(pNodo.Izq);
                _i--;
            }

            Console.Write("{0}, ", pNodo.Dato);

            //Si tengo derecha, proceso a la derecha
            if (pNodo.Der != null)
            {
                _i++;
                TransversaInOrder(pNodo.Der);
                _i--;
            }
        }

        public CNodo EncuentraNodoMinimo(CNodo pNodo)
        {
            if (pNodo == null)
                return null;

            _trabajo = pNodo;
            int minimo = _trabajo.Dato;

            while (_trabajo.Izq != null)
            {
                _trabajo = _trabajo.Izq;
                minimo = _trabajo.Dato;
            }

            return _trabajo;
        }

        public CNodo BuscarPadre(int pDato, CNodo pNodo)
        {
            CNodo temp = null;

            if (pNodo == null)
                return null;

            //Verifico si soy el padre
            if (pNodo.Izq != null)
                if (pNodo.Izq.Dato == pDato)
                    return pNodo;

            if (pNodo.Der != null)
                if (pNodo.Der.Dato == pDato)
                    return pNodo;

            //Si tengo izquierda, proceso a la izquierda
            if (pNodo.Izq != null && pDato < pNodo.Dato)
            {
                temp = BuscarPadre(pDato, pNodo.Izq);
            }

            //Si tengo derecha, proceso a la derecha
            if (pNodo.Der != null && pDato > pNodo.Dato)
            {
                temp = BuscarPadre(pDato, pNodo.Der);
            }

            return temp;
        }
    }
}
