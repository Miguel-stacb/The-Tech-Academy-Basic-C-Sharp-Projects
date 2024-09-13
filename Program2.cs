using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the title of the program
            Console.WriteLine("Anonymous Income Comparison Program");

            // Get details for Person 1
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate? ");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked per week? ");
            double hoursPerWeek1 = Convert.ToDouble(Console.ReadLine());

            // Get details for Person 2
            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate? ");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked per week? ");
            double hoursPerWeek2 = Convert.ToDouble(Console.ReadLine());

            // Calculate annual salary for Person 1
            double annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalary1);

            // Calculate annual salary for Person 2
            double annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            // Compare the annual salaries and print the result
            bool doesPerson1MakeMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(doesPerson1MakeMore);
            Console.ReadLine();
        }
    }
}

