using System; // Not strictly necessary for this class definition, but good practice.

namespace ConstructorAssignment // Ensure this namespace matches your Program.cs
{
    // Define the Product class.
    // This class will demonstrate constructor chaining.
    public class Product
    {
        // Properties of the Product class.
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }

        // First constructor (default constructor, or one with minimal parameters).
        // This constructor initializes the Name and Price.
        // It's common to set default or base values here.
        public Product(string name, decimal price)
        {
            // Assign the passed 'name' parameter to the Name property.
            Name = name;
            // Assign the passed 'price' parameter to the Price property.
            Price = price;
            // Set a default ProductId if not explicitly provided.
            // This ensures that even if only name and price are given, ProductId has a value.
            ProductId = 0; // A default value, indicating it's not yet assigned a specific ID.
        }

        // Second constructor, demonstrating constructor chaining.
        // This constructor takes all three parameters (name, price, productId).
        // The ': this(name, price)' syntax is crucial for chaining.
        // It calls the first constructor (the one that takes 'name' and 'price')
        // before executing the code inside this constructor's body.
        public Product(string name, decimal price, int productId) : this(name, price)
        {
            // After the first constructor (this(name, price)) has executed,
            // this constructor's body executes.
            // It then assigns the 'productId' parameter to the ProductId property.
            // This avoids duplicating the 'Name = name; Price = price;' lines.
            ProductId = productId;
        }
    }
}
