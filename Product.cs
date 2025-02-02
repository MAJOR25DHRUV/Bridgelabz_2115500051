using System;
class Product
{
    private string productName;
    private double price;
    private static int totalProducts = 0;

    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product: {productName}, Price: {price}");
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products: {totalProducts}");
    }
}