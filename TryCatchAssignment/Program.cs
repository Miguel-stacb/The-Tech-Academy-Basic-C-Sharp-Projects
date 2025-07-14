using System; // Required for Console operations and DateTime.

namespace TryCatchAssignment // Define the namespace for your application.
{
    class Program // The main class where your program execution starts.
    {
        static void Main(string[] args) // The entry point of the console application.
        {
            Console.WriteLine("--- Asignación de Prueba/Captura (Try/Catch) ---\n");

            // Start a try block. Code that might throw an exception is placed here.
            try
            {
                // 1. Ask the user for their age.
                Console.WriteLine("Por favor, introduce tu edad:");
                string userInput = Console.ReadLine(); // Read the user's input as a string.

                // Convert the user's input string to an integer.
                // This line can throw a FormatException if the input is not a valid number.
                // It can also throw an OverflowException if the number is too large or too small for an int.
                int age = Convert.ToInt32(userInput);

                // 4. Show appropriate error messages if the user enters zero or negative numbers.
                // Check if the age is zero or negative. This is a custom validation.
                if (age <= 0)
                {
                    // If the age is invalid, throw an ArgumentOutOfRangeException.
                    // This allows us to catch it specifically in a subsequent catch block.
                    throw new ArgumentOutOfRangeException("age", "La edad no puede ser cero o un número negativo.");
                }

                // Calculate the birth year.
                // DateTime.Now.Year gets the current year.
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                // 2. Display the year the user was born.
                Console.WriteLine($"\nNaciste aproximadamente en el año: {birthYear}.");
            }
            // Catch block for ArgumentOutOfRangeException.
            // This specifically handles the custom exception we threw for zero or negative age.
            catch (ArgumentOutOfRangeException ex)
            {
                // Display the specific error message for invalid age.
                Console.WriteLine($"\nError: {ex.ParamName}. {ex.Message}");
            }
            // Catch block for FormatException.
            // This handles cases where the user input is not a valid integer (e.g., "abc", "12.5").
            catch (FormatException)
            {
                Console.WriteLine("\nError: Entrada no válida. Por favor, introduce un número entero para tu edad.");
            }
            // Catch block for OverflowException.
            // This handles cases where the user input is a number too large or too small for an Int32.
            catch (OverflowException)
            {
                Console.WriteLine("\nError: La edad introducida es demasiado grande o pequeña para ser procesada.");
            }
            // 5. Display a general message if an exception is due to anything else.
            // This is a general catch-all block for any other unexpected exceptions.
            catch (Exception ex)
            {
                // Display a generic error message along with the exception's message for debugging purposes.
                Console.WriteLine($"\nHa ocurrido un error inesperado: {ex.Message}");
            }
            finally
            {
                // The finally block always executes, regardless of whether an exception occurred or not.
                // It's useful for cleanup code (e.g., closing files), but here it just keeps the console open.
                Console.WriteLine("\nAsignación de Prueba/Captura completada. Presiona cualquier tecla para salir.");
                Console.ReadKey(); // Keeps the console window open until a key is pressed.
            }
        }
    }
}