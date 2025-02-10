using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<FoodItem> items = new List<FoodItem>
        {
            new VegItem("Vegetable Curry", 12.99, 2),
            new NonVegItem("Chicken Tikka", 15.99, 1)
        };

        foreach (FoodItem item in items)
        {
            Console.WriteLine("Food Item Details:");
            item.GetItemDetails();
            Console.WriteLine("Total Price: $" + item.CalculateTotalPrice());
            
            // Using 'as' operator for interface checking
            IDiscountable discountable = item as IDiscountable;
            if (discountable != null)
            {
                Console.WriteLine("Discount Details: " + discountable.GetDiscountDetails());
                Console.WriteLine("Final Price: $" + discountable.ApplyDiscount());
            }
            Console.WriteLine();
        }
    }
}

// Abstract base class for all food items
public abstract class FoodItem
{
    // Private fields for encapsulation
    private string itemName;
    private double price;
    private int quantity;

    // Constructor to initialize food item details
    protected FoodItem(string itemName, double price, int quantity)
    {
        this.ItemName = itemName;
        this.Price = price;
        this.Quantity = quantity;
    }

    // Public properties with validation
    public string ItemName
    {
        get { return itemName; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Item name cannot be empty");
            itemName = value;
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

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Quantity cannot be negative");
            quantity = value;
        }
    }

    // Abstract method for total price calculation
    public abstract double CalculateTotalPrice();

    // Concrete method for displaying item details
    public virtual void GetItemDetails()
    {
        Console.WriteLine("Name: " + ItemName);
        Console.WriteLine("Price: $" + Price);
        Console.WriteLine("Quantity: " + Quantity);
    }
}

// Interface for discountable items
public interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

// VegItem implementation
public class VegItem : FoodItem, IDiscountable
{
    // Private constant for discount
    private const double DiscountRate = 0.1; // 10% discount

    // Constructor
    public VegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity) { }

    // Implementation of abstract method
    public override double CalculateTotalPrice()
    {
        return Price * Quantity;
    }

    // Implementation of interface methods
    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * (1 - DiscountRate);
    }

    public string GetDiscountDetails()
    {
        return "Vegetarian Discount: 10%";
    }
}

// NonVegItem implementation
public class NonVegItem : FoodItem, IDiscountable
{
    // Private constant for discount
    private const double DiscountRate = 0.05; // 5% discount

    // Constructor
    public NonVegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity) { }

    // Implementation of abstract method
    public override double CalculateTotalPrice()
    {
        return Price * Quantity * 1.1; // 10% extra charge for non-veg items
    }

    // Implementation of interface methods
    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * (1 - DiscountRate);
    }

    public string GetDiscountDetails()
    {
        return "Non-Vegetarian Discount: 5%";
    }
}