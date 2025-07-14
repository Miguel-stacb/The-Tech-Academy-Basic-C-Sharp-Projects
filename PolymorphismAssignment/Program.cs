using System; // Necesario para Console.WriteLine.

namespace PolymorphismAssignment // Asegúrate de que este namespace coincida con tus otras clases
{
    class Program // La clase principal donde se ejecuta tu programa.
    {
        static void Main(string[] args) // El punto de entrada de la aplicación.
        {
            Console.WriteLine("--- Asignación de Polimorfismo con Interfaces ---\n");

            // 1. Crear una instancia de un objeto Employee.
            // Un objeto Employee es de tipo Employee, pero también es de tipo Person (por herencia)
            // y es de tipo IQuittable (porque implementa esa interfaz).
            Employee empleadoReal = new Employee();
            empleadoReal.FirstName = "Sample";
            empleadoReal.LastName = "Student";
            empleadoReal.Id = 1001; // Asignar un ID, aunque no se usa en este método.

            // 2. Utilizar el polimorfismo para crear un objeto de tipo IQuittable.
            // Declaramos una variable de tipo 'IQuittable' (la interfaz).
            // Le asignamos una instancia de 'Employee'. Esto es polimorfismo:
            // un objeto de una clase concreta (Employee) es tratado como un tipo de interfaz (IQuittable).
            IQuittable personaQuePuedeRenunciar = empleadoReal;

            // 3. Llamar al método Quit() en el objeto de tipo IQuittable.
            // Aunque la variable es de tipo 'IQuittable', el método 'Quit()' que se ejecuta
            // es la implementación específica de la clase 'Employee'.
            Console.WriteLine("Llamando al método Quit() a través de la interfaz IQuittable:");
            personaQuePuedeRenunciar.Quit();


            Console.WriteLine("\nAsignación de Polimorfismo completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta.
        }
    }
}
