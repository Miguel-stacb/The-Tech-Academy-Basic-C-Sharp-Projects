using System;

namespace PolymorphismAssignment // Asegúrate de que este namespace coincida
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine($"Nombre: {FirstName} {LastName}");
        }
    }
}
