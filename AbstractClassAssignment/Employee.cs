using System; // Necesario para Console.WriteLine, ya que se usará en la implementación del método.

namespace AbstractClassAssignment // Asegúrate de que este namespace coincida con tu Program.cs
{
    // Define la clase 'Employee' (Empleado).
    // ': Person' indica que la clase 'Employee' hereda de la clase abstracta 'Person'.
    // Como 'Employee' no es abstracta, DEBE implementar todos los métodos abstractos de 'Person'.
    public class Employee : Person
    {
        // Implementación del método abstracto 'SayName()' de la clase base 'Person'.
        // La palabra clave 'override' es obligatoria para proporcionar una implementación
        // para un método abstracto o para sobrescribir un método virtual de la clase base.
        public override void SayName()
        {
            // Escribe el nombre completo de la persona en la consola.
            // Accede a las propiedades 'FirstName' y 'LastName' que son heredadas de 'Person'.
            Console.WriteLine($"Nombre: {FirstName} {LastName}");
        }
    }
}