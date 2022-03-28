using System;

namespace Task1_RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get and parse the first number
            Console.WriteLine("Enter the first number");
            string firstNumber = Console.ReadLine();
            bool isValidParseOne = int.TryParse(firstNumber, out int firstNumberParsed);

            //get and parse the second number
            Console.WriteLine("Enter the second number");
            string secondNumber = Console.ReadLine();
            bool isValidParseTwo = int.TryParse(secondNumber, out int secondNumberParsed);

            //get the operator
            Console.WriteLine("Choose the operation symbol: ( +, - , * , / )");
            string operatonSymbol = Console.ReadLine();

            if (!isValidParseOne || !isValidParseTwo)
            {
                Console.WriteLine("Please enter a valid number");
            }
            else
            {
                switch (operatonSymbol)
                {
                    case "+":
                        Console.WriteLine($"The result is {firstNumberParsed + secondNumberParsed}");
                        break;
                    case "-":
                        Console.WriteLine($"The result is {firstNumberParsed - secondNumberParsed}");
                        break;
                    case "*":
                        Console.WriteLine($"The result is {firstNumberParsed * secondNumberParsed}");
                        break;
                    case "/":
                        if(secondNumberParsed == 0)
                        {
                            Console.WriteLine("Cant devide wih 0");
                            break;
                        }
                        Console.WriteLine("The result is {0:0.00}", (double)firstNumberParsed / (double)secondNumberParsed);
                        break;
                    default:
                        Console.WriteLine($"Error! Invalid operator {operatonSymbol}");
                        break;
                }
            }
        }
    }
}
