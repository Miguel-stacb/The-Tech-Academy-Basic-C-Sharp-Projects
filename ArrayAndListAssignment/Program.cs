using System; // Necesario para operaciones de entrada/salida de la Consola (como Console.WriteLine).
using System.Collections.Generic; // Necesario para usar la clase List<T> (colecciones dinámicas).

namespace ArrayAndListAssignment // Define un 'namespace' para organizar tu código y evitar conflictos de nombres.
{
    class Program // La clase 'Program' contiene el punto de entrada principal de tu aplicación.
    {
        static void Main(string[] args) // El método 'Main' es donde tu programa comienza a ejecutarse.
        {
            Console.WriteLine("--- Asignación de Arrays y Listas en C# ---"); // Título principal de la aplicación.
            Console.WriteLine("Este programa demuestra el uso de arrays y listas, y el manejo de índices.\n"); // Breve descripción.

            // ====================================================================
            // 1. Array de Cadenas (Strings)
            // ====================================================================

            Console.WriteLine("--- Array de Cadenas (Nombres de Mascotas) ---"); // Encabezado de la sección.

            // Declara e inicializa un array unidimensional de cadenas de texto (strings).
            // Un array tiene un tamaño fijo, en este caso, 5 elementos.
            string[] petNames = { "Buddy", "Mittens", "Sparky", "Daisy", "Rocky" };

            Console.WriteLine("Por favor, selecciona un índice para ver el nombre de una mascota (0 a 4):"); // Pide al usuario que elija un índice.
            string stringInput = Console.ReadLine(); // Lee lo que el usuario escribe como una cadena.

            // Intenta convertir la entrada del usuario (que es una cadena) a un número entero.
            // 'int.TryParse' es seguro: devuelve 'true' si la conversión es exitosa y 'false' si no lo es.
            // La variable 'stringIndex' guardará el número convertido si la operación es exitosa.
            if (int.TryParse(stringInput, out int stringIndex))
            {
                // Verifica si el índice que el usuario ingresó está dentro del rango válido del array.
                // Los índices de un array siempre comienzan en 0 y van hasta 'Length - 1'.
                if (stringIndex >= 0 && stringIndex < petNames.Length)
                {
                    // Si el índice es válido, accede al elemento del array en esa posición y lo muestra.
                    Console.WriteLine($"El nombre de la mascota en el índice {stringIndex} es: {petNames[stringIndex]}\n");
                }
                else
                {
                    // Si el índice está fuera del rango válido, muestra un mensaje de error.
                    Console.WriteLine("Error: Ese índice no existe en el array de nombres de mascotas. Por favor, selecciona un número entre 0 y 4.\n");
                }
            }
            else
            {
                // Si la entrada del usuario no fue un número válido (ej. escribió "hola"), muestra un error.
                Console.WriteLine("Error: Entrada no válida. Por favor, introduce un número entero.\n");
            }

            // ====================================================================
            // 2. Array de Enteros (Números)
            // ====================================================================

            Console.WriteLine("--- Array de Enteros (Edades de Animales) ---"); // Encabezado de la siguiente sección.

            // Declara e inicializa un array unidimensional de números enteros (int).
            // Este array también tiene un tamaño fijo de 5 elementos.
            int[] animalAges = { 2, 5, 8, 1, 10 };

            Console.WriteLine("Por favor, selecciona un índice para ver la edad de un animal (0 a 4):"); // Pide al usuario un índice.
            string intInput = Console.ReadLine(); // Lee la entrada del usuario.

            // Intenta convertir la entrada del usuario a un entero.
            if (int.TryParse(intInput, out int intIndex))
            {
                // Verifica si el índice está dentro del rango válido para este array de enteros.
                if (intIndex >= 0 && intIndex < animalAges.Length)
                {
                    // Si el índice es válido, muestra el número entero en esa posición.
                    Console.WriteLine($"La edad del animal en el índice {intIndex} es: {animalAges[intIndex]}\n");
                }
                else
                {
                    // Mensaje de error si el índice está fuera de rango.
                    Console.WriteLine("Error: Ese índice no existe en el array de edades. Por favor, selecciona un número entre 0 y 4.\n");
                }
            }
            else
            {
                // Mensaje de error si la entrada no es un número.
                Console.WriteLine("Error: Entrada no válida. Por favor, introduce un número entero.\n");
            }

            // ====================================================================
            // 3. Lista de Cadenas (Colores)
            // ====================================================================

            Console.WriteLine("--- Lista de Cadenas (Colores Favoritos) ---"); // Encabezado de la última sección.

            // Declara e inicializa una List<string>.
            // A diferencia de los arrays, las listas pueden cambiar de tamaño dinámicamente.
            List<string> favoriteColors = new List<string>() { "Azul", "Verde", "Rojo", "Amarillo", "Púrpura" };
            // Puedes agregar más elementos a una lista en cualquier momento.
            favoriteColors.Add("Naranja"); // Agrega un nuevo elemento al final de la lista.

            // Muestra al usuario cuántos elementos hay en la lista y el rango de índices válidos.
            Console.WriteLine($"La lista de colores tiene {favoriteColors.Count} elementos (0 a {favoriteColors.Count - 1}).");
            Console.WriteLine("Por favor, selecciona un índice para ver un color:"); // Pide al usuario un índice.
            string listInput = Console.ReadLine(); // Lee la entrada del usuario.

            // Intenta convertir la entrada del usuario a un entero.
            if (int.TryParse(listInput, out int listIndex))
            {
                // Verifica si el índice está dentro del rango válido de la lista.
                // Las listas usan la propiedad 'Count' para obtener su número de elementos.
                if (listIndex >= 0 && listIndex < favoriteColors.Count)
                {
                    // Si el índice es válido, muestra el contenido de la lista en esa posición.
                    Console.WriteLine($"El color en el índice {listIndex} es: {favoriteColors[listIndex]}\n");
                }
                else
                {
                    // Mensaje de error si el índice está fuera de rango para la lista.
                    Console.WriteLine($"Error: Ese índice no existe en la lista de colores. Por favor, selecciona un número entre 0 y {favoriteColors.Count - 1}.\n");
                }
            }
            else
            {
                // Mensaje de error si la entrada no es un número.
                Console.WriteLine("Error: Entrada no válida. Por favor, introduce un número entero.\n");
            }

            Console.WriteLine("Programa finalizado. Presiona cualquier tecla para salir."); // Mensaje final.
            Console.ReadKey(); // Mantiene la ventana de la consola abierta hasta que el usuario presiona una tecla.
        }
    }
}
