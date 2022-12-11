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
        internal static void StoreCalculations(double firstNumber, double secondNumber, string signal)
        {
            calculator.Add(new Models.Calculator
            {
                FirstNumber = firstNumber,
                SecondNumber = secondNumber,
                Result = firstNumber + secondNumber,
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
                if (calculation.Signal == "Square")
                {
                    Console.WriteLine($"{calculation.Signal} Root of {calculation.FirstNumber} = {calculation.Result}");
                }
                else
                {
                    Console.WriteLine($"{calculation.FirstNumber} {calculation.Signal} {calculation.SecondNumber} = {calculation.Result}");
                }
            }
            Console.WriteLine("\n--------------------");
        }
    }
}
