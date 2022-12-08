namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            int timeCalc = 0;

            Console.WriteLine("Console Calculator in C#\n");
            Console.WriteLine("------------------------\n");
            
            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.WriteLine("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("This is not a valid input. Please enter an integer value: ");
                    numInput1= Console.ReadLine();
                }

                Console.WriteLine("Type another number, and then press Enter : ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("This is not a valid input. Please enter an integer value: ");
                    numInput2= Console.ReadLine();
                }

                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("Your option?");

                string op = Console.ReadLine().ToLower();
                while (!op.Equals("a") && !op.Equals("s") && !op.Equals("m") && !op.Equals("d"))
                {
                    Console.WriteLine("Please enter a valid operator.");
                    op = Console.ReadLine().ToLower();
                }

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Oh no! An exception ocurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                Console.WriteLine("Press 'n' and Enter to close the app, or any other Key and Enter to continue: ");
                if (Console.ReadLine().ToLower() == "n") endApp = true;

                Console.WriteLine("\n");
                Console.WriteLine("The Calculator was used {0} times.\n", ++timeCalc);
            }
            return;
        }
    }
}