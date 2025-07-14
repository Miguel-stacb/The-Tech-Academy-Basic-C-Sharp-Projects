using System;
using System.Collections.Generic; // Required for List<T>

namespace GenericsAssignment // Ensure this namespace matches your Employee.cs
{
    class Program // The main class where the application execution starts.
    {
        static void Main(string[] args) // The entry point of the console application.
        {
            Console.WriteLine("--- Asignación de Parámetros Genéricos ---\n");

            // 1. Create an instance of an Employee object with the generic type "string".
            // This means 'T' in Employee<T> will be 'string' for this specific object.
            Employee<string> employeeString = new Employee<string>();
            employeeString.Id = 1;
            employeeString.FirstName = "Alice";
            employeeString.LastName = "Smith";

            // Assign a list of strings as the property value of 'Things'.
            employeeString.Things = new List<string>
            {
                "Laptop",
                "Mouse",
                "Keyboard",
                "Monitor"
            };

            // 2. Create an instance of an Employee object with the generic type "int".
            // This means 'T' in Employee<T> will be 'int' for this specific object.
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Id = 2;
            employeeInt.FirstName = "Bob";
            employeeInt.LastName = "Johnson";

            // Assign a list of integers as the property value of 'Things'.
            employeeInt.Things = new List<int>
            {
                10,
                20,
                30,
                40,
                50
            };

            // 3. Create a loop that prints all the things in the console for the string employee.
            Console.WriteLine($"Cosas de {employeeString.FirstName} {employeeString.LastName} (ID: {employeeString.Id}):");
            // Iterate through each item in the 'Things' list of the 'employeeString' object.
            foreach (string thing in employeeString.Things)
            {
                Console.WriteLine($"- {thing}");
            }
            Console.WriteLine("\n--------------------------------------------------\n");

            // 4. Create a loop that prints all the things in the console for the int employee.
            Console.WriteLine($"Cosas de {employeeInt.FirstName} {employeeInt.Id} (ID: {employeeInt.Id}):");
            // Iterate through each item in the 'Things' list of the 'employeeInt' object.
            foreach (int thing in employeeInt.Things)
            {
                Console.WriteLine($"- {thing}");
            }
            Console.WriteLine("\n--------------------------------------------------\n");


            Console.WriteLine("Asignación de Parámetros Genéricos completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Keep the console window open until a key is pressed.
        }
    }
}