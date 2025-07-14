using System;
using System.Collections.Generic; // Required for List<T>

namespace GenericsAssignment // Ensure this namespace matches your Program.cs
{
    // Define the Employee class with a generic type parameter 'T'.
    // 'T' is a placeholder for any data type that will be specified when an Employee object is created.
    // This makes the Employee class flexible to hold different types of "things".
    public class Employee<T>
    {
        // Property for Employee ID.
        public int Id { get; set; }

        // Property for Employee's First Name.
        public string FirstName { get; set; }

        // Property for Employee's Last Name.
        public string LastName { get; set; }

        // Property 'Things' of type List<T>.
        // The type of the list (T) will be the same as the generic type specified for the Employee class.
        // This allows 'Things' to be a list of strings, integers, or any other type.
        public List<T> Things { get; set; }
    }
}