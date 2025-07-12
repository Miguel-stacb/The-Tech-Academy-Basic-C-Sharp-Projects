using System; // Importa el namespace System para usar funcionalidades básicas como Console.WriteLine y Console.ReadLine.

namespace PackageExpressApp // Define un namespace para organizar el código.
{
    class Program // Define la clase principal donde se ejecutará la aplicación.
    {
        static void Main(string[] args) // El método Main es el punto de entrada de la aplicación.
        {
            // Paso 1: Mensaje de bienvenida
            Console.WriteLine("Bienvenido a Package Express. Por favor, siga las instrucciones a continuación."); // Muestra el mensaje de bienvenida al usuario.

            // Paso 2: Solicitar el peso del paquete
            Console.WriteLine("Ingrese el peso del paquete:"); // Pide al usuario que ingrese el peso.
            string pesoString = Console.ReadLine(); // Lee la entrada del usuario como una cadena de texto.
            double peso = Convert.ToDouble(pesoString); // Convierte la cadena de texto a un tipo de dato 'double' para operaciones numéricas.

            // Paso 3: Validar el peso del paquete
            if (peso > 50) // Comprueba si el peso ingresado es mayor que 50.
            {
                Console.WriteLine("El paquete es demasiado pesado para enviarlo a través de Package Express. Que tengas un buen día."); // Muestra un mensaje de error si el peso es excesivo.
                Console.ReadLine(); // Espera a que el usuario presione Enter antes de cerrar la consola (útil para ver el mensaje en una ventana que se cierra automáticamente).
                return; // Termina la ejecución del programa si el peso es demasiado alto.
            }

            // Paso 4: Solicitar el ancho del paquete
            Console.WriteLine("Ingrese el ancho del paquete:"); // Pide al usuario que ingrese el ancho.
            string anchoString = Console.ReadLine(); // Lee el ancho como una cadena.
            double ancho = Convert.ToDouble(anchoString); // Convierte la cadena del ancho a 'double'.

            // Paso 4: Solicitar la altura del paquete
            Console.WriteLine("Ingrese la altura del paquete:"); // Pide al usuario que ingrese la altura.
            string alturaString = Console.ReadLine(); // Lee la altura como una cadena.
            double altura = Convert.ToDouble(alturaString); // Convierte la cadena de la altura a 'double'.

            // Paso 4: Solicitar la longitud del paquete
            Console.WriteLine("Ingrese la longitud del paquete:"); // Pide al usuario que ingrese la longitud.
            string longitudString = Console.ReadLine(); // Lee la longitud como una cadena.
            double longitud = Convert.ToDouble(longitudString); // Convierte la cadena de la longitud a 'double'.

            // Paso 5: Validar las dimensiones totales
            double dimensionesTotales = ancho + altura + longitud; // Suma todas las dimensiones para obtener un total.
            if (dimensionesTotales > 50) // Comprueba si la suma de las dimensiones es mayor que 50.
            {
                Console.WriteLine("El paquete es demasiado grande para enviarlo a través de Package Express."); // Muestra un mensaje de error si las dimensiones son excesivas.
                Console.ReadLine(); // Espera a que el usuario presione Enter.
                return; // Termina la ejecución del programa si las dimensiones son demasiado grandes.
            }

            // Paso 6: Calcular la cotización del envío
            // Multiplica las tres dimensiones, luego multiplica el producto por el peso y divide el resultado entre 100.
            double cotizacion = ((ancho * altura * longitud) * peso) / 100; // Realiza el cálculo de la cotización.

            // Paso 7: Mostrar la cotización al usuario
            // Utiliza un formato de moneda "C" para mostrar el resultado como un monto en dólares.
            Console.WriteLine("Su total estimado para el envío de este paquete es: " + cotizacion.ToString("C")); // Muestra la cotización formateada.
            Console.WriteLine("¡Gracias!"); // Mensaje de despedida.

            Console.ReadLine(); // Mantiene la ventana de la consola abierta hasta que el usuario presione Enter, para que pueda ver el resultado final.
        }
    }
}