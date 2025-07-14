using Microsoft.EntityFrameworkCore; // Required for DbContext.
using CarInsurance.Models; // Required to reference your Insuree model.

namespace CarInsurance.Data // Ensure this namespace matches your project's Data folder.
{
    // ApplicationDbContext inherits from DbContext, which is Entity Framework Core's main class
    // for interacting with the database.
    public class ApplicationDbContext : DbContext
    {
        // Constructor for ApplicationDbContext.
        // It takes DbContextOptions as a parameter, which allows configuration of the database connection.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet<Insuree> represents a collection of all Insuree entities in the database.
        // This property will map to a table named "Insurees" in your database.
        // 'default!' is used here to tell the compiler that this property will be initialized
        // by Entity Framework Core, even though it's not explicitly initialized in the constructor.
        public DbSet<Insuree> Insuree { get; set; } = default!;
    }
}