using Microsoft.EntityFrameworkCore; // Necesario para heredar de DbContext
using System.Diagnostics.CodeAnalysis; // Necesario para [NotNull] si se usa en el constructor

namespace CodeFirstChallenge // Asegúrate de que el espacio de nombres coincida con tu proyecto
{
    // SchoolContext hereda de DbContext, la clase principal de Entity Framework Core
    // para interactuar con la base de datos.
    public class SchoolContext : DbContext
    {
        // Constructor que acepta DbContextOptions.
        // Esto permite configurar la conexión a la base de datos externamente (ej. desde Program.cs).
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        // DbSet<Student> representa la colección de entidades Student en la base de datos.
        // Esto mapeará a una tabla llamada "Students" por convención.
        // 'default!' se usa para indicar al compilador que esta propiedad será inicializada
        // por Entity Framework Core, suprimiendo advertencias de nulabilidad.
        public DbSet<Student> Students { get; set; } = default!;
    }
}