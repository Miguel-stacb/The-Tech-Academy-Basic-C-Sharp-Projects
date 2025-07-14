using System; // Necesario para Console.WriteLine

namespace MethodAndObjectsAssignment // Asegúrate de que este namespace coincida con tu Program.cs
{
    // Define la clase 'Person' (Persona). Esta es la clase base o superclase.
    public class Person
    {
        // Propiedad 'Nombre' (FirstName) de tipo string.
        // Representa el nombre de pila de la persona.
        public string Nombre { get; set; }

        // Propiedad 'Apellido' (LastName) de tipo string.
        // Representa el apellido de la persona.
        public string Apellido { get; set; }

        // Método 'void' llamado 'SayName()' que no toma parámetros.
        // Un método 'void' no devuelve ningún valor.
        public void SayName()
        {
            // Escribe el nombre completo de la persona en la consola.
            // Utiliza la interpolación de cadenas para un formato claro.
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
        }
    }
}