using System; // Required for Console operations (Console.WriteLine, Console.ReadLine).
using System.IO; // Required for file operations (File.WriteAllText, File.ReadAllText).

namespace FileIOAssignment // Define the namespace for your application.
{
    class Program // The main class where your program execution starts.
    {
        static void Main(string[] args) // The entry point of the console application.
        {
            Console.WriteLine("--- Asignación de Entrada y Salida de Archivos ---\n");

            // 1. Ask the user for a number.
            Console.WriteLine("Por favor, introduce un número:");
            string userInput = Console.ReadLine(); // Read the user's input as a string.

            // Define the file path.
            // This will create/access a file named "log.txt" in the same directory
            // where your application's executable (.exe) is located.
            string filePath = "log.txt";

            // 2. Log that number to a text file.
            // File.WriteAllText() writes the specified string to a file.
            // If the file does not exist, it creates it.
            // If the file exists, it overwrites its content.
            try
            {
                File.WriteAllText(filePath, userInput);
                Console.WriteLine($"\nEl número '{userInput}' ha sido guardado en '{filePath}'.");
            }
            catch (Exception ex)
            {
                // Catch any potential errors during file writing (e.g., permissions issues).
                Console.WriteLine($"\nError al escribir en el archivo: {ex.Message}");
                Console.WriteLine("Presiona cualquier tecla para salir.");
                Console.ReadKey();
                return; // Exit the program if there's a file writing error.
            }

            // 3. Print the text file back to the user.
            // File.ReadAllText() reads the entire content of a text file into a single string.
            try
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine($"\nContenido del archivo '{filePath}':");
                Console.WriteLine(fileContent); // Display the content read from the file.
            }
            catch (FileNotFoundException)
            {
                // This catch block handles the specific case where the file might not be found,
                // although it should exist if the previous write operation was successful.
                Console.WriteLine($"\nError: El archivo '{filePath}' no fue encontrado.");
            }
            catch (Exception ex)
            {
                // Catch any other potential errors during file reading.
                Console.WriteLine($"\nError al leer el archivo: {ex.Message}");
            }

            Console.WriteLine("\nAsignación de Entrada y Salida de Archivos completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Keeps the console window open until a key is pressed.
        }
    }
}
