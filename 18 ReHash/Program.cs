using System;

namespace _18_ReHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CHashTable miTabla = new CHashTable(11);

            miTabla.Insertar(23, "Hola");
            miTabla.Insertar(51, "Manzana");
            miTabla.Insertar(40, "Pera");
            miTabla.Insertar(62, "Mango");
            miTabla.Insertar(32, "Prueba");
            miTabla.Insertar(11, "de");
            miTabla.Insertar(21, "rehash");

            miTabla.Mostrar();

            miTabla.Insertar(4, "en C#");

            miTabla.Mostrar();
        }
    }
}
