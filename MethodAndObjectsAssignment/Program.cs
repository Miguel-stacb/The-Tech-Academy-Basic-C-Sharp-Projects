using System; // Necesario para Console.WriteLine.

namespace MethodAndObjectsAssignment // Asegúrate de que este namespace coincida con tus otras clases
{
    class Program // La clase principal donde se ejecuta tu programa.
    {
        static void Main(string[] args) // El punto de entrada de la aplicación.
        {
            Console.WriteLine("--- Asignación de Métodos y Objetos (Herencia) ---\n");

            // Crea una instancia de la clase Employee (Empleado).
            // Aunque es un objeto Employee, también tiene las propiedades de Person debido a la herencia.
            Employee empleado = new Employee();

            // Inicializa las propiedades del objeto Employee.
            // 'Nombre' y 'Apellido' son propiedades heredadas de la clase Person.
            empleado.Nombre = "Sample";
            empleado.Apellido = "Student";
            // 'Id' es una propiedad específica de la clase Employee.
            empleado.Id = 12345; // Asigna un valor de ID de ejemplo.

            // Llama al método de superclase (SayName()) en el objeto Employee.
            // Aunque SayName() está definido en la clase Person, Employee lo hereda
            // y puede llamarlo como si fuera su propio método.
            Console.WriteLine("Llamando al método SayName() en el objeto Employee:");
            empleado.SayName();

            // También podemos mostrar la propiedad Id para verificar.
            Console.WriteLine($"ID del empleado: {empleado.Id}");


            Console.WriteLine("\nAsignación de Métodos y Objetos completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta.
        }
    }
}
