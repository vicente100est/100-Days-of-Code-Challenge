using System;

namespace _12_Arbol_Generico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CArbol arbol = new CArbol();

            CNodo raiz = arbol.Insertar("a", null);

            arbol.Insertar("b", raiz);
            arbol.Insertar("c", raiz);

            //arbol.TransversaPreOrder(raiz);

            CNodo n = arbol.Insertar("d", raiz);
            arbol.Insertar("h", n);

            n = arbol.Insertar("e", raiz);
            arbol.Insertar("i", n);
            n = arbol.Insertar("j", n);
            arbol.Insertar("p", n);
            arbol.Insertar("q", n);

            //arbol.TransversaPreOrder(raiz);

            n = arbol.Insertar("f", raiz);
            arbol.Insertar("k", n);
            arbol.Insertar("l", n);
            arbol.Insertar("m", n);

            n = arbol.Insertar("g", raiz);
            arbol.Insertar("n", n);

            arbol.TransversaPreOrder(raiz);
            Console.WriteLine("------");
            //arbol.TrasversaPostOrder(raiz);
            //Console.WriteLine("------");

            CNodo encontrado = arbol.Buscar("w", raiz);
            if (encontrado != null)
                Console.WriteLine(encontrado.Dato);
            else
                Console.WriteLine("No se encontro resultado");

            Console.WriteLine("------");

            string donde = "";
            string que = "";
            Console.Write("En donde deseas insertar: ");
            donde = Console.ReadLine();
            Console.Write("Que deseas insertar: ");
            que = Console.ReadLine();

            encontrado = arbol.Buscar(donde, raiz);
            arbol.Insertar(que, encontrado);
            arbol.TransversaPreOrder(raiz);
        }
    }
}
