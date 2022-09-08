using System;

namespace _10Balance_de_Signos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = (5 + (3 * 2));
            string expresion = "";
            char s = ' ';
            CStack pila = new CStack();

            // Solicitamos la expresion a evaluar
            Console.WriteLine("Ingresa la expresion a evaluar");
            expresion = Console.ReadLine();

            foreach(char c in expresion)
            {
                //Verificar que sea simbolo de apertura
                if(c == '(' || c == '{' || c == '[')
                {
                    //Lo colocamos en el stack
                    pila.Push(c);
                }

                //Verificamos que sea simbolo de cierre
                if(c == ')' || c == '}' || c == ']')
                {
                    if (pila.StackVacio())
                    {
                        Console.WriteLine("=== Exceso de simbolos de cierre ===");
                    }
                    else
                    {
                        //Obtenemos el caracter correspondiente
                        s = pila.Pop();

                        //Verificamos que se tenga concidencia
                        if(s == '(' && c != ')')
                        {
                            Console.WriteLine("Se esperaba )");
                        }
                        if(s == '{' && c != '}')
                        {
                            Console.WriteLine("Se esperaba }");
                        }
                        if(s == '[' && c != ']')
                        {
                            Console.WriteLine("Se esperaba ]");
                        }
                    }
                }
            }

            if(pila.StackVacio() == false)
                Console.WriteLine("=== Exceso de simbolos de apertura ===");
        }
    }
}
