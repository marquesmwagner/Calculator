using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorEngine
    {
        public static int numberOfUses = 0;
        internal void Addition()
        {
            Console.WriteLine("\nType the first number: ");
            var firstNumber = Helpers.GetNumber();
            Console.WriteLine("\nType the second number: ");
            var secondNumber = Helpers.GetNumber();
            Console.WriteLine($"\n{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber, secondNumber, "+");
        }
        internal void Subtraction() 
        {
            Console.WriteLine("\nType the first number: ");
            var firstNumber = Helpers.GetNumber();
            Console.WriteLine("\nType the second number: ");
            var secondNumber = Helpers.GetNumber();
            Console.WriteLine($"\n{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber, secondNumber, "-");
        }
        internal void Multiplication()
        {
            Console.WriteLine("\nType the first number: ");
            var firstNumber = Helpers.GetNumber();
            Console.WriteLine("\nType the second number: ");
            var secondNumber = Helpers.GetNumber();
            Console.WriteLine($"\n{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber, secondNumber, "*");
        }
        internal void Division()
        {
            Console.WriteLine("\nType the first number: ");
            var firstNumber = Helpers.GetNumber();
            Console.WriteLine("\nType the second number: ");
            var secondNumber = Helpers.GetNumber();
            while (secondNumber == 0)
            {
                Console.WriteLine("Enter a non-zero divisor.");
                secondNumber = Helpers.GetNumber();
            }
            Console.WriteLine($"\n{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber,secondNumber, "/");
        }
    }
}
