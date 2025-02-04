using System;

class Employee
{
    // Static variable holding the company name shared by all employees
    static string CompanyName = "Stark Industries"; 
    
    // Instance variables for Name, Id, and Designation
    public string Name;
    public int Id; 
    public string Designation;
    
    // Static variable to keep track of the total number of employees
    private static int totalEmployees = 0;

    // Constructor to initialize Name, Id, and Designation using 'this' keyword
    public Employee(int Id, string Name, string Designation)
    {
        // Initializing instance variables using the constructor parameters
        this.Id = Id;
        this.Name = Name;
        this.Designation = Designation;
        
        // Incrementing the total number of employees whenever a new employee is created
        totalEmployees++;
    }

    // Static method to display the total number of employees
    public static void DisplayTotalEmployees()
    {
        // Printing the total number of employees
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    // Static method to display the company name
    public static void DisplayCompanyName()
    {
        // Printing the company name
        Console.WriteLine("Company Name: " + CompanyName);
    }

    // Instance method to display employee details
    public void DisplayDetails()
    {
        // Checking if 'this' object is an instance of the Employee class using 'is' operator
        if (this is Employee)
        {
            // Printing the employee's details
            Console.WriteLine("Employee Id: " + Id);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Designation: " + Designation);
        }
    }

    static void Main(string[] args)
    {
        // Creating two employee objects with different details
        Employee emp1 = new Employee(1, "Dhruv", "SDE3");
        Employee emp2 = new Employee(2, "Arihant", "SDE1");

        // Displaying the company name using the static method
        Employee.DisplayCompanyName();

        // Displaying details of the first employee
        emp1.DisplayDetails();
        
        // Displaying details of the second employee
        emp2.DisplayDetails();
        
        // Displaying the total number of employees using the static method
        Employee.DisplayTotalEmployees();
    }
}
