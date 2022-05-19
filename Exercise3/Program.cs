using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            int op = 0;

            do
            {
                ShowMenu();
                Console.WriteLine("Chose a option");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("What is the best program lenguage?");
                        string lenguage = Console.ReadLine();
                        if (lenguage == "C#")
                        {
                            Console.WriteLine("Yes it is, you are a Crack");
                        }
                        else
                        {
                            Console.WriteLine("Hahahaha no, idiot");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Shows the first 100 numbers in reverse, that is, from 100 to 1");

                        int counter = 100;

                        while (counter >= 1)
                        {
                            Console.WriteLine($"{counter}");
                            counter--;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Show even numbers in the range 1 to 100");

                        int counter2 = 1;

                        while (counter2 <= 100)
                        {
                            if (counter2 %2 == 0)
                            {
                                Console.WriteLine(counter2);
                            }

                            counter2++;
                        }

                        break;

                    case 0:
                        again = false;
                        break;

                    default:
                        Console.WriteLine("Error in the option");
                        break;
                }
            }while (again);
        }

        public static void ShowMenu()
        {
            Console.WriteLine("---------- Apps with While ----------");
            Console.WriteLine("1 What is the best program Lenguage?");
            Console.WriteLine("2 Shows the first 100 numbers in reverse, that is, from 100 to 1");
            Console.WriteLine("3 Show even numbers in the range 1 to 100");
            Console.WriteLine("0 Exit");
        }
    }
}
