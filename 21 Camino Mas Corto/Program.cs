using _21_Camino_Mas_Corto;

int inicio = 2;
int final = 0;
int distancia = 0;
int n = 0;
int m = 0;
int cantidadNodos = 7;
string dato = "";

//Creamos grafo

CGrafo miGrafo = new(cantidadNodos);

miGrafo.AdicionaArista(0,1);
miGrafo.AdicionaArista(0,3);
miGrafo.AdicionaArista(1,3);
miGrafo.AdicionaArista(1,4);
miGrafo.AdicionaArista(2,0);
miGrafo.AdicionaArista(2,5);
miGrafo.AdicionaArista(3,2);
miGrafo.AdicionaArista(3,4);
miGrafo.AdicionaArista(3,5);
miGrafo.AdicionaArista(3,6);
miGrafo.AdicionaArista(4,6);
miGrafo.AdicionaArista(6,5);

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
int[,] tabla = new int[cantidadNodos, 3];

//Inicializamos la tabla
for (n = 0; n < cantidadNodos; n++)
{
    tabla[n, 0] = 0;
    tabla[n, 1] = int.MaxValue;
    tabla[n, 2] = 0;
}
tabla[inicio, 1] = 0;

MostrarTabla(tabla);

for (distancia = 0; distancia < cantidadNodos; distancia++)
{
    for (n = 0; n < cantidadNodos; n++)
    {
        if ((tabla[n,0] == 0) && (tabla[n,1] == distancia))
        {
            tabla[n, 0] = 1;
            for (m = 0; m < cantidadNodos; m++)
            {
                //Verificamos que el nodo sea adyacente
                if (miGrafo.ObtenerAdyacencia(n, m) == 1)
                {
                    if (tabla[m, 1] == int.MaxValue)
                    {
                        tabla[m, 1] = distancia + 1;
                        tabla[m, 2] = n;
                    }
                }
            }
        }
    }
}

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