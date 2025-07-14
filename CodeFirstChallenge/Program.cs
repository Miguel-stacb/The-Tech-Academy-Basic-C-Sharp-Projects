using Microsoft.EntityFrameworkCore; // Necesario para DbContextOptionsBuilder y Migrate()
using Microsoft.Extensions.Configuration; // Necesario para IConfigurationRoot y ConfigurationBuilder
using System;
using System.IO; // Necesario para Directory.GetCurrentDirectory()
using System.Linq; // Necesario para el método .Any() en el ejemplo de verificación

namespace CodeFirstChallenge // Asegúrate de que el espacio de nombres coincida con tu proyecto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Desafío Final: Entity Framework Code-First ---");

            // 1. Configurar la carga de appsettings.json
            // Crea un constructor de configuración.
            var builder = new ConfigurationBuilder()
                // Establece la ruta base para los archivos de configuración al directorio actual de la aplicación.
                .SetBasePath(Directory.GetCurrentDirectory())
                // Agrega el archivo appsettings.json como fuente de configuración.
                // 'optional: true' significa que la aplicación puede ejecutarse incluso si el archivo no está.
                // 'reloadOnChange: true' significa que la configuración se recargará si el archivo cambia.
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            // Construye la configuración a partir de las fuentes añadidas.
            IConfigurationRoot configuration = builder.Build();

            // 2. Configurar DbContextOptions para SchoolContext
            // Crea un constructor de opciones para SchoolContext.
            var optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
            // Configura el contexto para usar SQL Server con la cadena de conexión "DefaultConnection"
            // obtenida de appsettings.json.
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            // 3. Crear y usar una instancia de SchoolContext
            // El bloque 'using' asegura que el contexto se elimine correctamente
            // y que la conexión a la base de datos se cierre cuando ya no sea necesario.
            using (var context = new SchoolContext(optionsBuilder.Options))
            {
                Console.WriteLine("\nVerificando y aplicando migraciones de la base de datos...");
                // Asegura que la base de datos esté creada y que las migraciones pendientes se apliquen.
                // Esto creará la base de datos 'SchoolDb' y la tabla 'Students' si aún no existen.
                context.Database.Migrate();
                Console.WriteLine("Base de datos y migraciones verificadas/aplicadas.");

                // 4. Agregar un nuevo alumno si no existe ya
                // Comprueba si ya existe un alumno con un nombre específico para evitar duplicados en cada ejecución.
                if (!context.Students.Any(s => s.Name == "Alice Smith"))
                {
                    // Crea una nueva instancia del modelo Student.
                    var student = new Student { Name = "Alice Smith", EnrollmentDate = DateTime.Now };

                    // Agrega el nuevo alumno a la colección DbSet de Students en el contexto.
                    context.Students.Add(student);
                    // Guarda los cambios en la base de datos.
                    // Esto insertará el nuevo registro de alumno en la tabla Students.
                    context.SaveChanges();

                    Console.WriteLine($"\n¡Alumno '{student.Name}' agregado exitosamente con ID: {student.Id}!");
                }
                else
                {
                    Console.WriteLine("\nEl alumno 'Alice Smith' ya existe en la base de datos. No se agregó un nuevo registro.");
                }

                // 5. Opcional: Recuperar y mostrar todos los alumnos
                Console.WriteLine("\nAlumnos actuales en la base de datos:");
                foreach (var s in context.Students)
                {
                    Console.WriteLine($"ID: {s.Id}, Nombre: {s.Name}, Inscrito: {s.EnrollmentDate.ToShortDateString()}");
                }
            }

            Console.WriteLine("\nDesafío Entity Framework Code-First completado. Presiona cualquier tecla para salir.");
            Console.ReadKey(); // Mantiene la ventana de la consola abierta hasta que se presione una tecla.
        }
    }
}
