using System;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the applicant's age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask if the applicant has ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // Ask how many speeding tickets the applicant has
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Determine if the applicant qualifies for car insurance
            bool isQualified = (age > 15) && !hasDUI && (speedingTickets <= 3);

            // Print the result of the qualification check
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}

