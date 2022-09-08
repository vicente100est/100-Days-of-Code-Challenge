using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Lista_Ligada_1
{
    public class CNodo
    {
        //Aqui colocamos el dato o datos que guarde el nodo
        private int _dato;

        //Esta variable de referencia es usada para apuntar al nodo siguiente
        private CNodo _sigueinte = null;

        //Propiedades que usaremos
        public int Dato { get => _dato; set => _dato = value; }
        internal CNodo Siguiente { get => _sigueinte; set => _sigueinte = value; }

        //Para su facil impresion
        public override string ToString()
        {
            return String.Format("[{0}]", _dato);
        }
    }
}
