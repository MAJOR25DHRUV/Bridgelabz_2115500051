using System;

class Product
{
    // Static variable shared by all products to store the discount percentage
    static double Discount = 10.0; 
    
    // Instance variables for ProductName, Price, and Quantity
    public string ProductName;
    public double Price;
    public int Quantity;

    // Readonly variable for ProductID to ensure it's unique and cannot be changed once assigned
    public readonly int ProductID;

    // Static method to update the discount percentage for all products
    private static void UpdateDiscount(double newDiscount)
    {
        // Updating the static Discount variable with the new discount percentage
        Discount = newDiscount;
    }

    // Constructor to initialize ProductName, Price, and Quantity using 'this' keyword
    public Product(int productID, string productName, double price, int quantity)
    {
        // Initializing instance variables using constructor parameters
        this.ProductID = productID;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    // Instance method to display product details
    public void DisplayDetails()
    {
        // Checking if the current object is an instance of the Product class using 'is' operator
        if (this is Product)
        {
            // Printing product details including price, quantity, and the discount
            Console.WriteLine("Product ID: " + ProductID);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: $" + Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Discount: " + Discount + "%");
        }
    }

    static void Main(string[] args)
    {
        // Creating a product object
        Product prod1 = new Product(101, "Laptop", 1200.0, 2);
        Product prod2 = new Product(102, "Smartphone", 800.0, 5);

        // Displaying product details
        prod1.DisplayDetails();
        prod2.DisplayDetails();

        // Updating the discount percentage for all products using the static method
        Product.UpdateDiscount(15.0);

        // Displaying updated product details after applying new discount
        Console.WriteLine("\nAfter Discount Update:");
        prod1.DisplayDetails();
        prod2.DisplayDetails();
    }
}
