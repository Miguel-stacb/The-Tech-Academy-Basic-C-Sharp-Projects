using System; // No estrictamente necesario para la definición de la interfaz, pero buena práctica.

namespace PolymorphismAssignment // Asegúrate de que este namespace coincida con tu Program.cs
{
    // Define la interfaz 'IQuittable'.
    // Una interfaz define un contrato de métodos que las clases que la implementen deben seguir.
    // Los nombres de interfaz en C# suelen comenzar con 'I' por convención.
    public interface IQuittable
    {
        // Declara un método 'void' llamado 'Quit()'.
        // Las interfaces solo definen la firma del método, no proporcionan una implementación (cuerpo).
        // Cualquier clase que implemente 'IQuittable' deberá proporcionar su propia implementación de 'Quit()'.
        void Quit();
    }
}
