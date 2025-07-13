using System; // Necesario para Console.WriteLine.

namespace MethodClassAssignment2 // Asegúrate de que este namespace coincida con tu Program.cs
{
    // Una clase 'static' no puede ser instanciada (no puedes usar 'new ClaseEstatica()').
    // Todos sus miembros (métodos, propiedades, campos) deben ser estáticos.
    // Se utiliza para utilidades o funciones que no necesitan estado de instancia.
    public static class ClaseEstatica
    {
        // Método estático que no toma parámetros y solo muestra un mensaje.
        // Se llama directamente usando el nombre de la clase (ClaseEstatica.MensajeEstatico()).
        public static void MensajeEstatico()
        {
            Console.WriteLine("¡Este es un mensaje de un método estático!");
        }

        // Método estático que toma un entero y devuelve un entero.
        // También se llama directamente usando el nombre de la clase.
        public static int MultiplicarPorDiezEstatico(int numero)
        {
            // Realiza una operación matemática.
            int resultado = numero * 10;
            // Devuelve el resultado.
            return resultado;
        }
    }
}