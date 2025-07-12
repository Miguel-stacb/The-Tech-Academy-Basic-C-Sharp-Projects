using System;

namespace SwitchChallengeApp // Puedes usar un nuevo namespace o el existente PackageExpressApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Reto: Sentencia Switch en C# ---");
            Console.WriteLine("¿Cuál es tu sabor de helado favorito?");
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1. Chocolate");
            Console.WriteLine("2. Vainilla");
            Console.WriteLine("3. Fresa");
            Console.WriteLine("4. Pistacho");
            Console.WriteLine("Otro (cualquier otro número o texto)");

            // Leer la entrada del usuario
            string userInput = Console.ReadLine();

            // Usar una sentencia switch para reaccionar a la entrada del usuario
            switch (userInput.ToLower()) // .ToLower() convierte la entrada a minúsculas para que 'Chocolate' y 'chocolate' sean lo mismo.
            {
                case "1": // Si el usuario escribe '1'
                case "chocolate": // Si el usuario escribe 'chocolate'
                    Console.WriteLine("¡Excelente elección! El chocolate es un clásico.");
                    break; // 'break' es crucial; sale de la sentencia switch.

                case "2": // Si el usuario escribe '2'
                case "vainilla": // Si el usuario escribe 'vainilla'
                    Console.WriteLine("¡Vainilla! Simple pero delicioso.");
                    break;

                case "3": // Si el usuario escribe '3'
                case "fresa": // Si el usuario escribe 'fresa'
                    Console.WriteLine("¡La fresa es refrescante!");
                    break;

                case "4": // Si el usuario escribe '4'
                case "pistacho": // Si el usuario escribe 'pistacho'
                    Console.WriteLine("El pistacho es para los paladares más sofisticados.");
                    break;

                default: // Si la entrada no coincide con ningún 'case' anterior
                    Console.WriteLine($"Interesante elección, {userInput}. ¡Disfruta tu helado!");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir.");
            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de cerrar la consola.
        }
    }
}
