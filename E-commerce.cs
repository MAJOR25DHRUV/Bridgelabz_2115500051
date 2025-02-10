using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Electronics("Laptop", "E001", 1200.00),
            new Clothing("T-Shirt", "C001", 29.99),
            new Groceries("Bread", "G001", 3.99)
        };

        // Loop through each product
        foreach (Product product in products)
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine("Name: " + product.Name);
            Console.WriteLine("Price: $" + product.Price);
            Console.WriteLine("Discount: $" + product.CalculateDiscount());

            // Explicitly checking if the product implements ITaxable
            ITaxable taxableProduct = product as ITaxable;
            if (taxableProduct != null)
            {
                Console.WriteLine("Tax: $" + taxableProduct.CalculateTax());
                Console.WriteLine("Tax Details: " + taxableProduct.GetTaxDetails());
            }

            Console.WriteLine();
        }
    }
}

// Abstract base class for all products
public abstract class Product
{
    // Private fields for encapsulation
    private string productId;
    private string name;
    private double price;

    // Constructor to initialize product details
    protected Product(string name, string productId, double price)
    {
        this.Name = name;
        this.ProductId = productId;
        this.Price = price;
    }

    // Public properties with validation
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Name cannot be empty");
            name = value;
        }
    }

    public string ProductId
    {
        get { return productId; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Product ID cannot be empty");
            productId = value;
        }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Price cannot be negative");
            price = value;
        }
    }

    // Abstract method for discount calculation
    public abstract double CalculateDiscount();
}

// Interface for taxable products
public interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Electronics implementation
public class Electronics : Product, ITaxable
{
    // Constructor
    public Electronics(string name, string productId, double price)
        : base(name, productId, price) { }

    // Implementation of abstract method
    public override double CalculateDiscount()
    {
        return Price * 0.1; // 10% discount
    }

    // Implementation of interface methods
    public double CalculateTax()
    {
        return Price * 0.2; // 20% tax
    }

    public string GetTaxDetails()
    {
        return "Electronics Tax Rate: 20%";
    }
}

// Clothing implementation
public class Clothing : Product
{
    // Constructor
    public Clothing(string name, string productId, double price)
        : base(name, productId, price) { }

    // Implementation of abstract method
    public override double CalculateDiscount()
    {
        return Price * 0.05; // 5% discount
    }
}

// Groceries implementation
public class Groceries : Product
{
    // Constructor
    public Groceries(string name, string productId, double price)
        : base(name, productId, price) { }

    // Implementation of abstract method
    public override double CalculateDiscount()
    {
        return Price * 0.02; // 2% discount
    }
}
