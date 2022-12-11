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
            Console.WriteLine("\nType the first number or choose a result(type r)");
            var firstNumber = Helpers.GetNumber();
            Console.WriteLine("\nType the second number or choose a result(type r)");
            var secondNumber = Helpers.GetNumber();
            Console.WriteLine($"\n{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber, secondNumber, "+");
        }
        internal void Subtraction() 
        {
            Console.WriteLine("\nType the first number or choose a result(type r)");
            var firstNumber = Helpers.GetNumber();
            Console.WriteLine("\nType the second number or choose a result(type r)");
            var secondNumber = Helpers.GetNumber();
            Console.WriteLine($"\n{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber, secondNumber, "-");
        }
        internal void Multiplication()
        {
            Console.WriteLine("\nType the first number or choose a result(type r)");
            var firstNumber = Helpers.GetNumber();
            Console.WriteLine("\nType the second number or choose a result(type r)");
            var secondNumber = Helpers.GetNumber();
            Console.WriteLine($"\n{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber, secondNumber, "*");
        }
        internal void Division()
        {
            Console.WriteLine("\nType the first number or choose a result(type r)");
            var firstNumber = Helpers.GetNumber();
            Console.WriteLine("\nType the second number or choose a result(type r)");
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
        internal void SquareRoot()
        {
            Console.WriteLine("\nType a number or choose a result(type r)");
            var number = Helpers.GetNumber();
            Console.WriteLine($"\nSquare Root of {number} = {Math.Sqrt(number)}");
            numberOfUses++;
            Helpers.StoreCalculations(number, 0, "Square");
        }
    }
}
