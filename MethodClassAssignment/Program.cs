using System; // Necesario para las operaciones de consola (Console.WriteLine, Console.ReadLine).

namespace MethodClassAssignment // Asegúrate de que este sea el mismo namespace que en OperacionesVoid.cs
{
    class Program // La clase principal donde se ejecuta tu programa.
    {
        static void Main(string[] args) // El punto de entrada de la aplicación.
        {
            Console.WriteLine("--- Asignación de Clase de Método (Método Void y Parámetros Nombrados) ---\n");

            // Crea una instancia de la clase OperacionesVoid.
            // Esto es necesario para poder llamar a los métodos definidos en esa clase.
            OperacionesVoid operaciones = new OperacionesVoid();

            // ====================================================================
            // Llamar al método de la clase, pasando dos números directamente.
            // ====================================================================
            Console.WriteLine("--- Llamada al método pasando parámetros por posición: ---");
            // Aquí, los valores 10 y 20 se asignan a 'numero1' y 'numero2' respectivamente,
            // basándose en el orden en que están definidos en el método.
            operaciones.RealizarOperacionYMostrar(10, 20);
            Console.WriteLine("Operación con (10, 20) completada.\n");

            // ====================================================================
            // Llamar al método de la clase, especificando los parámetros por nombre.
            // ====================================================================
            Console.WriteLine("--- Llamada al método especificando parámetros por nombre: ---");
            // Aquí, especificamos explícitamente a qué parámetro va cada valor.
            // Esto mejora la legibilidad, especialmente con muchos parámetros o si el orden no es obvio.
            // El orden de los parámetros nombrados no importa, siempre y cuando se especifiquen.
            operaciones.RealizarOperacionYMostrar(numero2: 50, numero1: 30);
            Console.WriteLine("Operación con (numero1: 30, numero2: 50) completada.\n");


            Console.WriteLine("Asignación de Clase de Método completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta hasta que el usuario presione una tecla.
        }
    }
}
