using _22_Dijkstra;

int inicio = 0;
int final = 0;
int distancia = 0;
int n = 0;
int cantNodos = 7;
string dato = "";
int actual = 0;
int columna = 0;

//Creamos el grafo
var miGrafo = new CGrafo(cantNodos);

miGrafo.AdicionaArista(0,1,2);
miGrafo.AdicionaArista(0,3,1);
miGrafo.AdicionaArista(1,3,3);
miGrafo.AdicionaArista(1,4,10);
miGrafo.AdicionaArista(2,0,4);
miGrafo.AdicionaArista(2,5,5);
miGrafo.AdicionaArista(3,2,2);
miGrafo.AdicionaArista(3,4,2);
miGrafo.AdicionaArista(3,5,8);
miGrafo.AdicionaArista(3,6,4);
miGrafo.AdicionaArista(4,6,6);
miGrafo.AdicionaArista(6,5,1);

miGrafo.MuestraAdyacencia();

Console.WriteLine("Dame el indice del nodo inicio");
dato = Console.ReadLine();
inicio = Convert.ToInt32(dato);

Console.WriteLine("Dame el inidce del nodo final");
dato = Console.ReadLine();
final = Convert.ToInt32(dato);

//Creamos la tabla
// 0 - Visitado
// 1 - Distancia
// 2 - Previo
int[,] tabla = new int[cantNodos, 3];

//Inicializamos la tabla
for (n = 0; n < cantNodos; n++)
{
    tabla[n, 0] = 0;
    tabla[n, 1] = int.MaxValue;
    tabla[n, 2] = 0;
}
tabla[inicio, 1] = 0;

MostrarTabla(tabla);

//Algoritmo de Dijkstra
actual = inicio;

do
{
    //Marcar nodo como visitado
    tabla[actual, 0] = 1;

    for (columna = 0; columna < cantNodos; columna++)
    {
        //Buscamos a quien se dirige
        if (miGrafo.ObtenerAdyacencia(actual, columna) != 0)
        {
            //Calculamos la distancia
            distancia = miGrafo.ObtenerAdyacencia(actual, columna) + tabla[actual, 1];

            //Colocamos las distancias
            if (distancia < tabla[columna, 1])
            {
                tabla[columna, 1] = distancia;

                //Colocamos la informacion de padre
                tabla[columna, 2] = actual;
            }
        }
    }

    //El nuevo actual es el nodod con la menor distancia que no ha sido visitado

    int indiceMenor = -1;
    int distanciaMenor = int.MaxValue;

    for (int x = 0; x < cantNodos; x++)
    {
        if (tabla[x, 1] < distanciaMenor && tabla[x, 0] == 0)
        {
            indiceMenor = x;
            distanciaMenor = tabla[x, 1];
        }
    }

    actual = indiceMenor;

} while (actual != -1);

MostrarTabla(tabla);

//Obtenemos la ruta
List<int> ruta = new List<int>();
int nodo = final;

while (nodo != inicio)
{
    ruta.Add(nodo);
    nodo = tabla[nodo, 2];
}

ruta.Add(inicio);

ruta.Reverse();

foreach (int posicion in ruta)
    Console.Write("{0}->", posicion);

Console.WriteLine();


static void MostrarTabla(int[,] pTabla)
{
    int n = 0;

    for (n = 0; n < pTabla.GetLength(0); n++)
    {
        Console.WriteLine("{0}-> {1}\t{2}\t{3}", n, pTabla[n, 0], pTabla[n, 1], pTabla[n, 2]);
    }

    Console.WriteLine("-------------------");
}