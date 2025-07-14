using System; // Required for Console operations (Console.WriteLine).

namespace StructAssignment // Define the namespace for your application.
{
    // 1. Create a struct named Number.
    // A 'struct' is a value type in C#, typically used for small data structures
    // that primarily store data values.
    public struct Number
    {
        // Assign a property "Amount" and make it of data type decimal.
        // 'decimal' is used for financial or precise calculations to avoid floating-point inaccuracies.
        public decimal Amount { get; set; }
    }

    class Program // The main class where your program execution starts.
    {
        static void Main(string[] args) // The entry point of the console application.
        {
            Console.WriteLine("--- Asignación de Estructura ---\n");

            // 2. In the Main() method, create an object of data type Number.
            // When you create a struct, it is allocated on the stack (for local variables).
            // No 'new' keyword is strictly required if you assign all fields before use,
            // but it's good practice for clarity and to ensure default initialization.
            Number myNumber = new Number();

            // 3. Assign an amount to it.
            // Assign a decimal value to the 'Amount' property of the 'myNumber' struct object.
            // The 'm' suffix indicates a decimal literal.
            myNumber.Amount = 123.45m;

            // 4. Print this amount to the console.
            Console.WriteLine($"La cantidad asignada a la estructura Number es: {myNumber.Amount}");


            Console.WriteLine("\nAsignación de Estructura completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Keeps the console window open until a key is pressed.
        }
    }
}
