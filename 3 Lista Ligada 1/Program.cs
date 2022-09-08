using System;

namespace _3_Lista_Ligada_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CListaLigada miLista = new CListaLigada();

            miLista.Adicionar(3);
            miLista.Adicionar(5);
            miLista.Adicionar(7);
            miLista.Adicionar(9);
            miLista.Adicionar(11);
            miLista.Adicionar(15);

            Console.WriteLine("Primera Transversa");
            miLista.Transversa();
            Console.WriteLine(miLista.EstaVacio());

            /*
            miLista.Vaciar();

            Console.WriteLine("Segunda Transversa");
            miLista.Transversa();
            Console.WriteLine(miLista.EstaVacio());

            CNodo encontrado = miLista.Buscar(155);
            Console.WriteLine(encontrado);

            Console.WriteLine(miLista.BuscarIndice(15));

            Console.WriteLine(miLista.BuscarAnterior(3));

            miLista.Borrar(7);

            miLista.Transversa();

            miLista.Insertar(15, 20);
            miLista.Transversa();

            miLista.InsertarInicio(4);
            miLista.Transversa();

            Console.WriteLine(miLista.ObtenerPorIndice(5));*/

            Console.WriteLine(miLista[3]);

            miLista[3] = 55;
            miLista.Transversa();
        }
    }
}
