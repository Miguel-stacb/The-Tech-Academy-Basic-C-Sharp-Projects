using System; // Necesario para las operaciones de consola (Console.WriteLine, Console.ReadLine).

namespace CallingMethodsAssignment // Asegúrate de que este sea el mismo namespace que en OperacionesMatematicas.cs
{
    class Program // La clase principal donde se ejecuta tu programa.
    {
        static void Main(string[] args) // El punto de entrada de la aplicación.
        {
            Console.WriteLine("--- Asignación de Métodos de Llamada ---\n");

            // Pregunta al usuario en qué número quiere hacer las operaciones matemáticas.
            Console.WriteLine("Por favor, introduce un número entero para realizar operaciones matemáticas:");
            string entradaUsuario = Console.ReadLine(); // Lee la entrada del usuario como una cadena.

            int numeroUsuario; // Declara una variable para almacenar el número entero del usuario.

            // Intenta convertir la entrada del usuario a un número entero.
            // Utilizamos un bloque try-catch para manejar posibles errores si el usuario no introduce un número válido.
            try
            {
                numeroUsuario = Convert.ToInt32(entradaUsuario); // Convierte la cadena a un entero.
            }
            catch (FormatException) // Captura la excepción si la entrada no es un número válido.
            {
                Console.WriteLine("Error: Entrada no válida. Por favor, introduce solo números enteros.");
                Console.WriteLine("El programa terminará.");
                Console.ReadKey(); // Espera una tecla antes de cerrar.
                return; // Sale del método Main si la entrada es inválida.
            }
            catch (OverflowException) // Captura la excepción si el número es demasiado grande/pequeño.
            {
                Console.WriteLine("Error: El número introducido es demasiado grande o demasiado pequeño para un entero.");
                Console.WriteLine("El programa terminará.");
                Console.ReadKey(); // Espera una tecla antes de cerrar.
                return; // Sale del método Main si la entrada es inválida.
            }

            // Crea una instancia de la clase OperacionesMatematicas.
            // Esto es necesario para poder llamar a los métodos definidos en esa clase.
            OperacionesMatematicas miOperacion = new OperacionesMatematicas();

            // Llama a cada método a su vez, pasando la entrada del usuario al método.
            // Muestra el entero devuelto en la pantalla.

            // Llamada al primer método: SumarDiez
            int resultadoSuma = miOperacion.SumarDiez(numeroUsuario); // Pasa el número del usuario y obtiene el resultado.
            Console.WriteLine($"\nResultado de SumarDiez ({numeroUsuario} + 10): {resultadoSuma}");

            // Llamada al segundo método: MultiplicarPorCinco
            int resultadoMultiplicacion = miOperacion.MultiplicarPorCinco(numeroUsuario); // Pasa el número del usuario.
            Console.WriteLine($"Resultado de MultiplicarPorCinco ({numeroUsuario} * 5): {resultadoMultiplicacion}");

            // Llamada al tercer método: DividirEntreDos
            int resultadoDivision = miOperacion.DividirEntreDos(numeroUsuario); // Pasa el número del usuario.
            Console.WriteLine($"Resultado de DividirEntreDos ({numeroUsuario} / 2): {resultadoDivision}");
            Console.WriteLine("Nota: La división de enteros en C# truncará los decimales (ej. 7 / 2 = 3).");


            Console.WriteLine("\nAsignación de Métodos de Llamada completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta hasta que el usuario presione una tecla.
        }
    }
}