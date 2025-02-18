using System;
using System.Collections.Generic;

public abstract class WarehouseItem
{
    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Price { get; set; }

    public abstract void GetItemDetails();
}

public class Electronics : WarehouseItem
{
    public string Brand { get; set; }
    public int WarrantyPeriod { get; set; }

    public override void GetItemDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Warranty Period: " + WarrantyPeriod + " years");
    }
}

public class Groceries : WarehouseItem
{
    public DateTime ExpiryDate { get; set; }
    public double Weight { get; set; }

    public override void GetItemDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Expiry Date: " + ExpiryDate.ToShortDateString());
        Console.WriteLine("Weight: " + Weight + " kg");
    }
}

public class Furniture : WarehouseItem
{
    public string Material { get; set; }
    public string Dimensions { get; set; }

    public override void GetItemDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Material: " + Material);
        Console.WriteLine("Dimensions: " + Dimensions);
    }
}

public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void RemoveItem(int id)
    {
        T itemToRemove = items.Find(item => item.Id == id);
        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
            Console.WriteLine("Item removed successfully.");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    public void DisplayAllItems()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("No items available.");
            return;
        }

        foreach (T item in items)
        {
            item.GetItemDetails();
            Console.WriteLine("------------------------");
        }
    }
}

public class WarehouseManager
{
    private Storage<Electronics> electronicStorage = new Storage<Electronics>();
    private Storage<Groceries> groceryStorage = new Storage<Groceries>();
    private Storage<Furniture> furnitureStorage = new Storage<Furniture>();

    public void UserInteraction()
    {
        while (true)
        {
            Console.WriteLine("\nWarehouse Management System");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Display Items");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddNewItem();
                    break;
                case 2:
                    RemoveItem();
                    break;
                case 3:
                    DisplayItems();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    private void AddNewItem()
    {
        Console.WriteLine("Select category: 1. Electronics 2. Groceries 3. Furniture");
        int category = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Price: ");
        decimal price = Convert.ToDecimal(Console.ReadLine());

        switch (category)
        {
            case 1:
                Console.Write("Enter Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Enter Warranty Period: ");
                int warranty = Convert.ToInt32(Console.ReadLine());
                electronicStorage.AddItem(new Electronics { Name = name, Id = id, Price = price, Brand = brand, WarrantyPeriod = warranty });
                break;
            case 2:
                Console.Write("Enter Expiry Date (yyyy-mm-dd): ");
                DateTime expiryDate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter Weight: ");
                double weight = Convert.ToDouble(Console.ReadLine());
                groceryStorage.AddItem(new Groceries { Name = name, Id = id, Price = price, ExpiryDate = expiryDate, Weight = weight });
                break;
            case 3:
                Console.Write("Enter Material: ");
                string material = Console.ReadLine();
                Console.Write("Enter Dimensions: ");
                string dimensions = Console.ReadLine();
                furnitureStorage.AddItem(new Furniture { Name = name, Id = id, Price = price, Material = material, Dimensions = dimensions });
                break;
            default:
                Console.WriteLine("Invalid category.");
                break;
        }
    }

    private void RemoveItem()
    {
        Console.WriteLine("Select category: 1. Electronics 2. Groceries 3. Furniture");
        int category = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter ID of item to remove: ");
        int id = Convert.ToInt32(Console.ReadLine());

        switch (category)
        {
            case 1:
                electronicStorage.RemoveItem(id);
                break;
            case 2:
                groceryStorage.RemoveItem(id);
                break;
            case 3:
                furnitureStorage.RemoveItem(id);
                break;
            default:
                Console.WriteLine("Invalid category.");
                break;
        }
    }

    private void DisplayItems()
    {
        Console.WriteLine("\nElectronics:");
        electronicStorage.DisplayAllItems();
        Console.WriteLine("\nGroceries:");
        groceryStorage.DisplayAllItems();
        Console.WriteLine("\nFurniture:");
        furnitureStorage.DisplayAllItems();
    }

    public static void Main(string[] args)
    {
        WarehouseManager manager = new WarehouseManager();
        manager.UserInteraction();
    }
}
