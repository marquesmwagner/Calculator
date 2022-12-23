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
            var result = firstNumber + secondNumber;
            Console.WriteLine($"\n{firstNumber} + {secondNumber} = {result}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber, secondNumber, "+", result);
        }
        internal void Subtraction() 
        {
            Console.WriteLine("\nType the first number or choose a result(type r)");
            var firstNumber = Helpers.GetNumber();
            Console.WriteLine("\nType the second number or choose a result(type r)");
            var secondNumber = Helpers.GetNumber();
            var result = firstNumber - secondNumber;
            Console.WriteLine($"\n{firstNumber} - {secondNumber} = {result}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber, secondNumber, "-", result);
        }
        internal void Multiplication()
        {
            Console.WriteLine("\nType the first number or choose a result(type r)");
            var firstNumber = Helpers.GetNumber();
            Console.WriteLine("\nType the second number or choose a result(type r)");
            var secondNumber = Helpers.GetNumber();
            var result = firstNumber * secondNumber;
            Console.WriteLine($"\n{firstNumber} * {secondNumber} = {result}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber, secondNumber, "*", result);
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
            var result = firstNumber / secondNumber;
            Console.WriteLine($"\n{firstNumber} / {secondNumber} = {result}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber,secondNumber, "/", result);
        }
        internal void SquareRoot()
        {
            Console.WriteLine("\nType a number or choose a result(type r)");
            var number = Helpers.GetNumber();
            var result = Math.Sqrt(number);
            Console.WriteLine($"\nSquare Root of {number} = {result}");
            numberOfUses++;
            Helpers.StoreCalculations(number, 0, "Square", result);
        }
        internal void Exponent()
        {
            Console.WriteLine("\nType the first number(base) or choose a result(type r)");
            var firstNumber = Helpers.GetNumber();
            Console.WriteLine("\nType the second number(exponent) or choose a result(type r)");
            var secondNumber = Helpers.GetNumber();
            var result = Math.Pow(firstNumber, secondNumber);
            Console.WriteLine($"\n{firstNumber} exponent to {secondNumber} = {result}");
            numberOfUses++;
            Helpers.StoreCalculations(firstNumber, secondNumber, "exponent", result);
        }
    }
}
