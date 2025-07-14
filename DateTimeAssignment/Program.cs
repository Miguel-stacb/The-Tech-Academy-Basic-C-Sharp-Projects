using System; // Required for DateTime and Console operations.

namespace DateTimeAssignment // Define the namespace for your application.
{
    class Program // The main class where your program execution starts.
    {
        static void Main(string[] args) // The entry point of the console application.
        {
            Console.WriteLine("--- Asignación de Fecha/Hora ---\n");

            // 1. Imprime la fecha y hora actuales en la consola.
            // DateTime.Now gets the current date and time of the system.
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine($"Fecha y hora actuales: {currentDateTime}");

            // 2. Pide al usuario un número.
            Console.WriteLine("\nPor favor, introduce un número entero de horas para añadir a la hora actual:");
            string userInput = Console.ReadLine(); // Read the user's input as a string.

            int hoursToAdd; // Variable to store the number of hours entered by the user.

            // Use a try-catch block to handle potential errors if the user's input is not a valid integer.
            try
            {
                // Convert the user's string input to an integer.
                hoursToAdd = Convert.ToInt32(userInput);
            }
            catch (FormatException) // Catch the exception if the input is not in a correct format.
            {
                Console.WriteLine("\nError: Entrada no válida. Por favor, introduce un número entero.");
                Console.WriteLine("Presiona cualquier tecla para salir.");
                Console.ReadKey();
                return; // Exit the program if there's an input error.
            }
            catch (OverflowException) // Catch the exception if the number is too large or too small.
            {
                Console.WriteLine("\nError: El número introducido es demasiado grande o pequeño.");
                Console.WriteLine("Presiona cualquier tecla para salir.");
                Console.ReadKey();
                return; // Exit the program if there's an input error.
            }

            // 3. Imprime en la consola la hora exacta en X horas.
            // currentDateTime.AddHours(hoursToAdd) calculates a new DateTime object
            // by adding the specified number of hours to the current date and time.
            DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);
            Console.WriteLine($"\nLa hora exacta en {hoursToAdd} horas será: {futureDateTime}");

            Console.WriteLine("\nAsignación de Fecha/Hora completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Keeps the console window open until a key is pressed.
        }
    }
}
