using Microsoft.EntityFrameworkCore; // Necesario para DbContextOptionsBuilder
using Microsoft.EntityFrameworkCore.Design; // Necesario para IDesignTimeDbContextFactory
using Microsoft.Extensions.Configuration; // Necesario para ConfigurationBuilder
using System.IO; // Necesario para Directory.GetCurrentDirectory()

namespace CodeFirstChallenge // Asegúrate de que el espacio de nombres coincida con tu proyecto
{
    // Esta clase implementa IDesignTimeDbContextFactory para permitir que las herramientas de EF Core
    // creen una instancia de SchoolContext en tiempo de diseño (ej. al ejecutar Add-Migration).
    public class SchoolContextFactory : IDesignTimeDbContextFactory<SchoolContext>
    {
        // Este método es llamado por las herramientas de EF Core para crear una instancia de DbContext.
        public SchoolContext CreateDbContext(string[] args)
        {
            // Re-crea la lógica de configuración de appsettings.json que tienes en Program.cs.
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Establece la ruta base
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); // Carga appsettings.json

            IConfigurationRoot configuration = builder.Build(); // Construye la configuración

            // Configura DbContextOptions para SchoolContext usando la cadena de conexión.
            var optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            // Retorna una nueva instancia de SchoolContext con las opciones configuradas.
            return new SchoolContext(optionsBuilder.Options);
        }
    }
}
