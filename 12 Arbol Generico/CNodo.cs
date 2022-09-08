using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Arbol_Generico
{
    public class CNodo
    {
        private string _dato;

        private CNodo _hijo;
        private CNodo _hermano;

        public string Dato { get => _dato; set => _dato = value; }
        public CNodo Hijo { get => _hijo; set => _hijo = value; }
        public CNodo Hermano { get => _hermano; set => _hermano = value; }

        public CNodo()
        {
            _dato = "";
            _hijo = null;
            _hermano = null;
        }
    }
}
