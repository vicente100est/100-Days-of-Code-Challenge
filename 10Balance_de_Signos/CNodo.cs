using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Balance_de_Signos
{
    public class CNodo
    {
        private char _dato;

        private CNodo _sigueinte = null;

        public char Dato { get => _dato; set => _dato = value; }
        internal CNodo Siguiente { get => _sigueinte; set => _sigueinte = value; }

        public override string ToString()
        {
            return String.Format("[{0}]", _dato);
        }
    }
}
