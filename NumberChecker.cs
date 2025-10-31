//Number Checker 
using System;

namespace NumberCheckerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Number Checker App ===");

            Console.Write("Enter any number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if number is positive or negative
            if (number > 0)
            {
                Console.WriteLine("The number is Positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is Negative.");
            }
            else
            {
                Console.WriteLine("The number is Zero.");
            }

            // Check even or odd
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd.");
            }

            Console.WriteLine("===========================");
            Console.WriteLine("Program finished successfully!");
        }
    }
}
    











