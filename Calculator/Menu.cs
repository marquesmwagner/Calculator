using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Menu
    {
        CalculatorEngine engine = new ();
        internal void ShowMenu()
        {
            Console.WriteLine("Console Calculator in C#\n");
            Console.WriteLine("------------------------");

            var calcIsRun = false;
            
            do
            {
                Console.WriteLine("\nChoose an operation: ");
                Console.WriteLine("\tA - Addition");
                Console.WriteLine("\tS - Subtraction");
                Console.WriteLine("\tM - Multiplication");
                Console.WriteLine("\tD - Division");
                Console.WriteLine("\tU - View the amount of times the calculator was used");
                Console.WriteLine("\tV - View the latest calculations");
                Console.WriteLine("\tR - Delete the latest calculations");
                Console.WriteLine("\tQ - Quit Program");

                string op = Console.ReadLine().Trim().ToLower();

                switch (op)
                {
                    case "a":
                        engine.Addition();
                        break;
                    case "s":
                        engine.Subtraction();
                        break;
                    case "m":
                        engine.Multiplication();
                        break;
                    case "d":
                        engine.Division();
                        break;
                    case "u":
                        Helpers.PrintNumberOfUses(CalculatorEngine.numberOfUses);
                        break;
                    case "v":
                        Helpers.PrintLatestCalculations();
                        break;
                    case "r":
                        Helpers.DeleteCalculations();
                        break;
                    case "q":
                        Console.WriteLine("\nQuit Program. Thx for use!");
                        calcIsRun = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid input");
                        break;
                }
            } while (!calcIsRun);
        }
    }
}
