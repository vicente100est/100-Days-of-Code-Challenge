using _16_HashSeparate;

class Program
{
    //Cantidad de celdas en la tabla
    private static int _tamano = 7;
    private static CListaLigada[] _table;

    public static void Main(String[] args)
    {
        int n = 0;

        //Necesitamos un arreglo de listas ligadas para crear la tabla
        _table = new CListaLigada[_tamano];

        //Inicializamos la tablas
        for (n = 0; n < _tamano; n++)
            _table[n] = new CListaLigada();

        Mostrar();

        Console.WriteLine("----");

        Insertar(57, "Hola");
        Insertar(45, "Manzana");
        Insertar(42, "Pera");
        Insertar(83, "Azul");
        Insertar(30, "Rojo");
        Insertar(94, "C#");
        Insertar(73, "C++");
        Insertar(97, "Saludos");

        Mostrar();
        Console.WriteLine("----");
    }

    public static void Mostrar()
    {
        int n = 0;

        for (n = 0; n < _tamano; n++)
        {
            Console.Write("({0})", n);
            _table[n].Transversa();
            Console.WriteLine();
        }
    }

    public static int HashF(int pLlave)
    {
        int indice = 0;

        //Faunciona  muy sencilla, no usar en el mundo real
        indice = pLlave % _tamano;

        return indice;
    }

    public static void Insertar(int pLlave, string pValor)
    {
        int indice = HashF(pLlave);

        _table[indice].Adicionar(pLlave, pValor);
    }
}