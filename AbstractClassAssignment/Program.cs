using System; // Necesario para Console.WriteLine.

namespace AbstractClassAssignment // Asegúrate de que este namespace coincida con tus otras clases
{
    class Program // La clase principal donde se ejecuta tu programa.
    {
        static void Main(string[] args) // El punto de entrada de la aplicación.
        {
            Console.WriteLine("--- Asignación de Clase Abstracta ---\n");

            // Crea una instancia de un objeto Employee.
            // No podemos instanciar directamente 'Person' porque es abstracta,
            // pero sí podemos instanciar 'Employee' porque es una clase concreta (no abstracta)
            // que ha implementado el método abstracto 'SayName()'.
            Employee empleado = new Employee();

            // Asigna valores a las propiedades 'FirstName' y 'LastName' del objeto Employee.
            // Estas propiedades son heredadas de la clase abstracta Person.
            empleado.FirstName = "Sample";
            empleado.LastName = "Student";

            // Llama al método SayName() en el objeto Employee.
            // Este método es la implementación específica que se definió en la clase Employee.
            Console.WriteLine("Llamando al método SayName() en el objeto Employee:");
            empleado.SayName();


            Console.WriteLine("\nAsignación de Clase Abstracta completada. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta hasta que el usuario presione una tecla.
        }
    }
}
