// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee("John Doe", "E001", 50000),
            new PartTimeEmployee("Jane Smith", "E002", 25, 160)
        };

        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
            Console.WriteLine("Salary: $" + emp.CalculateSalary());
            Console.WriteLine();
        }
    }
}

// Abstract base class for all employee types
public abstract class Employee
{
    // Private fields for encapsulation
    private string employeeId;
    private string name;
    private double baseSalary;

    // Constructor to initialize employee details
    public Employee(string name, string employeeId, double baseSalary)
    {
        this.Name = name;
        this.EmployeeId = employeeId;
        this.BaseSalary = baseSalary;
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

    public string EmployeeId
    {
        get { return employeeId; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Employee ID cannot be empty");
            employeeId = value;
        }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative");
            baseSalary = value;
        }
    }

    // Abstract method for salary calculation
    public abstract double CalculateSalary();

    // Concrete method for displaying details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + EmployeeId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Base Salary: $" + BaseSalary);
    }
}

// Interface for department operations
public interface IDepartment
{
    void AssignDepartment(string departmentName);
    string GetDepartmentDetails();
}

// Full-time employee implementation
public class FullTimeEmployee : Employee, IDepartment
{
    // Private field for department
    private string department;

    // Constructor
    public FullTimeEmployee(string name, string employeeId, double baseSalary)
        : base(name, employeeId, baseSalary) { }

    // Implementation of abstract method
    public override double CalculateSalary()
    {
        return BaseSalary;
    }

    // Implementation of interface methods
    public void AssignDepartment(string departmentName)
    {
        if (string.IsNullOrEmpty(departmentName))
            throw new ArgumentException("Department name cannot be empty");
        department = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return department ?? "Not Assigned";
    }

    // Override display details to include department
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Department: " + GetDepartmentDetails());
    }
}

// Part-time employee implementation
public class PartTimeEmployee : Employee, IDepartment
{
    // Private fields
    private string department;
    private double hourlyRate;
    private int hoursWorked;

    // Constructor
    public PartTimeEmployee(string name, string employeeId, double hourlyRate, int hoursWorked)
        : base(name, employeeId, hourlyRate * hoursWorked)
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    // Implementation of abstract method
    public override double CalculateSalary()
    {
        return hourlyRate * hoursWorked;
    }

    // Implementation of interface methods
    public void AssignDepartment(string departmentName)
    {
        if (string.IsNullOrEmpty(departmentName))
            throw new ArgumentException("Department name cannot be empty");
        department = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return department ?? "Not Assigned";
    }

    // Override display details to include department and hours
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Department: " + GetDepartmentDetails());
        Console.WriteLine("Hours Worked: " + hoursWorked);
        Console.WriteLine("Hourly Rate: $" + hourlyRate);
    }
}