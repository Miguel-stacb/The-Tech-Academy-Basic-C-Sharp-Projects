using System; // Required for DateTime.
using System.ComponentModel.DataAnnotations; // Required for [Key] and [Required] attributes.

namespace CarInsurance.Models // Ensure this namespace matches your project's namespace.
{
    // Define the Insuree class, which will represent a record in our database.
    public class Insuree
    {
        // Primary Key for the Insuree table.
        // [Key] attribute marks this property as the primary key in the database.
        public int Id { get; set; }

        // [Required] attribute makes this field mandatory in the database.
        // For non-nullable reference types (like string), if nullable context is enabled,
        // you might also initialize them to string.Empty or use 'string?' for nullable.
        // However, [Required] is the primary way EF Core handles non-nullability for strings.
        [Required]
        public string FirstName { get; set; } = string.Empty; // Initialize to empty string to satisfy compiler

        [Required]
        public string LastName { get; set; } = string.Empty; // Initialize to empty string

        [Required]
        public string EmailAddress { get; set; } = string.Empty; // Initialize to empty string

        // DateTime type for date of birth.
        // DateTime is a value type and is non-nullable by default.
        public DateTime DateOfBirth { get; set; }

        // Integer type for car year.
        public int CarYear { get; set; }

        [Required]
        public string CarMake { get; set; } = string.Empty; // Initialize to empty string

        [Required]
        public string CarModel { get; set; } = string.Empty; // Initialize to empty string

        // Boolean type to indicate DUI (Driving Under Influence).
        public bool DUI { get; set; }

        // Integer type for the number of speeding tickets.
        public int SpeedingTickets { get; set; }

        // Boolean type for full coverage (true for full, false for liability).
        public bool CoverageType { get; set; }

        // Decimal type for the insurance quote, as it involves currency.
        public decimal Quote { get; set; }
    }
}
