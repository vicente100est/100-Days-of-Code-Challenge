using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Queue
{
    public class CNodo
    {
        //Aqui se coloca el dato o datos que guadra el nodo
        private int _dato;

        //Vaeriable de referencia para apuntar al nodo siguiente
        private CNodo _siguiebte = null;

        //Propiedades que se usaran
        public int Dato
        {
            get =>
                _dato;
            set =>
                _dato = value;
        }
        internal CNodo Siguiente
        {
            get =>
                _siguiebte;
            set =>
                _siguiebte = value;
        }

        //Para su facil impresion
        public override string ToString()
        {
            return String.Format("[{0}]", _dato);
        }
    }
}
