using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _12_Arbol_Generico
{
    public class CArbol
    {
        private CNodo _raiz;
        private CNodo _trabajo;
        private int _i = 0;

        public CArbol()
        {
            _raiz = new CNodo();
        }

        public CNodo Insertar(string pDato, CNodo pNodo)
        {
            //Si no hay nodo donde insertar, tomamos como si fuera en la raiz
            if(pNodo == null)
            {
                _raiz = new CNodo();
                _raiz.Dato = pDato;

                //No hay hijo
                _raiz.Hijo = null;

                //No hay hermanos
                _raiz.Hermano = null;

                return _raiz;
            }

            //Verificamos si no tiene Hijos
            //Insertamos el dato como hijo
            if(pNodo.Hijo == null)
            {
                CNodo temp = new CNodo();

                temp.Dato = pDato;

                //Conectamos el nuevo nodo como hijo
                pNodo.Hijo = temp;

                return temp;
            }
            else //Ya tiene un hijo tenemos que insertarlo como hermano
            {
                _trabajo = pNodo.Hijo;

                //Avanzamos hasta el ultimo hermano
                while(_trabajo.Hermano != null)
                {
                    _trabajo = _trabajo.Hermano;
                }

                //Creamos nodo temporal
                CNodo temp = new CNodo();

                temp.Dato = pDato;

                //Unimos el temp al ultimo hermano
                _trabajo.Hermano = temp;

                return temp;
            }
        }

        //Trasversa preorder
        public void TransversaPreOrder(CNodo pNodo)
        {
            if (pNodo == null)
                return;

            //Me proceseo primero a mi
            for (int n = 0; n < _i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);

            //Luego proceso a mi hijo
            if(pNodo.Hijo != null)
            {
                _i++;
                TransversaPreOrder(pNodo.Hijo);
                _i--;
            }

            //Si tengo hermanos los proceso
            if (pNodo.Hermano != null)
                TransversaPreOrder(pNodo.Hermano);
        }

        //Trasversa PortOrder
        public void TrasversaPostOrder(CNodo pNodo)
        {
            if (pNodo == null)
                return;

            //Primero proceso a mi hijo
            if (pNodo.Hijo != null)
            {
                _i++;
                TrasversaPostOrder(pNodo.Hijo);
                _i--;
            }

            //Si tengo hermanos los proceso
            if (pNodo.Hermano != null)
                TrasversaPostOrder(pNodo.Hermano);

            //Luego me proceseo a mi
            for(int n = 0; n < _i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);
        }

        public CNodo Buscar(string pDato, CNodo pNodo)
        {
            CNodo encontrado = null;

            if (pNodo == null)
                return encontrado;

            if (pNodo.Dato.CompareTo(pDato) == 0)
            {
                encontrado = pNodo;
                return encontrado;
            }

            //Luego proceso a mi hijo
            if (pNodo.Hijo != null)
            {
                encontrado = Buscar(pDato, pNodo.Hijo);

                if (encontrado != null)
                    return encontrado;
            }

            //Si tengo hermanos los comparo
            if (pNodo.Hermano != null)
            {
                encontrado = Buscar(pDato, pNodo.Hermano);

                if (encontrado != null)
                    return encontrado;
            }

            return encontrado;
        }
    }
}
