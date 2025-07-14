using System; // Necesario para Console.WriteLine en la implementación del método Quit().

namespace PolymorphismAssignment // Asegúrate de que este namespace coincida con tu Program.cs
{
    // Define la clase 'Employee' (Empleado).
    // ': Person, IQuittable' indica que 'Employee' hereda de 'Person'
    // y también implementa la interfaz 'IQuittable'.
    // Al implementar 'IQuittable', la clase 'Employee' DEBE proporcionar
    // una implementación para todos los métodos definidos en 'IQuittable'.
    public class Employee : Person, IQuittable
    {
        // Propiedad adicional 'Id' de tipo int para la clase Employee.
        public int Id { get; set; }

        // Implementación del método 'Quit()' de la interfaz 'IQuittable'.
        // Este método es requerido porque 'Employee' implementa 'IQuittable'.
        public void Quit()
        {
            // Muestra un mensaje en la consola indicando que el empleado ha renunciado.
            // Puedes personalizar este mensaje como quieras.
            Console.WriteLine($"El empleado {FirstName} {LastName} ha renunciado. ¡Adiós!");
        }
    }
}