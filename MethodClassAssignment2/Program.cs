using System; // Necesario para operaciones de consola (Console.WriteLine, Console.ReadLine).
using System.Collections.Generic; // No estrictamente necesario para esta tarea, pero a menudo útil.

namespace MethodClassAssignment2 // Asegúrate de que este namespace coincida con tus otras clases
{
    class Program // La clase principal donde se ejecuta tu programa.
    {
        static void Main(string[] args) // El punto de entrada de la aplicación.
        {
            Console.WriteLine("--- Asignación de Clase de Método (Varias Funcionalidades) ---\n");

            // ====================================================================
            // Demostración del método 'void' y la división por 2.
            // ====================================================================
            Console.WriteLine("--- Parte 1: Método Void (Dividir por 2) ---");
            // Crea una instancia de la clase 'Operaciones'.
            // Necesitas una instancia para llamar a métodos no estáticos.
            Operaciones operaciones = new Operaciones();

            Console.WriteLine("Por favor, introduce un número entero para dividirlo por 2:");
            string inputVoid = Console.ReadLine(); // Lee la entrada del usuario.
            int numeroVoid; // Variable para almacenar el número.

            // Usa try-catch para manejar la conversión de la entrada del usuario.
            try
            {
                numeroVoid = Convert.ToInt32(inputVoid); // Convierte la cadena a entero.
                // Llama al método 'DividirPorDos'.
                // Este método no devuelve un valor, sino que imprime el resultado directamente.
                operaciones.DividirPorDos(numeroVoid);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no válida para la división por 2. Por favor, introduce un número entero.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número es demasiado grande/pequeño para la división por 2.");
            }
            Console.WriteLine("\n--------------------------------------------------\n");


            // ====================================================================
            // Demostración de métodos con parámetros de salida ('out').
            // ====================================================================
            Console.WriteLine("--- Parte 2: Método con Parámetros de Salida (out) ---");
            int numParaOut = 25; // Número a dividir.
            int divisorOut = 4;  // Divisor.
            int cociente;        // Declaración de la variable 'cociente' que se pasará por 'out'.
            int resto;           // Declaración de la variable 'resto' que se pasará por 'out'.

            // Llama al método 'ObtenerCocienteYResto'.
            // Las variables 'cociente' y 'resto' se llenarán con los valores devueltos por el método.
            operaciones.ObtenerCocienteYResto(numParaOut, divisorOut, out cociente, out resto);
            Console.WriteLine($"Para {numParaOut} dividido por {divisorOut}:");
            Console.WriteLine($"Cociente: {cociente}");
            Console.WriteLine($"Resto: {resto}");
            Console.WriteLine("\n--------------------------------------------------\n");


            // ====================================================================
            // Demostración de sobrecarga de métodos.
            // ====================================================================
            Console.WriteLine("--- Parte 3: Sobrecarga de Métodos ---");
            int numSobrecarga1 = 5;  // Número para el primer método sobrecargado.
            int numSobrecarga2 = 7;  // Segundo número para el segundo método sobrecargado.

            // Llama al método 'Operacion' con un solo parámetro.
            // El compilador sabe qué versión de 'Operacion' llamar basándose en el tipo y número de parámetros.
            int resultadoOperacion1 = operaciones.Operacion(numSobrecarga1);
            Console.WriteLine($"Llamada a Operacion(int): {numSobrecarga1} + 10 = {resultadoOperacion1}");

            // Llama al método 'Operacion' con dos parámetros.
            int resultadoOperacion2 = operaciones.Operacion(numSobrecarga1, numSobrecarga2);
            Console.WriteLine($"Llamada a Operacion(int, int): {numSobrecarga1} * {numSobrecarga2} = {resultadoOperacion2}");
            Console.WriteLine("\n--------------------------------------------------\n");


            // ====================================================================
            // Demostración de una clase estática.
            // ====================================================================
            Console.WriteLine("--- Parte 4: Clase Estática ---");
            // No necesitas crear una instancia de una clase estática.
            // Llama directamente a sus métodos usando el nombre de la clase.
            ClaseEstatica.MensajeEstatico(); // Llama al método estático void.

            int numeroEstatico = 12; // Número para el método estático.
            // Llama al método estático que devuelve un valor.
            int resultadoEstatico = ClaseEstatica.MultiplicarPorDiezEstatico(numeroEstatico);
            Console.WriteLine($"Multiplicación estática: {numeroEstatico} * 10 = {resultadoEstatico}");
            Console.WriteLine("\n--------------------------------------------------\n");


            Console.WriteLine("Asignación de Clase de Método completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta.
        }
    }
}
