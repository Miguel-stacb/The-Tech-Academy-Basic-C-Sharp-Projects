using System; // Required for Console.WriteLine

namespace OperatorOverloadAssignment // Ensure this namespace matches your Employee.cs
{
    class Program // The main class where the application execution starts.
    {
        static void Main(string[] args) // The entry point of the console application.
        {
            Console.WriteLine("--- Asignación de Sobrecarga de Operadores ---\n");

            // Create the first Employee object instance.
            Employee employee1 = new Employee();
            // Assign values to its properties.
            employee1.Id = 101;
            employee1.FirstName = "Alice";
            employee1.LastName = "Smith";

            // Create the second Employee object instance.
            Employee employee2 = new Employee();
            // Assign values to its properties.
            // For testing equality, we'll give it the same Id as employee1.
            employee2.Id = 101;
            employee2.FirstName = "Bob"; // Different name, but same Id.
            employee2.LastName = "Johnson";

            // Create a third Employee object instance for inequality testing.
            Employee employee3 = new Employee();
            employee3.Id = 102; // Different Id.
            employee3.FirstName = "Charlie";
            employee3.LastName = "Brown";

            Console.WriteLine($"Empleado 1: ID={employee1.Id}, Nombre={employee1.FirstName} {employee1.LastName}");
            Console.WriteLine($"Empleado 2: ID={employee2.Id}, Nombre={employee2.FirstName} {employee2.LastName}");
            Console.WriteLine($"Empleado 3: ID={employee3.Id}, Nombre={employee3.FirstName} {employee3.LastName}\n");

            // Compare the two Employee objects using the overloaded "==" operator.
            // This will compare their 'Id' properties.
            bool areEqual = (employee1 == employee2);
            Console.WriteLine($"¿Son Empleado 1 y Empleado 2 iguales (usando '==' sobrecargado)? {areEqual}"); // Expected: True

            // Compare the two Employee objects using the overloaded "!=" operator.
            bool areNotEqual = (employee1 != employee2);
            Console.WriteLine($"¿Son Empleado 1 y Empleado 2 diferentes (usando '!=' sobrecargado)? {areNotEqual}\n"); // Expected: False

            // Test with different IDs.
            bool areEqualDifferentId = (employee1 == employee3);
            Console.WriteLine($"¿Son Empleado 1 y Empleado 3 iguales (usando '==' sobrecargado)? {areEqualDifferentId}"); // Expected: False

            bool areNotEqualDifferentId = (employee1 != employee3);
            Console.WriteLine($"¿Son Empleado 1 y Empleado 3 diferentes (usando '!=' sobrecargado)? {areNotEqualDifferentId}\n"); // Expected: True


            Console.WriteLine("Asignación de Sobrecarga de Operadores completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Keep the console window open until a key is pressed.
        }
    }
}
