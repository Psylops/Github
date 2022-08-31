using System;
using System.Security.Cryptography.X509Certificates;

namespace multicalc
{


    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.Title = "Multipurpose Calculator";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This is a nurmal functioning multipurpose calculator that can add, subtract,multiply,divide.");
            Console.WriteLine("Please enter your first number");
            Console.ForegroundColor = ConsoleColor.Green;
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please enter your second number");
            Console.ForegroundColor = ConsoleColor.Green;
            num2 = Convert.ToInt32(Console.ReadLine());
            int tries = 4;
            Options();

            void Options()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");
                Console.ForegroundColor = ConsoleColor.Green;
                int opt = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan;
                string opr;
                if (opt == 1)
                {
                    Console.WriteLine("Add");
                }
                else if (opt == 2)
                {
                    Console.WriteLine("Sub");
                }
                else if (opt == 3)
                {
                    Console.WriteLine("multi");
                }
                else if (opt == 4)
                {
                    Console.WriteLine("Div");
                }
                else
                {
                    Console.Beep();
                    --tries;
                    if (tries == 1)
                    {
                        Console.WriteLine("1 more try");
                    }
                    else if (tries == 0)
                    {
                        Console.WriteLine("No more tries");
                        Console.Beep();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("{0} more tries", tries);
                    }
                    Options();
                }
                
                

            }  
        }
    }
}