using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            string textResult = "";

            Console.WriteLine("Invierte una cadena");
            Console.WriteLine("Ingrese la cadena a convertir");
            text = Console.ReadLine();

            /*
             * Forma tradicional
            for (int i = text.Length-1; i >= 0; i--)
            {
                textResult += text[i];
            }
            */

            char[] chars = text.ToCharArray();
            Array.Reverse(chars);

            textResult = new string(chars);

            Console.WriteLine(textResult);
        }
    }
}
