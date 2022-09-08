using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Lista_Ligada_1
{
    public class CListaLigada
    {
        //Es el ancla o encabezado de la lista
        private CNodo _ancla;

        //Esta variable de referencia nos ayuda a trabajar con la lista
        private CNodo _trabajo;

        //Esta variable de referencia apoya en ciertas operaciones de la lista
        private CNodo trabajo2;

        public CListaLigada()
        {
            // Instanciamos el ancla
            _ancla = new CNodo();

            // Como es una lista vacia su siguiente es null
            _ancla.Siguiente = null;
        }

        public void Transversa()
        {
            //Trabajo al inicio
            _trabajo = _ancla;

            //Recorremos hasta encontrar el final
            while(_trabajo.Siguiente != null)
            {
                //Avanzamos trabajo
                _trabajo = _trabajo.Siguiente;

                //Obtenemos el dato y lo mostramos
                int d = _trabajo.Dato;

                Console.WriteLine("{0}, ", d);
            }

            //Bajamos la linea
            Console.WriteLine();
        }

        public void Adicionar(int pDato)
        {
            //Trabajo al inicio
            _trabajo = _ancla;

            //Recorremos hasta encontrar el final
            while (_trabajo.Siguiente != null)
            {
                //Avanzamos trabajo
                _trabajo = _trabajo.Siguiente;
            }

            //Creamos el nuevo nodo
            CNodo temp = new CNodo();

            //Insertamos el dato
            temp.Dato = pDato;

            //Finalizamos correctamente
            temp.Siguiente = null;

            //Ligamos el ultimo nodo encontrado con el recien creado
            _trabajo.Siguiente = temp;
        }

        public void Vaciar()
        {
            _ancla.Siguiente = null;

            //En lenguajes no administrados hay que liberar la memoria adecuadamente
            //Aqui aprovechamos el recolector de basura
        }

        public bool EstaVacio()
        {
            if (_ancla.Siguiente == null)
                return true;
            else
                return false;
        }

        public CNodo Buscar(int pDato)
        {
            if (EstaVacio() == true)
                return null;

            trabajo2 = _ancla;

            while(trabajo2.Siguiente != null)
            {
                trabajo2 = trabajo2.Siguiente;

                if (trabajo2.Dato == pDato)
                    return trabajo2;
            }

            // No se encontro, regresamos un null

            return null;
        }

        //Busca el indice donde se encuentra la primera ocurrencia del dato
        public int BuscarIndice(int pDato)
        {
            int n = -1;

            _trabajo = _ancla;

            while (_trabajo.Siguiente != null)
            {
                _trabajo = _trabajo.Siguiente;
                n++;

                if (_trabajo.Dato == pDato)
                    return n;
            }

            return -1;
        }

        //Encuentra al nodo anterior
        //Si esta en el primer nodo se regresa el ancla
        //Si el dato no existe se regresa al ultimo
        public CNodo BuscarAnterior(int pDato)
        {
            trabajo2 = _ancla;

            while (trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != pDato)
                trabajo2 = trabajo2.Siguiente;

            return trabajo2;
        }

        //Borrar la primera ocurrencia del dato
        public void Borrar(int pDato)
        {
            if (EstaVacio() == true)
                return;

            CNodo anterior = BuscarAnterior(pDato);

            CNodo encotnrado = Buscar(pDato);

            if (encotnrado == null)
                return;

            anterior.Siguiente = encotnrado.Siguiente;

            encotnrado.Siguiente = null;
        }

        //Inserta el dato pValor despues la primera ocurrencia del dato pasado a pDonde
        public void Insertar(int pDonde, int pValor)
        {
            _trabajo = Buscar(pDonde);

            if (_trabajo == null)
                return;

            CNodo temp = new CNodo();
            temp.Dato = pValor;

            temp.Siguiente = _trabajo.Siguiente;

            _trabajo.Siguiente = temp;
        }

        //Insertar al inicio
        public void InsertarInicio(int pDato)
        {
            CNodo temp = new CNodo();
            temp.Dato = pDato;

            temp.Siguiente = _ancla.Siguiente;

            _ancla.Siguiente = temp;
        }

        //Obtener por indice
        public CNodo ObtenerPorIndice(int pIndice)
        {
            CNodo trabajo2 = null;
            int indice = -1;

            _trabajo = _ancla;

            while(_trabajo.Siguiente != null)
            {
                _trabajo = _trabajo.Siguiente;
                indice++;

                if (indice == pIndice)
                    trabajo2 = _trabajo;
            }

            return trabajo2;
        }

        //Indexer
        public int this[int pIndice]
        {
            get
            {
                //Esto puede crear una excepcion si trabajo es igual a null
                //Colocar codigo de seguridad o usar int?
                _trabajo = ObtenerPorIndice(pIndice);

                return _trabajo.Dato;
            }

            set
            {
                _trabajo = ObtenerPorIndice(pIndice);
                if(_trabajo != null)
                {
                    _trabajo.Dato = value;
                }
            }
        }
    }
}
