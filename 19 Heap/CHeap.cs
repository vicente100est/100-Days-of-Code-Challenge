using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Heap
{
    public class CHeap
    {
        private int _capacidad;
        private int _tamano;
        private int[] _elementos;

        public CHeap(int pCapacidad)
        {
            _capacidad = pCapacidad;
            _elementos = new int[_capacidad + 1];
        }

        public void Transversa()
        {
            int n = 0;
            for (n = 0; n <= _tamano; n++)
                Console.WriteLine("{0}, ", _elementos[n]);

            Console.WriteLine();
        }

        public bool EstaLleno()
        {
            if (_tamano >= _capacidad)
                return true;
            else
                return false;
        }

        public void Insertar(int valor)
        {
            int n = 0;

            if (EstaLleno())
            {
                return;
            }
            else
            {
                for (n = _tamano + 1; _elementos[n / 2] > valor; n /= 2)
                {
                    _elementos[n] = _elementos[n / 2];
                }
                _elementos[n] = valor;
                _tamano++;
            }

        }

        public int BorrarMin()
        {
            int n = 0;
            int hijo = 0;
            int elementoMenor = 0;
            int ultimoElemento = 0;

            if (_tamano <= 0)
                return 0;

            elementoMenor = _elementos[1];
            ultimoElemento = _elementos[_tamano--];


            for (n = 1; n * 2 <= _tamano; n = hijo)
            {

                //Encontramos al menos
                hijo = n * 2;
                if (hijo != _tamano && _elementos[hijo + 1] < _elementos[hijo])
                    hijo++;

                //Percolamos
                if (ultimoElemento > _elementos[hijo])
                    _elementos[n] = _elementos[hijo];
                else
                    break;
            }

            //Actualizamos
            _elementos[n] = ultimoElemento;

            //Regresamos el menor
            return elementoMenor;
        }
    }
}
