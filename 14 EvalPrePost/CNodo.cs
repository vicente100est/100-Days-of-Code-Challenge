using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_EvalPrePost
{
    public class CNodo
    {
        //Aqui colocamos el dato o datos que guarda el nodo
        private int _dato;

        //Esta variable de referencia es usada para apuntar al nodo siguiente
        private CNodo _siguiente = null;

        //Propiedades que usaremos
        public int Dato { get => _dato; set => _dato = value; }
        internal CNodo Siguiente { get => _siguiente; set => _siguiente = value; }

        //Para su facil impresion
        public override string ToString()
        {
            return String.Format("[{0}]", _dato);
        }
    }
}
