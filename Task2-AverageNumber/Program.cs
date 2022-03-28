using System;

namespace Task2_AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if the input can't be parsed, we won't throw an error we will count it as a 0
            Console.WriteLine("Enter the first number: ");
            int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Enter the second number: ");
            int.TryParse(Console.ReadLine(), out int secondNumber);

            Console.WriteLine("Enter the third number: ");
            int.TryParse(Console.ReadLine(), out int thirdNumber);

            Console.WriteLine("Enter the fourth number: ");
            int.TryParse(Console.ReadLine(), out int fourthNumber);

            int sum = firstNumber + secondNumber + thirdNumber + fourthNumber;

            //if there isnt a valid input write error
            if (sum == 0)
            {
                Console.WriteLine("Error! Cannot calculate average of 0");
            }
            else
            {
                Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is: {(decimal)sum / 4}");
            }

        }
    }
}
