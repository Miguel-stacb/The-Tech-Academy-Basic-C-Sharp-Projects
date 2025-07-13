using System; // Required for Console input/output.

namespace MethodOverloadAssignment // Ensure this namespace matches your CalculadoraSobrecargada.cs
{
    class Program // The main class where the application execution starts.
    {
        static void Main(string[] args) // The entry point of the console application.
        {
            Console.WriteLine("--- Asignación de Sobrecarga de Métodos ---\n");

            // Create an instance of the CalculadoraSobrecargada class.
            // This object will be used to call the methods defined in that class.
            CalculadoraSobrecargada calculadora = new CalculadoraSobrecargada();

            // ====================================================================
            // Call the first method: Operacion(int)
            // ====================================================================

            Console.WriteLine("--- Llamada al método con un número entero ---");
            Console.WriteLine("Introduce un número entero para la primera operación:");
            string inputInt = Console.ReadLine(); // Read user input as a string.
            int numeroEnteroUsuario; // Variable to store the parsed integer.

            // Attempt to parse the user's string input into an integer.
            // Use TryParse for safer conversion, avoiding exceptions if input is not a number.
            if (int.TryParse(inputInt, out numeroEnteroUsuario))
            {
                // Call the Operacion method that takes an integer parameter.
                int resultadoEntero = calculadora.Operacion(numeroEnteroUsuario);
                // Display the returned integer result.
                Console.WriteLine($"Resultado de la operación con entero ({numeroEnteroUsuario} + 20): {resultadoEntero}\n");
            }
            else
            {
                Console.WriteLine("Entrada no válida para la operación con entero. Por favor, introduce un número entero.\n");
            }

            // ====================================================================
            // Call the second method: Operacion(decimal)
            // ====================================================================

            Console.WriteLine("--- Llamada al método con un número decimal ---");
            Console.WriteLine("Introduce un número decimal para la segunda operación (usa ',' o '.' según tu configuración regional):");
            string inputDecimal = Console.ReadLine(); // Read user input as a string.
            decimal numeroDecimalUsuario; // Variable to store the parsed decimal.

            // Attempt to parse the user's string input into a decimal.
            if (decimal.TryParse(inputDecimal, out numeroDecimalUsuario))
            {
                // Call the Operacion method that takes a decimal parameter.
                int resultadoDecimal = calculadora.Operacion(numeroDecimalUsuario);
                // Display the returned integer result.
                Console.WriteLine($"Resultado de la operación con decimal ({numeroDecimalUsuario} - 5, luego convertido a entero): {resultadoDecimal}\n");
            }
            else
            {
                Console.WriteLine("Entrada no válida para la operación con decimal. Por favor, introduce un número decimal.\n");
            }

            // ====================================================================
            // Call the third method: Operacion(string)
            // ====================================================================

            Console.WriteLine("--- Llamada al método con una cadena ---");
            Console.WriteLine("Introduce una cadena que represente un número entero para la tercera operación:");
            string inputString = Console.ReadLine(); // Read user input as a string.

            // Call the Operacion method that takes a string parameter.
            // The method itself handles the conversion and potential errors.
            int resultadoCadena = calculadora.Operacion(inputString);
            // Display the returned integer result.
            // Note: If the string conversion failed inside the method, it returns 0.
            if (resultadoCadena != 0 || int.TryParse(inputString, out _)) // Check if conversion was likely successful or if input was "0"
            {
                Console.WriteLine($"Resultado de la operación con cadena ('{inputString}' * 3, después de convertir a entero): {resultadoCadena}\n");
            }
            // If resultadoCadena is 0 and inputString was not "0", an error message was already printed by the method.


            Console.WriteLine("Asignación de Sobrecarga de Métodos completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Keep the console window open until a key is pressed.
        }
    }
}
