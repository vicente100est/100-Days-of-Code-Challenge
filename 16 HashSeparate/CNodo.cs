using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_HashSeparate
{
    public class CNodo
    {
        //Aqui colocamos el dato o datos que guarda el nodo
        private int _llave;
        private string _valor;

        //Esta variable de referencia es usada para apuntar al nodo siguiente
        private CNodo _siguiente = null;

        //Propiedades que usaremos
        public int Llave { get => _llave; set => _llave = value; }
        public string Valor { get => _valor; set => _valor = value; }

        internal CNodo Siguiente { get => _siguiente; set => _siguiente = value; }

        //Para su facil impresion
        public override string ToString()
        {
            return String.Format("[{0}, {1}]", _llave, _valor);
        }
    }
}
