using System; // Required for operations like Convert.ToInt32, if used.

namespace MethodOverloadAssignment // Ensure this namespace matches your Program.cs
{
    // This class demonstrates method overloading by having multiple methods with the same name.
    public class CalculadoraSobrecargada
    {
        // Method 1: Takes an integer parameter.
        // It performs a mathematical operation (e.g., adds 20) and returns an integer.
        public int Operacion(int numeroEntero)
        {
            // Perform a mathematical operation: add 20 to the integer.
            int resultado = numeroEntero + 20;
            // Return the integer result.
            return resultado;
        }

        // Method 2: Overload of the 'Operacion' method. Takes a decimal parameter.
        // It performs a different mathematical operation (e.g., subtracts 5)
        // and returns the answer as an integer (after casting/conversion).
        public int Operacion(decimal numeroDecimal)
        {
            // Perform a different mathematical operation: subtract 5 from the decimal.
            // Convert the decimal result to an integer. This will truncate any decimal part.
            int resultado = Convert.ToInt32(numeroDecimal - 5);
            // Return the integer result.
            return resultado;
        }

        // Method 3: Overload of the 'Operacion' method. Takes a string parameter.
        // It attempts to convert the string to an integer, performs a different
        // mathematical operation (e.g., multiplies by 3), and returns the integer result.
        // Includes basic error handling for string conversion.
        public int Operacion(string numeroString)
        {
            int numeroConvertido; // Variable to store the converted integer.

            // Attempt to convert the string to an integer.
            // int.TryParse is safer than Convert.ToInt32 as it doesn't throw an exception on failure.
            if (int.TryParse(numeroString, out numeroConvertido))
            {
                // If conversion is successful, perform a different mathematical operation: multiply by 3.
                int resultado = numeroConvertido * 3;
                // Return the integer result.
                return resultado;
            }
            else
            {
                // If conversion fails (e.g., the string is not a valid number),
                // print an error message and return a default value (e.g., 0 or -1)
                // or throw a new exception, depending on desired error handling.
                Console.WriteLine($"Error: La cadena '{numeroString}' no pudo ser convertida a un número entero válido.");
                return 0; // Return 0 as a default/error value.
            }
        }
    }
}
