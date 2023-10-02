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

                    case Menu.Exit:
                        choosedExit=true;
                        break;
                }

                
                Console.Clear(); //Clear the console after select an option

                

            }




            // Console.WriteLine(options);
            // Console.ReadLine(); //Pause on the console
             



        }
    }
}