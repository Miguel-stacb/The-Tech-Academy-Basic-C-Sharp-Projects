using System; // Necesario si usas Console.WriteLine dentro de la clase, aunque aquí no lo haremos.

namespace CallingMethodsAssignment // Asegúrate de que este sea el mismo namespace que en Program.cs
{
    // Esta clase contendrá métodos que realizan operaciones matemáticas.
    public class OperacionesMatematicas
    {
        // Método 1: Suma un número fijo al parámetro de entrada.
        // Public: Hace que el método sea accesible desde fuera de esta clase.  
        // int: Indica que este método devolverá un número entero.
        // (int numero): Declara un parámetro entero llamado 'numero' que el método recibirá.
        public int SumarDiez(int numero)
        {
            // Realiza la operación matemática: suma 10 al número recibido.
            int resultado = numero + 10;
            // Devuelve el resultado de la operación.
            return resultado;
        }

        // Método 2: Multiplica el parámetro de entrada por un número fijo.
        // int: Indica que este método devolverá un número entero.
        public int MultiplicarPorCinco(int numero)
        {
            // Realiza la operación matemática: multiplica el número recibido por 5.
            int resultado = numero * 5;
            // Devuelve el resultado.
            return resultado;
        }

        // Método 3: Divide el parámetro de entrada por un número fijo.
        // int: Indica que este método devolverá un número entero.
        public int DividirEntreDos(int numero)
        {
            // Realiza la operación matemática: divide el número recibido entre 2.
            // Nota: La división de enteros en C# truncará los decimales (ej. 7 / 2 = 3).
            int resultado = numero / 2;
            // Devuelve el resultado.
            return resultado;
        }
    }
}
