using System; // Necesario para Console y para el tipo Enum.

namespace EnumParsingAssignment // Define el espacio de nombres para tu aplicación.
{
    // 1. Crea una enumeración para los días de la semana.
    // Por defecto, los valores de la enumeración son enteros, comenzando desde 0.
    // Por ejemplo, Lunes = 0, Martes = 1, etc.
    public enum DiasDeLaSemana
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }

    class Program // La clase principal donde se ejecuta tu programa.
    {
        static void Main(string[] args) // El punto de entrada de la aplicación.
        {
            Console.WriteLine("--- Asignación de Enumeraciones de Análisis ---\n");

            // 2. Pide al usuario que introduzca el día actual de la semana.
            Console.WriteLine("Por favor, introduce el día actual de la semana (ej. Lunes, Martes, Domingo):");
            string entradaUsuario = Console.ReadLine(); // Lee la entrada del usuario como una cadena.

            // Declara una variable del tipo de enumeración.
            // Se inicializa con un valor predeterminado para asegurar que tenga un valor.
            DiasDeLaSemana diaActual = DiasDeLaSemana.Lunes; // Valor predeterminado.

            // 3. Envuelve la declaración de asignación en un bloque try/catch.
            // El bloque 'try' contiene el código que podría lanzar una excepción.
            try
            {
                // 4. Asigna el valor a una variable del tipo de datos de enumeración.
                // Enum.Parse(): Convierte una cadena en un valor de enumeración.
                // - typeof(DiasDeLaSemana): Especifica el tipo de enumeración al que queremos convertir.
                // - entradaUsuario: La cadena que queremos analizar.
                // - true: Indica que la comparación de la cadena debe ignorar mayúsculas y minúsculas (case-insensitive).
                diaActual = (DiasDeLaSemana)Enum.Parse(typeof(DiasDeLaSemana), entradaUsuario, true);

                // Si la conversión es exitosa, muestra el día que el usuario introdujo.
                Console.WriteLine($"\nHas introducido: {diaActual}. ¡Es un día válido!");
            }
            // 5. Bloque 'catch' para manejar errores de análisis (FormatException o ArgumentException).
            // Si el usuario introduce una cadena que no coincide con ningún miembro de la enumeración,
            // Enum.Parse lanzará una ArgumentException o FormatException.
            catch (ArgumentException)
            {
                // Imprime el mensaje de error especificado si la entrada no es un día real de la semana.
                Console.WriteLine("\nError: Por favor, introduzca un día real de la semana.");
            }
            catch (FormatException) // Aunque ArgumentException es más común para Enum.Parse, FormatException también es posible.
            {
                Console.WriteLine("\nError: Por favor, introduzca un día real de la semana.");
            }
            // Puedes añadir un catch genérico para cualquier otra excepción inesperada.
            catch (Exception ex)
            {
                Console.WriteLine($"\nHa ocurrido un error inesperado: {ex.Message}");
            }

            Console.WriteLine("\nAsignación de Enumeraciones de Análisis completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta hasta que el usuario presione una tecla.
        }
    }
}