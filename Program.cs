using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print the academy's name
            Console.WriteLine("The Tech Academy.");

            // Print the daily report title
            Console.WriteLine("Student Daily Report.");

            // Ask for the student's name and store it in a variable
            Console.Write("What is your name? ");
            string studentName = Console.ReadLine();

            // Ask for the course name and store it in a variable
            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine();

            // Ask for the page number and store it as an integer
            Console.Write("What page number? ");
            int pageNumber = int.Parse(Console.ReadLine());

            // Ask if the student needs help, expecting true or false
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false.\" ");
            bool needsHelp = bool.Parse(Console.ReadLine());

            // Ask for any positive experiences and store it in a variable
            Console.Write("Were there any positive experiences you’d like to share? Please give specifics. ");
            string positiveExperience = Console.ReadLine();

            // Ask for any other feedback and store it in a variable
            Console.Write("Is there any other feedback you’d like to provide? Please be specific. ");
            string feedback = Console.ReadLine();

            // Ask for the number of study hours and store it as an integer
            Console.Write("How many hours did you study today? ");
            int studyHours = int.Parse(Console.ReadLine());

            // Print a thank you message and end the program
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
