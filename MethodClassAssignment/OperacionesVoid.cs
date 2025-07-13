using System; // Necesario para Console.WriteLine.

namespace MethodClassAssignment // Asegúrate de que este sea el mismo namespace que en Program.cs
{
    // Esta clase contiene un método 'void' que realiza una operación y muestra un valor.
    public class OperacionesVoid
    {
        // Método 'void' que toma dos enteros como parámetros.
        // 'void' significa que este método no devuelve ningún valor.
        // 'numero1' y 'numero2' son los parámetros que el método recibirá.
        public void RealizarOperacionYMostrar(int numero1, int numero2)
        {
            // Realiza una operación matemática en el primer número entero.
            // Por ejemplo, lo multiplica por 5. El resultado se usa internamente.
            int resultadoOperacion = numero1 * 5;

            // Muestra el segundo número entero en la pantalla.
            // El resultado de la operación en 'numero1' no se muestra, solo 'numero2'.
            Console.WriteLine($"El segundo número proporcionado es: {numero2}");
        }
    }
}
