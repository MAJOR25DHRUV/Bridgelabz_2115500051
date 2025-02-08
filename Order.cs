using System;

// Base class representing a general Order
class Order
{
    public int OrderId { get; set; }  // Stores the order ID
    public string OrderDate { get; set; }  // Stores the order date

    // Method to return the order status
    public virtual string GetOrderStatus()
    {
        return "Order placed.";
    }
}

// ShippedOrder class inherits from Order
class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }  // Stores the tracking number

    // Overriding GetOrderStatus() to update the status
    public override string GetOrderStatus()
    {
        return "Order shipped. Tracking number: " + TrackingNumber;
    }
}

// DeliveredOrder class inherits from ShippedOrder
class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate { get; set; }  // Stores the delivery date

    // Overriding GetOrderStatus() to update the status
    public override string GetOrderStatus()
    {
        return $"Order delivered on {DeliveryDate}.";
    }
}

// Main program to test the classes
class Program
{
    static void Main()
    {
        // Creating an instance of DeliveredOrder
        DeliveredOrder order = new DeliveredOrder
        {
            OrderId = 5001,
            OrderDate = "2025-02-10",
            TrackingNumber = "ABC123XYZ",
            DeliveryDate = "2025-02-15"
        };

        // Displaying order status
        Console.WriteLine($"Order ID: {order.OrderId}, Date: {order.OrderDate}");
        Console.WriteLine(order.GetOrderStatus());
    }
}
