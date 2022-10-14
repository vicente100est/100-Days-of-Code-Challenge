using System;

namespace Estructura_de_Datos_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CArbolBB arbol = new CArbolBB();

            CNodo raiz = arbol.Insertar(6, null);
            arbol.Insertar(2, raiz);
            arbol.Insertar(8, raiz);
            arbol.Insertar(1, raiz);
            arbol.Insertar(4, raiz);
            arbol.Insertar(3, raiz);
            arbol.Insertar(5, raiz);
            arbol.Insertar(7, raiz);
            arbol.Insertar(11, raiz);
            arbol.Insertar(9, raiz);
            arbol.Insertar(10, raiz);
            arbol.Insertar(0, raiz);
            arbol.Insertar(-1, raiz);
            arbol.Insertar(12, raiz);
            arbol.Insertar(14, raiz);

            arbol.Trasversa(raiz);

            //Console.WriteLine("El menos es {0}", arbol.EncuentraMinimo(raiz));
            //Console.WriteLine("El mayor es {0}", arbol.EncuentraMaximo(raiz));

            //arbol.TransversaInOrder(raiz);

            //CNodo temp = arbol.EncuentraNodoMinimo(raiz);
            //Console.WriteLine($"\n {temp.Dato}");

            Console.WriteLine("------------------");

            CNodo padre = arbol.BuscarPadre(11, raiz);
            Console.WriteLine(padre.Dato);
        }
    }
}
