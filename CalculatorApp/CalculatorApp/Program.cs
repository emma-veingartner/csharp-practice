using System;
using System.Reflection.Emit;

namespace CalculatorApp
{

    internal class Program
    {
        enum Menu { Sum = 1, Subtraction = 2, Division = 3, Multiplication = 4, Power = 5, Root = 6, Exit = 7 }

        static void Main(string[] args)
        {
            bool choosedExit = false;
            while (!choosedExit) // While the user DO NOT(!) choose Exit, show the Menu.
            {
                Console.WriteLine("Welcome to the Calculator App! Please, select one of the options:");
                Console.WriteLine("1-Sum\n2-Subtraction\n3-Division\n4-Multiplication\n5-Power\n6-Root\n7-Exit");

                /*
                string optionsTXT = Console.ReadLine();
                int optionsInt = int.Parse(optionsTXT);
                Menu options = (Menu)optionsInt;
                */

                Menu options = (Menu)int.Parse(Console.ReadLine());

                switch (options)
                {
                    case Menu.Sum:
                        Sum();
                        break;
                    case Menu.Subtraction:
                        Sub();
                        break;
                    case Menu.Division: 
                        Div();
                        break;
                    case Menu.Multiplication:
                        Mult();
                        break;
                    case Menu.Power:   
                        Pow(); 
                        break;
                    case Menu.Root:
                        Root();
                        break;
                    case Menu.Exit:
                        choosedExit = true;
                        break;
                }

                Console.Clear(); //Clear the console after select an option
            }
        }

        static void Sum()
        {
            Console.WriteLine("Sum of two numbers: ");
            Console.WriteLine("Type the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number:");
            int b = int.Parse(Console.ReadLine());
            int result = a + b;
            Console.WriteLine($"The result is: {result}");
            Console.WriteLine("Press ENTER to go back to the menu");
            Console.ReadLine();

        }

        static void Sub()
        {
            Console.WriteLine("Sutraction of two numbers: ");
            Console.WriteLine("Type the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number:");
            int b = int.Parse(Console.ReadLine());
            int result = a - b;
            Console.WriteLine($"The result is: {result}");
            Console.WriteLine("Press ENTER to go back to the menu");
            Console.ReadLine();

        }

        static void Div()
        {
            Console.WriteLine("Division of two numbers: ");
            Console.WriteLine("Type the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number:");
            int b = int.Parse(Console.ReadLine());
            float result = (float)a/(float)b;
            Console.WriteLine($"The result is: {result}");
            Console.WriteLine("Press ENTER to go back to the menu");
            Console.ReadLine();

        }

        static void Mult()
        {
            Console.WriteLine("Multiplication of two numbers: ");
            Console.WriteLine("Type the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number:");
            int b = int.Parse(Console.ReadLine());
            int result = a * b;
            Console.WriteLine($"The result is: {result}");
            Console.WriteLine("Press ENTER to go back to the menu");
            Console.ReadLine();

        }

        static void Pow()
        {
            Console.WriteLine("Power of one number: ");
            Console.WriteLine("Type the base number: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the exponent number:");
            int expo = int.Parse(Console.ReadLine());
            int result = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"The result is: {result}");
            Console.WriteLine("Press ENTER to go back to the menu");
            Console.ReadLine();

        }

        static void Root()
        {
            Console.WriteLine("Root of one number: ");
            Console.WriteLine("Type the number: ");
            int a = int.Parse(Console.ReadLine());
            double result = Math.Sqrt(a);
            Console.WriteLine($"The result is: {result}");
            Console.WriteLine("Press ENTER to go back to the menu");
            Console.ReadLine();

        }
    }
}   
