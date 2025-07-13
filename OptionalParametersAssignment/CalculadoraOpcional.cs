using System; // Necesario si usas Console.WriteLine dentro de la clase, aunque aquí no lo haremos.

namespace OptionalParametersAssignment // Asegúrate de que este sea el mismo namespace que en Program.cs
{
    // Esta clase contiene un método que demuestra el uso de parámetros opcionales.
    public class CalculadoraOpcional
    {
        // Método que toma dos enteros como parámetros, donde el segundo es opcional.
        // El parámetro 'numeroOpcional' tiene un valor predeterminado de 0.
        // Esto significa que puedes llamar a este método pasando solo 'numeroPrincipal' o ambos.
        public int RealizarOperacion(int numeroPrincipal, int numeroOpcional = 0)
        {
            // Realiza una operación matemática: suma ambos números.
            // Si 'numeroOpcional' no se proporciona, se usará su valor predeterminado (0).
            int resultado = numeroPrincipal + numeroOpcional;

            // Devuelve el resultado de la operación.
            return resultado;
        }
    }
}
