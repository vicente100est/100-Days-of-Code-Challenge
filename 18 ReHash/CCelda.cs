using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ReHash
{
    enum estado
    {
        vacio, ocupado, borrado
    }
    public class CCelda
    {
        private int _llave;
        private string _valor;

        private estado _miEstado;

        public int Llave { get => _llave; set => _llave = value; }
        public string Valor { get => _valor; set => _valor = value; }
        internal estado MiEstado { get => _miEstado; set => _miEstado = value; }

        public CCelda()
        {
            _llave = 0;
            _valor = "";
            _miEstado = estado.vacio;
        }
    }
}
