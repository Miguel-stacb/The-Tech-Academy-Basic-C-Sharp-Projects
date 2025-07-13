using System; // Necesario para las operaciones de consola (Console.WriteLine, Console.ReadLine).

namespace OptionalParametersAssignment // Asegúrate de que este sea el mismo namespace que en CalculadoraOpcional.cs
{
    class Program // La clase principal donde se ejecuta tu programa.
    {
        static void Main(string[] args) // El punto de entrada de la aplicación.
        {
            Console.WriteLine("--- Asignación de Métodos con Parámetros Opcionales ---\n");

            // Crea una instancia de la clase CalculadoraOpcional.
            // Esto es necesario para poder llamar a los métodos definidos en esa clase.
            CalculadoraOpcional calculadora = new CalculadoraOpcional();

            // Pide al usuario que introduzca el primer número.
            Console.WriteLine("Por favor, introduce el primer número entero:");
            string input1 = Console.ReadLine(); // Lee la entrada del usuario como una cadena.

            int numero1; // Variable para almacenar el primer número.

            // Intenta convertir la primera entrada del usuario a un número entero.
            // Se usa un bloque try-catch para manejar errores si la entrada no es un número válido.
            try
            {
                numero1 = Convert.ToInt32(input1); // Convierte la cadena a un entero.
            }
            catch (FormatException) // Captura la excepción si la entrada no es un número.
            {
                Console.WriteLine("Error: El primer valor no es un número entero válido. El programa terminará.");
                Console.ReadKey();
                return; // Sale del método Main.
            }
            catch (OverflowException) // Captura la excepción si el número es demasiado grande/pequeño.
            {
                Console.WriteLine("Error: El primer número es demasiado grande o pequeño. El programa terminará.");
                Console.ReadKey();
                return; // Sale del método Main.
            }

            // Pide al usuario el segundo número, indicando que es opcional.
            Console.WriteLine("Introduce un segundo número entero (opcional, puedes dejarlo en blanco y presionar Enter):");
            string input2 = Console.ReadLine(); // Lee la segunda entrada del usuario.

            // ====================================================================
            // Llamar al método de la clase, pasando uno o dos números.
            // ====================================================================

            // Si el usuario no introdujo nada para el segundo número, llamamos al método con un solo parámetro.
            if (string.IsNullOrWhiteSpace(input2)) // Comprueba si la cadena está vacía o solo contiene espacios en blanco.
            {
                Console.WriteLine("\nLlamando al método con un solo parámetro (el segundo es opcional):");
                // Llama al método pasando solo el primer número. El segundo parámetro usará su valor predeterminado (0).
                int resultado = calculadora.RealizarOperacion(numero1);
                Console.WriteLine($"Resultado de {numero1} + 0 (opcional): {resultado}");
            }
            else // Si el usuario introdujo algo para el segundo número, intentamos usarlo.
            {
                int numero2; // Variable para almacenar el segundo número.
                try
                {
                    numero2 = Convert.ToInt32(input2); // Convierte la segunda cadena a un entero.
                    Console.WriteLine("\nLlamando al método con dos parámetros:");
                    // Llama al método pasando ambos números.
                    int resultado = calculadora.RealizarOperacion(numero1, numero2);
                    Console.WriteLine($"Resultado de {numero1} + {numero2}: {resultado}");
                }
                catch (FormatException) // Captura la excepción si la segunda entrada no es un número.
                {
                    Console.WriteLine("Error: El segundo valor no es un número entero válido. Se ignorará y se usará solo el primer número.");
                    // En este caso de error, podemos optar por llamar al método con solo el primer número.
                    int resultado = calculadora.RealizarOperacion(numero1);
                    Console.WriteLine($"Resultado de {numero1} + 0 (opcional por error de entrada): {resultado}");
                }
                catch (OverflowException) // Captura la excepción si el segundo número es demasiado grande/pequeño.
                {
                    Console.WriteLine("Error: El segundo número es demasiado grande o pequeño. Se ignorará y se usará solo el primer número.");
                    int resultado = calculadora.RealizarOperacion(numero1);
                    Console.WriteLine($"Resultado de {numero1} + 0 (opcional por error de entrada): {resultado}");
                }
            }

            Console.WriteLine("\nAsignación de Métodos con Parámetros Opcionales completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta hasta que el usuario presione una tecla.
        }
    }
}
