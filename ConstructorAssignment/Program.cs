using System; // Required for Console operations.

namespace ConstructorAssignment // Ensure this namespace matches your Product.cs
{
    class Program // The main class where your program execution starts.
    {
        static void Main(string[] args) // The entry point of the console application.
        {
            Console.WriteLine("--- Asignación de Constructor (const, var, Cadena de Constructores) ---\n");

            // 1. Create a 'const' variable.
            // 'const' means the value is a compile-time constant and cannot be changed after initialization.
            // It must be initialized at the time of declaration.
            const string CompanyName = "TechSolutions Inc.";
            Console.WriteLine($"Nombre de la compañía (const): {CompanyName}");

            // 2. Create a variable using the "var" keyword.
            // 'var' is used for implicitly typed local variables.
            // The compiler infers the type from the initialization expression.
            // Once inferred, the type is fixed for the variable's lifetime.
            var productCount = 100; // The compiler infers 'productCount' to be of type 'int'.
            Console.WriteLine($"Número de productos (var): {productCount}");
            // productCount = "hello"; // This would cause a compile-time error because its type is int.


            // 3. Chain two constructors together.
            // Create an instance of the Product class using the constructor that takes all three parameters.
            // This constructor then internally calls the constructor that takes 'name' and 'price'.
            Product newProduct = new Product("Smartphone X", 999.99m, 101);

            Console.WriteLine("\nDetalles del Producto (creado con cadena de constructores):");
            Console.WriteLine($"ID del Producto: {newProduct.ProductId}");
            Console.WriteLine($"Nombre del Producto: {newProduct.Name}");
            Console.WriteLine($"Precio del Producto: {newProduct.Price:C}"); // :C formats as currency.

            // Example of using the constructor that only takes name and price (ProductId will be 0 by default)
            Product anotherProduct = new Product("Smartwatch Y", 249.50m);
            Console.WriteLine("\nDetalles de Otro Producto (creado con constructor de dos parámetros):");
            Console.WriteLine($"ID del Producto: {anotherProduct.ProductId}"); // Will be 0
            Console.WriteLine($"Nombre del Producto: {anotherProduct.Name}");
            Console.WriteLine($"Precio del Producto: {anotherProduct.Price:C}");


            Console.WriteLine("\nAsignación de Constructor completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Keeps the console window open until a key is pressed.
        }
    }
}
