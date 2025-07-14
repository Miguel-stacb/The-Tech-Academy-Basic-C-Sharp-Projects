using System;
using System.ComponentModel.DataAnnotations; // Necesario para el atributo [Key]

namespace CodeFirstChallenge // Asegúrate de que el espacio de nombres coincida con tu proyecto
{
    // Define la clase Student, que se mapeará a una tabla en la base de datos.
    public class Student
    {
        // La propiedad 'Id' se configurará automáticamente como la clave primaria
        // y una columna de identidad (auto-incremento) en la base de datos por convención.
        [Key] // Marca explícitamente 'Id' como la clave primaria.
        public int Id { get; set; }

        // Propiedad para el nombre del alumno.
        public string Name { get; set; } = string.Empty; // Inicializa para evitar advertencias de nulabilidad.

        // Propiedad para la fecha de inscripción del alumno.
        public DateTime EnrollmentDate { get; set; }
    }
}

