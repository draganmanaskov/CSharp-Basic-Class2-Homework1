using System;

namespace Task3_SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number: ");
            bool isValidFirst = int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Input the second number: ");
            bool isValidSecond = int.TryParse(Console.ReadLine(), out int secondNumber);

            if (!isValidFirst || !isValidSecond)
            {
                Console.WriteLine("Error! Invalid Input!");
            }
            else
            {
                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;

                Console.WriteLine("After Swapping");
                Console.WriteLine($"First Number: {firstNumber}");
                Console.WriteLine($"Second Number: {secondNumber}");
            }

        }
    }
}
