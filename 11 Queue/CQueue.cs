using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Queue
{
    public class CQueue
    {
        //Ancla o encabezado de la cola
        CNodo ancla;

        //Esta variable de referencia nos ayuda trabajar con la cola
        CNodo trabajo;

        public CQueue()
        {
            //Instancia el ancla
            ancla = new CNodo();

            //Como es una cola vacia su siguiente es null
            ancla.Siguiente = null;
        }

        //Recorre todo el queue
        public void Trasversa()
        {
            //Trabajo al inicio
            trabajo = ancla;


            //Se recorre hasta encontrar el final
            while (trabajo.Siguiente != null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.Siguiente;

                //Obtener el dato y lo mostramos
                int d = trabajo.Dato;

                Console.WriteLine("<-{0}", d);
            }

            //Salto de linea
            Console.WriteLine();
        }

        public void EnQueue(int pDato)
        {
            //Trabajo al inicio
            trabajo = ancla;

            //Recorremos hasta encontrar el final
            while (trabajo.Siguiente != null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.Siguiente;
            }

            //Creamos el nuevo nodo
            CNodo temp = new CNodo();

            //Insertamos el dato
            temp.Dato = pDato;

            //Finalizamos correctmanete
            temp.Siguiente = null;

            //;igamos el ultimo nodo encontrado con el recien creado
            trabajo.Siguiente = temp;
        }

        public int DeQueue()
        {
            // Se recomienda aqui poner un codigo de seguridad y asi saber cuando el queue este vacio

            int valor = 0;

            //Llevamos a cabo el trabajo solo si hay elementos en el queue
            if (ancla.Siguiente != null)
            {
                //Obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                //Lo sacamos del queue
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }

            return valor;
        }

        public int Peek()
        {
            //Se recomienda qui poner un codigo de seguridad y asi saber cuando el queue esta vacio

            int valor = 0;

            //Llevamos a cabo el trabajo solo si hay elementos en el queue
            if (ancla.Siguiente != null)
            {
                //Obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
            }

            return valor;
        }
    }
}
