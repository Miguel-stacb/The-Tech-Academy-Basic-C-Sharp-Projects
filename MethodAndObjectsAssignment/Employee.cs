using System; // No estrictamente necesario aquí, pero buena práctica si se usara Console.WriteLine.

namespace MethodAndObjectsAssignment // Asegúrate de que este namespace coincida con tu Program.cs
{
    // Define la clase 'Employee' (Empleado).
    // ': Person' indica que la clase 'Employee' hereda de la clase 'Person'.
    // Esto significa que 'Employee' automáticamente tiene las propiedades 'Nombre' y 'Apellido',
    // y el método 'SayName()' de la clase 'Person'.
    public class Employee : Person
    {
        // Propiedad adicional 'Id' de tipo int para la clase Employee.
        // Esta propiedad es única de los empleados y no está en la clase base Person.
        public int Id { get; set; }
    }
}
