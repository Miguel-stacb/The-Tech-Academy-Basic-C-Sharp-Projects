using System;
using System.Collections.Generic; // Required for List<T>
using System.Linq; // Required for LINQ methods like Where()

namespace LambdaAssignment // Ensure this namespace matches your Employee.cs
{
    class Program // The main class where the application execution starts.
    {
        static void Main(string[] args) // The entry point of the console application.
        {
            Console.WriteLine("--- Asignación Lambda ---\n");

            // Create a list of at least 10 employees.
            // At least two employees must have the first name "Joe".
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Bloggs" },
                new Employee { Id = 4, FirstName = "Alice", LastName = "Johnson" },
                new Employee { Id = 5, FirstName = "Bob", LastName = "Williams" },
                new Employee { Id = 6, FirstName = "Charlie", LastName = "Brown" },
                new Employee { Id = 7, FirstName = "Diana", LastName = "Prince" },
                new Employee { Id = 8, FirstName = "Eve", LastName = "Adams" },
                new Employee { Id = 9, FirstName = "Frank", LastName = "Miller" },
                new Employee { Id = 10, FirstName = "Grace", LastName = "Davis" }
            };

            Console.WriteLine("Lista original de empleados:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Nombre: {emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine("\n--------------------------------------------------\n");


            // Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> joesWithForeach = new List<Employee>(); // Initialize the new list.

            Console.WriteLine("Empleados con el nombre 'Joe' (usando bucle foreach):");
            // Iterate through each employee in the 'employees' list.
            foreach (Employee employee in employees)
            {
                // In the comparison statement, remember to reference the property of the object you are checking.
                // Check if the current employee's FirstName is "Joe".
                if (employee.FirstName == "Joe")
                {
                    // If it is, add that employee to the 'joesWithForeach' list.
                    joesWithForeach.Add(employee);
                }
            }

            // Print the results of the foreach loop.
            foreach (Employee joe in joesWithForeach)
            {
                Console.WriteLine($"ID: {joe.Id}, Nombre: {joe.FirstName} {joe.LastName}");
            }
            Console.WriteLine("\n--------------------------------------------------\n");


            // Perform the same action again, but this time with a lambda expression.
            // Using LINQ's Where() method with a lambda expression.
            // 'e => e.FirstName == "Joe"' is the lambda expression.
            // 'e' is the input parameter (representing each Employee object in the list).
            // 'e.FirstName == "Joe"' is the condition.
            // .ToList() converts the filtered IEnumerable<Employee> back into a List<Employee>.
            List<Employee> joesWithLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            Console.WriteLine("Empleados con el nombre 'Joe' (usando expresión lambda):");
            // Print the results of the lambda expression for "Joe".
            foreach (Employee joe in joesWithLambda)
            {
                Console.WriteLine($"ID: {joe.Id}, Nombre: {joe.FirstName} {joe.LastName}");
            }
            Console.WriteLine("\n--------------------------------------------------\n");


            // With a lambda expression, make a list of all employees with an Id number greater than 5.
            // Another example of using Where() with a lambda expression for a different condition.
            // 'e => e.Id > 5' filters employees whose Id is strictly greater than 5.
            List<Employee> employeesWithIdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

            Console.WriteLine("Empleados con ID mayor que 5 (usando expresión lambda):");
            // Print the results of the lambda expression for Id > 5.
            foreach (Employee emp in employeesWithIdGreaterThan5)
            {
                Console.WriteLine($"ID: {emp.Id}, Nombre: {emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine("\n--------------------------------------------------\n");


            Console.WriteLine("Asignación Lambda completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Keep the console window open until a key is pressed.
        }
    }
}