using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InfixAPostfix
{
    public class CStack
    {
        //Es el ancla o encabezado del stack
        private CNodo _ancla;

        //Esta variable de referencia nos ayuda trabajar con el stack
        private CNodo _trabajo;

        public CStack()
        {
            //Inicia el ancla
            _ancla = new CNodo();

            //Como es un stack vacio su siguente es null
            _ancla.Siguiente = null;
        }

        //Push
        public void Push(char pDato)
        {
            //Creamos el nodo temporal
            CNodo temp = new CNodo();
            temp.Dato = pDato;

            //Conectamos el temporal a la lista
            temp.Siguiente = _ancla.Siguiente;

            //Conectamos el ancla al temporal
            _ancla.Siguiente = temp;
        }

        //Pop
        public char Pop()
        {
            char valor = ' ';

            //Llevamos a cabo el trabajo si hay elementos en el stack
            if (_ancla.Siguiente != null)
            {
                //Obtenemos el dato correspondiente
                _trabajo = _ancla.Siguiente;
                valor = _trabajo.Dato;

                //Lo sacamos del stack
                _ancla.Siguiente = _trabajo.Siguiente;
                _trabajo.Siguiente = null;
            }

            return valor;
        }

        //Peek
        public char Peek()
        {
            char valor = ' ';

            //Llevamos a cabo el trabajo solo si hay elementos en el stack
            if (_ancla.Siguiente != null)
            {
                //Obtenemos el dato correspondiente
                _trabajo = _ancla.Siguiente;
                valor = _trabajo.Dato;
            }

            return valor;
        }

        //Trasversa
        public void Transversa()
        {
            //Trabajo al inicio
            _trabajo = _ancla;

            //Recorremos hasta encontrar el final

            while (_trabajo.Siguiente != null)
            {
                //Avanzamos trabajo
                _trabajo = _trabajo.Siguiente;

                //Obtenemos el dato y lo mostramos
                int d = _trabajo.Dato;

                Console.WriteLine("[{0}]", d);
            }
        }

        public bool EstaVacio()
        {
            if (_ancla.Siguiente == null)
                return true;
            else
                return false;
        }
    }
}
