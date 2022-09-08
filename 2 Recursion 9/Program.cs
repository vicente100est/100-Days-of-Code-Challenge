using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace _2_Recursion_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pintar un arbolito locochon
            Bitmap bmp = new Bitmap(50, 50);
            Print(bmp, bmp.Width/2, 20);

            string path = @"C:\Users\vicen\OneDrive\Escritorio\Lab\100 Days of Code\Estructura de datos\Estructura de datos\2 Recursion 9\tree.jpg";
            bmp.Save(path, ImageFormat.Bmp);
        }
        static void Print(Bitmap bmp, int x, int n, int y = 0)
        {
            if(y < n)
            {
                bmp.SetPixel(x, y, Color.Red);
                Print(bmp, x + 1, n, y + 1);
                Print(bmp, x - 1, n, y + 1);
            }
        }
    }
}
