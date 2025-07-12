using System; // Importa el namespace System para usar funcionalidades básicas como Console.WriteLine y Console.ReadLine.

namespace LoopAssignmentApp // Define un namespace para organizar tu aplicación.
{
    class Program // Define la clase principal donde se ejecutará el programa.
    {
        static void Main(string[] args) // El método Main es el punto de entrada de la aplicación.
        {
            Console.WriteLine("--- Asignación de Bucles: while y do-while ---");
            Console.WriteLine("Este programa demostrará el uso de bucles 'while' y 'do-while'.\n");

            // ====================================================================
            // Demostración del Bucle 'while'
            // ====================================================================

            Console.WriteLine("--- Demostración del Bucle 'while' ---");
            int contadorWhile = 0; // Declara e inicializa una variable entera para usar como contador.
            bool condicionWhile = true; // Declara e inicializa una variable booleana para la condición del bucle.

            // El bucle 'while' se ejecuta mientras 'condicionWhile' sea verdadera.
            // La condición se verifica ANTES de cada iteración.
            while (condicionWhile) // Condición booleana: el bucle continúa mientras condicionWhile sea 'true'.
            {
                Console.WriteLine($"Dentro del bucle 'while'. Contador: {contadorWhile}"); // Muestra el estado actual del contador.
                contadorWhile++; // Incrementa el contador en 1.

                // Comprobación de la condición para eventualmente salir del bucle.
                if (contadorWhile >= 3) // Si el contador alcanza o supera 3, cambiamos la condición.
                {
                    condicionWhile = false; // Cambia la variable booleana a 'false' para que el bucle termine en la próxima verificación.
                    Console.WriteLine("Condición del bucle 'while' cambiada a false. El bucle terminará pronto.");
                }
            }
            Console.WriteLine("Fuera del bucle 'while'. El bucle ha terminado.\n"); // Mensaje después de que el bucle 'while' ha terminado.

            // ====================================================================
            // Demostración del Bucle 'do-while'
            // ====================================================================

            Console.WriteLine("--- Demostración del Bucle 'do-while' ---");
            int contadorDoWhile = 0; // Declara e inicializa una variable entera para usar como contador.
            bool condicionDoWhile = false; // Declara e inicializa una variable booleana para la condición del bucle.
                                           // Nota: La condición es 'false' inicialmente, pero el bucle se ejecutará al menos una vez.

            // El bucle 'do-while' garantiza que el bloque de código se ejecute AL MENOS UNA VEZ,
            // ya que la condición se verifica DESPUÉS de la primera iteración.
            do // El bloque 'do' se ejecuta primero.
            {
                Console.WriteLine($"Dentro del bucle 'do-while'. Contador: {contadorDoWhile}"); // Muestra el estado actual del contador.
                contadorDoWhile++; // Incrementa el contador en 1.

                // Comprobación de la condición para eventualmente salir del bucle.
                // Aquí, la condición se hará verdadera por un momento y luego la haremos falsa para un ejemplo de ejecución mínima.
                if (contadorDoWhile < 1) // Esta condición es solo para asegurar que se ejecute una vez si la condición inicial fuera false.
                {
                    condicionDoWhile = true; // Por ejemplo, si quisiéramos que se repita.
                }
                else // Una vez que contadorDoWhile es 1 o más, hacemos la condición falsa.
                {
                    condicionDoWhile = false; // Cambia la variable booleana a 'false' para que el bucle termine.
                    Console.WriteLine("Condición del bucle 'do-while' cambiada a false. El bucle terminará.");
                }

            } while (condicionDoWhile); // Condición booleana: el bucle continúa mientras condicionDoWhile sea 'true'.
                                        // Esta condición se verifica DESPUÉS de cada iteración.
            Console.WriteLine("Fuera del bucle 'do-while'. El bucle ha terminado.\n"); // Mensaje después de que el bucle 'do-while' ha terminado.

            // ====================================================================
            // Ejemplo Adicional: do-while con interacción de usuario
            // ====================================================================

            Console.WriteLine("--- Ejemplo Interactivo con do-while ---");
            string respuestaUsuario; // Declara una variable para almacenar la respuesta del usuario.
            bool seguirPreguntando; // Declara una variable booleana para controlar el bucle.

            do // El bucle se ejecutará al menos una vez para hacer la primera pregunta.
            {
                Console.WriteLine("¿Quieres seguir jugando? (sí/no)"); // Pregunta al usuario.
                respuestaUsuario = Console.ReadLine().ToLower(); // Lee la respuesta y la convierte a minúsculas.

                // La condición booleana se basa en la respuesta del usuario.
                seguirPreguntando = (respuestaUsuario == "si" || respuestaUsuario == "sí"); // Será 'true' si el usuario responde "si" o "sí".

                if (seguirPreguntando) // Si el usuario quiere seguir, lo confirmamos.
                {
                    Console.WriteLine("¡Genial! Sigamos.");
                }
                else // Si el usuario no quiere seguir.
                {
                    Console.WriteLine("De acuerdo, terminamos.");
                }

            } while (seguirPreguntando); // El bucle continúa mientras 'seguirPreguntando' sea 'true'.

            Console.WriteLine("\nPrograma finalizado. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta hasta que el usuario presione una tecla.
        }
    }
}