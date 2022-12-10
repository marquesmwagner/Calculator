using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Helpers
    {
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
    }
}
