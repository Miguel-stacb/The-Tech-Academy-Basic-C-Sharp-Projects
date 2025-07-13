using System; // Necesario para operaciones de consola (Console.WriteLine, Console.ReadLine).
using System.Collections.Generic; // Necesario para usar List<T>.

namespace IntegerAndStringAssignment // Define el espacio de nombres para tu aplicación.
{
    class Program // La clase principal donde se ejecuta tu programa.
    {
        static void Main(string[] args) // El punto de entrada de la aplicación.
        {
            Console.WriteLine("--- Asignación de Enteros y Cadenas (Manejo de Excepciones) ---\n");

            // 1. Crear una lista de números enteros.
            // Una lista dinámica de números para trabajar.
            List<int> numerosEnteros = new List<int>() { 10, 20, 30, 45, 55, 60 };

            Console.WriteLine("Esta es la lista de números enteros: " + string.Join(", ", numerosEnteros) + "\n");

            // Pida al usuario un número para dividir cada número de la lista.
            Console.WriteLine("Por favor, introduce un número entero para dividir cada número de la lista:");
            string entradaUsuario = Console.ReadLine(); // Leer la entrada del usuario como una cadena.

            // Ahora colocamos el bucle en un bloque try/catch.
            // El bloque 'try' contiene el código que podría causar una excepción.
            try
            {
                // Convertir la entrada del usuario a un entero.
                // Si el usuario ingresa una cadena no numérica, Int32.Parse lanzará una FormatException.
                int divisor = Int32.Parse(entradaUsuario); // Intenta convertir la cadena a un entero.

                // Bucle que toma cada número entero de la lista, lo divide y muestra el resultado.
                // Se utiliza un bucle 'foreach' para iterar sobre cada elemento de la lista.
                foreach (int numero in numerosEnteros)
                {
                    // Realizar la división.
                    // Si 'divisor' es 0, esto lanzará una DivideByZeroException.
                    int resultado = numero / divisor;
                    // Mostrar el resultado de la división en la pantalla.
                    Console.WriteLine($"{numero} dividido por {divisor} es igual a: {resultado}");
                }
            }
            // Bloque 'catch' para manejar excepciones de formato (cuando la entrada no es un número).
            catch (FormatException ex)
            {
                // Mostrar un mensaje de error específico para problemas de formato.
                Console.WriteLine("Error de formato: Por favor, introduce solo números enteros válidos.");
                // Mostrar el mensaje de error original de la excepción para depuración.
                Console.WriteLine("Mensaje de error original: " + ex.Message);
            }
            // Bloque 'catch' para manejar excepciones de división por cero.
            catch (DivideByZeroException ex)
            {
                // Mostrar un mensaje de error específico para la división por cero.
                Console.WriteLine("Error: No puedes dividir por cero. Por favor, introduce un número diferente de cero.");
                // Mostrar el mensaje de error original de la excepción para depuración.
                Console.WriteLine("Mensaje de error original: " + ex.Message);
            }
            // Bloque 'catch' genérico para cualquier otra excepción inesperada.
            catch (Exception ex)
            {
                // Mostrar un mensaje de error genérico para otras excepciones.
                Console.WriteLine("Ha ocurrido un error inesperado.");
                // Mostrar el mensaje de error original de la excepción.
                Console.WriteLine("Mensaje de error original: " + ex.Message);
            }
            // Finalmente, y fuera del bloque try/catch, hacer que el programa imprima un mensaje.
            // Este código se ejecutará siempre, sin importar si una excepción fue capturada o no.
            finally
            {
                // Este mensaje se imprimirá siempre después de que el bloque try/catch haya terminado.
                Console.WriteLine("\nEl programa ha salido del bloque try/catch y ha continuado con la ejecución.");
            }

            Console.WriteLine("Presiona cualquier tecla para salir del programa.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta hasta que el usuario presione una tecla.
        }
    }
}
