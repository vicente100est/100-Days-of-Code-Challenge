using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_Datos_II
{
    public class CNodo
    {
        private int _dato;

        private CNodo _izq;
        private CNodo _der;

        public int Dato { get => _dato; set => _dato = value; }
        internal CNodo Izq { get => _izq; set => _izq = value; }
        internal CNodo Der { get => _der; set => _der = value; }

        public CNodo()
        {
            _dato = 0;
            _izq = null;
            _der = null;
        }
    }
}
