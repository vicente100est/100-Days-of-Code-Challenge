using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _18_ReHash
{
    public class CHashTable
    {
        private CCelda[] _tabla;
        private int _cantidad;
        private int _insertados;

        public CHashTable(int pTamano)
        {
            int n = 0;
            _cantidad = pTamano;
            _insertados = 0;
            _tabla = new CCelda[_cantidad];

            for (n = 0; n < _cantidad; n++)
                _tabla[n] = new CCelda();
        }

        public int HashF(int pLlave, int pIntento)
        {
            int indice = 0;

            //Lineal probing
            //indice = (pLlave + pIntento) % _cantidad;

            //Quadratic probing
            indice = (pLlave + (pIntento * pIntento)) % _cantidad;

            return indice;
        }

        public void Mostrar()
        {
            int n = 0;

            for (n = 0; n < _cantidad; n++)
            {
                Console.WriteLine("{0} [{1},{2}]", n, _tabla[n].Llave, _tabla[n].Valor);
            }
        }

        public void Insertar(int pLlave, string pValor)
        {
            //Contador de intentos
            int i = 0;

            int indice = 0;
            bool ocupado = false;

            while (ocupado == false)
            {
                //Calculamos el indice
                indice = HashF(pLlave, i);

                //Verificamos si esta vacia la celda
                if (_tabla[indice].MiEstado == estado.vacio)
                {
                    ocupado = true;
                    _tabla[indice].Llave = pLlave;
                    _tabla[indice].Valor = pValor;
                    _tabla[indice].MiEstado = estado.ocupado;
                    _insertados++;
                }
                else
                {
                    //Avanzamos al siguiente intento
                    i++;
                }
            }

            //Verificamos si es necesario hacer un rehash
            if (_insertados >= ((double)_cantidad * 0.7))
            {
                Console.WriteLine("--Es necesario hacer rehash, {0} de {1} ocupados", _insertados, _cantidad);
                ReHash();
            }
        }

        public int PrimoCercano(int pValor)
        {
            int primo = 0;
            bool divide = false;
            int n = 0;

            while (primo == 0)
            {
                divide = false;
                for (n = 2; n < pValor; n++)
                {
                    if (pValor % n == 0)
                    {
                        divide = true;
                        pValor++;
                        break;
                    }
                }

                if (divide == false)
                    primo = pValor;
            }

            return primo;
        }

        public void ReHash()
        {
            //Calculamos el nuevo tamano
            int nCantidad = PrimoCercano(_cantidad * 2);
            int cantAnterior = _cantidad;
            int n = 0;
            int llave = 0;
            string valor = "";

            int i = 0;
            int indice = 0;
            bool ocupado = false;

            Console.WriteLine("Ahora la tabla sera de {0} espacios", nCantidad);

            //Creamos la nueva tabla
            CCelda[] temp = new CCelda[nCantidad];

            for (n = 0; n < nCantidad; n++)
                temp[n] = new CCelda();

            //Actualizamos cantidad para que la funcion de hash funcione bien
            _cantidad = nCantidad;

            //Recorremos la tabla y vamos insertando a la nueva
            for (n = 0; n < cantAnterior; n++)
            {
                //Verificamos si hay un elemento a insertar
                if (_tabla[n].MiEstado == estado.ocupado)
                {
                    llave = _tabla[n].Llave;
                    valor = _tabla[n].Valor;

                    ocupado = false;

                    //Hacemos la insercion en la nueva tabla
                    while (ocupado == false)
                    {
                        //Calculamos el indice
                        indice = HashF(llave, i);

                        //Verificamos si esta vacia la celda
                        if (temp[indice].MiEstado == estado.vacio)
                        {
                            ocupado = true;
                            temp[indice].Llave = llave;
                            temp[indice].Valor = valor;
                            temp[indice].MiEstado = estado.ocupado;
                            _insertados++;
                        }
                        else
                        {
                            //Avanzamos al siguiente intento
                            i++;
                        }
                    }
                }
            }

            _tabla = (CCelda[])temp.Clone();
        }
    }
}
