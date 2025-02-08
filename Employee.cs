using System;

// Base class representing a general Employee
class Employee
{
    public string Name { get; set; }  // Stores the employee's name
    public int Id { get; set; }  // Stores the employee's ID
    public double Salary { get; set; }  // Stores the employee's salary

    // Virtual method to display employee details (to be overridden in subclasses)
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Employee: {Name}, ID: {Id}, Salary: {Salary}");
    }
}

// Manager class inherits from Employee
class Manager : Employee
{
    public int TeamSize { get; set; }  // Stores the number of employees under the manager

    // Overriding method to provide specific details for Manager
    public override void DisplayDetails()
    {
        Console.WriteLine($"Manager: {Name}, ID: {Id}, Salary: {Salary}, Team Size: {TeamSize}");
    }
}

// Developer class inherits from Employee
class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }  // Stores the programming language the developer specializes in

    // Overriding method to provide specific details for Developer
    public override void DisplayDetails()
    {
        Console.WriteLine($"Developer: {Name}, ID: {Id}, Salary: {Salary}, Language: {ProgrammingLanguage}");
    }
}

// Intern class inherits from Employee
class Intern : Employee
{
    public string InternshipDuration { get; set; }  // Stores the duration of the internship

    // Overriding method to provide specific details for Intern
    public override void DisplayDetails()
    {
        Console.WriteLine($"Intern: {Name}, ID: {Id}, Stipend: {Salary}, Duration: {InternshipDuration}");
    }
}

// Main program to test the classes
class Program
{
    static void Main()
    {
        // Creating instances of different employee types
        Employee[] employees = {
            new Manager { Name = "Alice", Id = 101, Salary = 75000, TeamSize = 10 },
            new Developer { Name = "Bob", Id = 102, Salary = 65000, ProgrammingLanguage = "C#" },
            new Intern { Name = "Charlie", Id = 103, Salary = 20000, InternshipDuration = "6 months" }
        };

        // Loop through each employee and display their details
        foreach (var employee in employees)
        {
            employee.DisplayDetails();
            Console.WriteLine();
        }
    }
}
