using _17_HashProbing;

public class Program
{
    private static CCelda[] _tabla;
    private static int _cantidad;

    static void Main(string[] args)
    {
        int n = 0;

        //Inicializamos la tabla
        _cantidad = 11;

        _tabla = new CCelda[_cantidad];

        for (n = 0; n < _cantidad; n++)
            _tabla[n] = new CCelda();

        //Mostrar

        Insertar(23, "Hola");
        Insertar(51, "Manzana");
        Insertar(40, "Pera");
        Insertar(62, "Mango");

        Mostrar();
    }

    public static void Mostrar()
    {
        int n = 0;

        for (n = 0; n < _cantidad; n++)
        {
            Console.WriteLine("{0} [{1},{2}]", n, _tabla[n].Llave, _tabla[n].Valor);
        }
    }

    public static int HashF(int pLlave, int pIntento)
    {
        int indice = 0;

        //Lineal probing
        //indice = (pLlave + pIntento) % _cantidad;

        //Quadratic probing
        indice = (pLlave + pIntento * pIntento) % _cantidad;

        return indice;
    }

    public static void Insertar(int pLlave, string pValor)
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
            }
            else
            {
                //Avanzamos al siguiente intento
                i++;
            }
        }
    }
}