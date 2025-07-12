using System; // Importa el namespace System para usar Console.WriteLine y Console.ReadLine.
using System.Text; // Importa el namespace System.Text para usar la clase StringBuilder.

namespace StringAssignmentApp // Define un namespace para organizar tu aplicación.
{
    class Program // Define la clase principal donde se ejecutará la aplicación.
    {
        static void Main(string[] args) // El método Main es el punto de entrada de la aplicación.
        {
            Console.WriteLine("--- Asignación de Cadenas en C# ---");
            Console.WriteLine("Este programa demuestra la concatenación, conversión a mayúsculas y el uso de StringBuilder.\n");

            // ====================================================================
            // 1. Concatenación de tres cadenas
            // ====================================================================

            Console.WriteLine("--- Demostración de Concatenación de Cadenas ---");

            string parte1 = "Hola"; // Declara e inicializa la primera parte de la cadena.
            string parte2 = " mundo"; // Declara e inicializa la segunda parte de la cadena.
            string parte3 = " de C#!"; // Declara e inicializa la tercera parte de la cadena.

            // Método 1: Concatenación usando el operador '+'
            string cadenaConcatenada1 = parte1 + parte2 + parte3; // Concatena las tres cadenas usando el operador '+'.
            Console.WriteLine($"Concatenación con '+': {cadenaConcatenada1}"); // Muestra el resultado.

            // Método 2: Concatenación usando string.Concat()
            string cadenaConcatenada2 = string.Concat(parte1, parte2, parte3); // Concatena las tres cadenas usando el método estático String.Concat().
            Console.WriteLine($"Concatenación con String.Concat(): {cadenaConcatenada2}"); // Muestra el resultado.

            // Método 3: Concatenación usando interpolación de cadenas (método moderno y preferido)
            string cadenaConcatenada3 = $"{parte1}{parte2}{parte3}"; // Concatena las cadenas usando interpolación de cadenas.
            Console.WriteLine($"Concatenación con interpolación: {cadenaConcatenada3}\n"); // Muestra el resultado.

            // ====================================================================
            // 2. Conversión de una cadena a mayúsculas
            // ====================================================================

            Console.WriteLine("--- Demostración de Conversión a Mayúsculas ---");

            string textoOriginal = "Esta es una cadena para convertir a mayúsculas."; // Declara e inicializa una cadena.
            Console.WriteLine($"Texto original: {textoOriginal}"); // Muestra el texto original.

            string textoMayusculas = textoOriginal.ToUpper(); // Convierte toda la cadena a mayúsculas usando el método ToUpper().
            Console.WriteLine($"Texto en mayúsculas: {textoMayusculas}\n"); // Muestra la cadena convertida.

            // ====================================================================
            // 3. Creación de un párrafo de texto con StringBuilder
            // ====================================================================

            Console.WriteLine("--- Demostración de StringBuilder ---");

            // Crea una nueva instancia de StringBuilder.
            // StringBuilder es eficiente para construir cadenas grandes añadiendo partes.
            StringBuilder parrafo = new StringBuilder();

            // Añade la primera oración al StringBuilder. AppendLine() añade la cadena y un salto de línea.
            parrafo.AppendLine("El StringBuilder es una clase muy útil en C#.");

            // Añade la segunda oración.
            parrafo.AppendLine("Permite construir cadenas de texto de manera eficiente.");

            // Añade la tercera oración.
            parrafo.AppendLine("Cada adición no crea una nueva instancia de cadena en memoria, lo que optimiza el rendimiento.");

            // Añade la cuarta oración.
            parrafo.AppendLine("Es ideal para operaciones donde se concatenan muchas partes de texto.");

            // Convierte el contenido del StringBuilder a una cadena String final para poder mostrarla.
            string parrafoCompleto = parrafo.ToString();
            Console.WriteLine("Párrafo construido con StringBuilder:"); // Muestra un encabezado.
            Console.WriteLine(parrafoCompleto); // Muestra el párrafo completo.

            Console.WriteLine("\nPrograma finalizado. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta hasta que el usuario presione una tecla.
        }
    }
}
