using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameUser = "";
            int options;
            bool again = true;

            Console.WriteLine("Identificate");
            nameUser = Console.ReadLine();

            Console.WriteLine($"Bienvenido {nameUser}");
            Console.WriteLine("Hoy que vamos a hacer");

            do
            {
                ShowMenu();
                Console.WriteLine("Chose a option");
                options = int.Parse(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        int table;
                        int limit;

                        Console.WriteLine($"{nameUser} What table do you mant to?");
                        table = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{nameUser} Chose the limit");
                        limit = int.Parse(Console.ReadLine());

                        for (int i = 0; i<=limit; i++)
                        {
                            int result = i * table;
                            Console.WriteLine($"{i} * {table} = {result}");
                        }

                        break;

                    case 2:
                        float cal1;
                        float cal2;
                        float cal3;
                        float result2;

                        Console.WriteLine($"{nameUser} Califiation 1");
                        cal1 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"{nameUser} Calification 2");
                        cal2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"{nameUser} Calification 3");
                        cal3 = float.Parse(Console.ReadLine());

                        result2 = (cal1 + cal2 + cal3)/3;

                        Console.WriteLine($"{nameUser} your calification is {result2}");

                        if (result2 <= 10 && result2 >= 0)
                        {
                            if (result2 >= 8)
                            {
                                Console.WriteLine($"Congratulations {nameUser} you pass");
                            }
                            else
                            {
                                Console.WriteLine($"I am sorry, you qualification is {result2} you filled");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The ir are error in your calification");
                        }
                        break;

                    case 3:
                        int age;
                        Console.WriteLine($"{nameUser} How old are you?");
                        age = int.Parse(Console.ReadLine());

                        if (age >= 0)
                        {
                            if (age >= 22)
                            {
                                Console.WriteLine($"{nameUser} you are legal buy a berr");
                            }
                            else
                            {
                                Console.WriteLine($"I am sorry {nameUser} you are not legal You can not buy a beer");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error in age");
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error in the option");
                        break;
                }
            } while(again);
        }

        public static void ShowMenu()
        {
            Console.WriteLine("-----   Options   -----");
            Console.WriteLine("1 Multiplication Tables");
            Console.WriteLine("2 The student Passed or Filed");
            Console.WriteLine("3 Are U lega; age internationally?");
            Console.WriteLine("0 Bye");
        }
    }
}
