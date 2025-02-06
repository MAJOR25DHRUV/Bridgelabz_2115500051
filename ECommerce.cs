using System;
using System.Collections.Generic;

// E-commerce Platform class contains customers and orders
class ECommercePlatform
{
    private string platformName;
    private List<Customer> customers;
    private List<Order> orders;

    public ECommercePlatform(string name)
    {
        platformName = name;
        customers = new List<Customer>();
        orders = new List<Order>();
    }

    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void DisplayPlatformDetails()
    {
        Console.WriteLine("E-Commerce Platform: " + platformName);
        Console.WriteLine("Customers:");
        foreach (Customer customer in customers)
        {
            Console.WriteLine("  - " + customer.GetCustomerName());
        }
        Console.WriteLine("Orders:");
        foreach (Order order in orders)
        {
            order.DisplayOrderDetails();
        }
    }
}

class Customer
{
    private string customerName;

    public Customer(string name)
    {
        customerName = name;
    }

    public string GetCustomerName()
    {
        return customerName;
    }

    public Order PlaceOrder(List<Product> products)
    {
        return new Order(this, products);
    }
}

class Order
{
    private static int orderCounter = 1;
    private int orderId;
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
        this.orderId = orderCounter++;
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine("Order ID: " + orderId + ", Customer: " + customer.GetCustomerName());
        Console.WriteLine("Products:");
        foreach (Product product in products)
        {
            Console.WriteLine("  - " + product.GetProductName());
        }
    }
}

class Product
{
    private string productName;

    public Product(string name)
    {
        productName = name;
    }

    public string GetProductName()
    {
        return productName;
    }
}

class Program
{
    static void Main()
    {
        ECommercePlatform platform = new ECommercePlatform("ShopEase");

        Customer customer1 = new Customer("John Doe");
        Customer customer2 = new Customer("Jane Smith");

        platform.AddCustomer(customer1);
        platform.AddCustomer(customer2);

        List<Product> products1 = new List<Product> { new Product("Laptop"), new Product("Mouse") };
        List<Product> products2 = new List<Product> { new Product("Phone"), new Product("Headphones") };

        Order order1 = customer1.PlaceOrder(products1);
        Order order2 = customer2.PlaceOrder(products2);

        platform.AddOrder(order1);
        platform.AddOrder(order2);

        platform.DisplayPlatformDetails();
    }
}