using System;

// Base class representing a Person
class Persons
{
    public string Name { get; set; }  // Stores the person's name
    public int Id { get; set; }  // Stores the person's ID
}

// Defining an interface Worker
interface Worker
{
    void PerformDuties();  // Abstract method to be implemented by subclasses
}

// Chef class inherits from Person and implements Worker interface
class Chef : Person, Worker
{
    public string Specialty { get; set; }  // Stores the chef's specialty

    // Implementing the interface method
    public void PerformDuties()
    {
        Console.WriteLine($"Chef {Name} specializes in {Specialty} dishes.");
    }
}

// Waiter class inherits from Person and implements Worker interface
class Waiter : Person, Worker
{
    public int TablesAssigned { get; set; }  // Stores the number of tables assigned

    // Implementing the interface method
    public void PerformDuties()
    {
        Console.WriteLine($"Waiter {Name} is serving {TablesAssigned} tables.");
    }
}

// Main program to test the classes
class Program
{
    static void Main()
    {
        // Creating instances of Chef and Waiter
        Chef chef = new Chef { Name = "John", Id = 101, Specialty = "Italian" };
        Waiter waiter = new Waiter { Name = "Emily", Id = 202, TablesAssigned = 5 };

        // Performing duties
        chef.PerformDuties();
        waiter.PerformDuties();
    }
}
