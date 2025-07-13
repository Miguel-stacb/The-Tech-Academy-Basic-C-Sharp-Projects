using System; // Necesario para operaciones de consola (Console.WriteLine).
using System.Collections.Generic; // Necesario para usar List<T> y HashSet<T>.

namespace SixPartAssignment // Tu espacio de nombres.
{
    class Program // Tu clase principal.
    {
        static void Main(string[] args) // El punto de entrada de la aplicación.
        {
            // --- Código de la Parte 1, Parte 2, Parte 3, Parte 4 y Parte 5 (Mantenerlo aquí) ---
            // ... (tu código de las Partes anteriores) ...
            // Console.ReadKey(); // Asegúrate de que solo haya un Console.ReadKey() al final del Main.

            Console.WriteLine("\n--- Tarea de Seis Partes: Parte 6 (Identificación de Duplicados en una Lista) ---\n");

            // 1. Crear una lista de cadenas que tenga al menos dos cadenas idénticas.
            // Esta lista simula una secuencia de elementos donde algunos pueden repetirse.
            List<string> productos = new List<string>()
            {
                "Laptop", "Mouse", "Teclado", "Monitor", "Mouse", "Auriculares", "Laptop", "Webcam"
            };

            // Creamos un HashSet para almacenar los elementos que ya hemos encontrado.
            // Un HashSet es ideal para esto porque almacena solo elementos únicos
            // y permite una comprobación muy rápida de si un elemento ya existe.
            HashSet<string> elementosVistos = new HashSet<string>();

            Console.WriteLine("Evaluando la lista de productos para duplicados:\n");

            // 2. Crear un bucle foreach que evalúe cada elemento de la lista.
            foreach (string productoActual in productos) // Itera sobre cada 'productoActual' en la lista 'productos'.
            {
                // Comprueba si el 'productoActual' ya está presente en nuestro conjunto de 'elementosVistos'.
                // 'Contains' devuelve 'true' si el elemento ya fue añadido al HashSet.
                if (elementosVistos.Contains(productoActual))
                {
                    // Si el elemento ya está en 'elementosVistos', significa que es un duplicado.
                    Console.WriteLine($"{productoActual} - este artículo es un duplicado");
                }
                else
                {
                    // Si el elemento NO está en 'elementosVistos', significa que es la primera vez que lo vemos.
                    Console.WriteLine($"{productoActual} - este artículo es único");
                    // Después de mostrar que es único, lo añadimos al HashSet para recordarlo en futuras iteraciones.
                    elementosVistos.Add(productoActual);
                }
            }

            Console.WriteLine("\nParte 6 completada. Toda la tarea de seis partes ha finalizado."); // Mensaje final de la tarea.
            Console.ReadKey(); // Espera a que el usuario presione una tecla para cerrar la consola.
        }
    }
}