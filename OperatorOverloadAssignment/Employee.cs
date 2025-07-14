using System; // Required for object.Equals and object.GetHashCode

namespace OperatorOverloadAssignment // Ensure this namespace matches your Program.cs
{
    // Define the Employee class.
    // This class will demonstrate operator overloading.
    public class Employee
    {
        // Property for Employee ID. This will be used for comparison.
        public int Id { get; set; }

        // Property for Employee's First Name.
        public string FirstName { get; set; }

        // Property for Employee's Last Name.
        public string LastName { get; set; }

        // Overload the "==" operator.
        // This static method defines what it means for two Employee objects to be "equal".
        // It compares them based on their 'Id' property.
        // 'static' because operators are associated with the class, not an instance.
        // 'bool' because comparison operators return true or false.
        // (Employee employee1, Employee employee2) are the two operands being compared.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check for null on both sides.
            // If both are null, they are considered equal.
            if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
            {
                return true;
            }

            // If one is null, but not both, they are not equal.
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }

            // Compare the Id properties.
            // Two Employee objects are considered equal if their Id properties are the same.
            return employee1.Id == employee2.Id;
        }

        // Overload the "!=" operator.
        // This is required when "==" is overloaded, as they must be paired.
        // It simply returns the opposite of the "==" comparison.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // Use the overloaded "==" operator and negate its result.
            return !(employee1 == employee2);
        }

        // Override the Equals method.
        // It's good practice to override Equals() when overloading "==".
        // This ensures consistent behavior when objects are compared using Equals() method.
        public override bool Equals(object obj)
        {
            // Check if the object being compared is null or not an Employee.
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // Cast the object to an Employee type.
            Employee employee = (Employee)obj;

            // Compare the Id properties.
            return Id == employee.Id;
        }

        // Override the GetHashCode method.
        // It's good practice to override GetHashCode() when overriding Equals().
        // If two objects are equal according to Equals(), their hash codes must be equal.
        // This is important for collections like HashSet or Dictionary.
        public override int GetHashCode()
        {
            // Return the hash code of the Id property.
            // If Id is the basis for equality, its hash code should be the basis for the object's hash code.
            return Id.GetHashCode();
        }
    }
}
