using System; // Necesario para Console.WriteLine, aunque no se usa directamente en esta clase abstracta.

namespace AbstractClassAssignment // Asegúrate de que este namespace coincida con tu Program.cs
{
    // Define la clase abstracta 'Person'.
    // Una clase abstracta no puede ser instanciada directamente (no puedes hacer 'new Person()').
    // Está diseñada para ser una clase base de la cual otras clases pueden heredar.
    public abstract class Person
    {
        // Propiedad 'FirstName' (Nombre) de tipo string.
        public string FirstName { get; set; }

        // Propiedad 'LastName' (Apellido) de tipo string.
        public string LastName { get; set; }

        // Método abstracto 'SayName()'.
        // Un método abstracto no tiene implementación (cuerpo de código) en la clase abstracta.
        // Debe ser implementado (sobrescrito) por cualquier clase no abstracta que herede de 'Person'.
        // La palabra clave 'abstract' indica que es un método sin implementación aquí.
        public abstract void SayName();
    }
}
