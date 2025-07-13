using System; // Necesario para Console.WriteLine.

namespace MethodClassAssignment2 // Asegúrate de que este namespace coincida con tu Program.cs
{
    // Esta clase contiene varios métodos para demostrar diferentes conceptos.
    public class Operaciones
    {
        // 1. Método 'void' que divide un número por 2 y muestra el resultado.
        // 'void' significa que este método no devuelve ningún valor directamente.
        // El resultado se muestra en la consola dentro del método.
        public void DividirPorDos(int numero)
        {
            // Realiza la operación de división.
            // La división de enteros truncará cualquier parte decimal.
            int resultado = numero / 2;
            // Muestra el resultado en la pantalla.
            Console.WriteLine($"El número {numero} dividido por 2 es: {resultado}");
        }

        // 2. Método con parámetros de salida ('out').
        // Este método toma un número y un divisor, y devuelve el cociente y el resto
        // a través de los parámetros 'out'.
        public void ObtenerCocienteYResto(int numero, int divisor, out int cociente, out int resto)
        {
            // Comprobación para evitar división por cero antes de la operación.
            if (divisor == 0)
            {
                Console.WriteLine("Error: El divisor no puede ser cero en ObtenerCocienteYResto.");
                cociente = 0; // Asigna un valor predeterminado si hay error.
                resto = 0;    // Asigna un valor predeterminado si hay error.
                return;       // Sale del método.
            }

            // Calcula el cociente de la división.
            cociente = numero / divisor;
            // Calcula el resto de la división (operador módulo %).
            resto = numero % divisor;
        }

        // 3. Sobrecarga de métodos: Primer método 'Operacion'.
        // Toma un solo parámetro entero y realiza una suma.
        public int Operacion(int num1)
        {
            // Realiza una operación matemática (suma 10).
            int resultado = num1 + 10;
            // Devuelve el resultado entero.
            return resultado;
        }

        // 3. Sobrecarga de métodos: Segundo método 'Operacion' con el mismo nombre.
        // Toma dos parámetros enteros y realiza una multiplicación.
        // La diferencia en los parámetros (cantidad y/o tipo) es lo que permite la sobrecarga.
        public int Operacion(int num1, int num2)
        {
            // Realiza una operación matemática diferente (multiplicación).
            int resultado = num1 * num2;
            // Devuelve el resultado entero.
            return resultado;
        }
    }
}
