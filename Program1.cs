using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.WriteLine("Enter a number:");

            // Read the input from the user and convert it to a double
            double input = Convert.ToDouble(Console.ReadLine());

            // Multiply the input by 50 and print the result
            double result1 = input * 50;
            Console.WriteLine("Result of multiplying by 50: " + result1);

            // Add 25 to the input and print the result
            double result2 = input + 25;
            Console.WriteLine("Result of adding 25: " + result2);

            // Divide the input by 12.5 and print the result
            double result3 = input / 12.5;
            Console.WriteLine("Result of dividing by 12.5: " + result3);

            // Check if the input is greater than 50 and print the result
            bool isGreaterThan50 = input > 50;
            Console.WriteLine("Is the input greater than 50? " + isGreaterThan50);

            // Divide the input by 7 and print the remainder
            double remainder = input % 7;
            Console.WriteLine("Remainder when divided by 7: " + remainder);
            Console.ReadLine(); 
        }
    }
}

