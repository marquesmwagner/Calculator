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
            input = Console.ReadLine();

            var number = 0.0;
            while (!double.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                input= Console.ReadLine();
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
        internal static void PrintLatestCalculations()
        {
            Console.WriteLine("\nLastest Calculatios:");
            Console.WriteLine("--------------------\n");
            foreach (var calculation in calculator) 
            {
                Console.WriteLine($"{calculation.FirstNumber} {calculation.Signal} {calculation.SecondNumber} = {calculation.Result}");
            }
            Console.WriteLine("\n--------------------");
        }
    }
}
