using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Models;

namespace Calculator
{
    internal class Helpers
    {
        internal static List<Models.Calculator> calculator = new();
        internal static double GetNumber() 
        {
            var input = "";
            var number = 0.0;
            input = Console.ReadLine();

            if (input.Trim().ToLower() == "r" && calculator.Any())
            {
                PrintLatestCalculations();
                Console.WriteLine("\nChoose a result from the list above (list start from 0)");
                var inputChoice = Console.ReadLine();
                var numChoice = 0;
                int.TryParse(inputChoice, out numChoice);
                number = calculator[numChoice].Result;
                return number;
            }

            while (!double.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input or list is empty. Please enter a valid number.");
                input = Console.ReadLine();
            }
            return number;
        }
        internal static void PrintNumberOfUses(int uses) 
        {
            Console.WriteLine($"\nThe Calculator was used {uses} times.");
        }
        internal static void StoreCalculations(double firstNumber, double secondNumber, string signal, double result)
        {
            calculator.Add(new Models.Calculator
            {
                FirstNumber = firstNumber,
                SecondNumber = secondNumber,
                Result = result,
                Signal = signal
            });
        }
        internal static void DeleteCalculations()
        {
            calculator.Clear();
            Console.WriteLine("\nDeleted all calculations.");
            PrintLatestCalculations();
        }
        internal static void PrintLatestCalculations()
        {
            Console.WriteLine("\nLastest calculations:");
            Console.WriteLine("--------------------\n");
            foreach (var calculation in calculator)
            {
                switch (calculation.Signal)
                {
                    case "Square":
                        Console.WriteLine($"{calculation.Signal} Root of {calculation.FirstNumber} = {calculation.Result:0.00}");
                        break;
                    case "exponent":
                        Console.WriteLine($"{calculation.FirstNumber} exponent to {calculation.SecondNumber} = {calculation.Result:0.00}");
                        break;
                    default:
                        Console.WriteLine($"{calculation.FirstNumber} {calculation.Signal} {calculation.SecondNumber} = {calculation.Result:0.00}");
                        break;
                }
            }
            Console.WriteLine("\n--------------------");
        }
    }
}
