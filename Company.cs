using System;
using System.Collections.Generic;

class Company
{
    private string companyName; // Private field for company name
    private List<Department> departments; // Private list to store departments

    // Constructor to initialize company name and departments list
    public Company(string name)
    {
        companyName = name;
        departments = new List<Department>(); // Initializes the list of departments
    }

    // Getter method to access the company name
    public string GetCompanyName()
    {
        return companyName;
    }

    // Method to add a department to the company
    public void AddDepartment(string departmentName)
    {
        Department department = new Department(departmentName);
        departments.Add(department); // Add department to the company's list
    }

    // Getter method to access the departments list
    public List<Department> GetDepartments()
    {
        return departments; // Return the list of departments
    }

    // Method to display all departments and their employees
    public void DisplayDepartments()
    {
        Console.WriteLine("Company: " + companyName);
        foreach (Department department in departments)
        {
            department.DisplayEmployees(); // Display employees of each department
        }
    }

    // Destructor to ensure that when the company is deleted, all departments and employees are also deleted
    ~Company()
    {
        Console.WriteLine("Company and all its departments are being deleted.");
    }
}

class Department
{
    private string departmentName; // Private field for department name
    private List<Employee> employees; // Private list to store employees in the department

    // Constructor to initialize department name and employee list
    public Department(string name)
    {
        departmentName = name;
        employees = new List<Employee>(); // Initializes the employee list
    }

    // Getter method to access department name
    public string GetDepartmentName()
    {
        return departmentName;
    }

    // Method to add an employee to the department
    public void AddEmployee(string employeeName, string role)
    {
        Employee employee = new Employee(employeeName, role);
        employees.Add(employee); // Add employee to the department's employee list
    }

    // Method to display all employees in the department
    public void DisplayEmployees()
    {
        Console.WriteLine("  Department: " + departmentName);
        foreach (Employee employee in employees)
        {
            Console.WriteLine("    Employee: " + employee.GetEmployeeName() + ", Role: " + employee.GetRole());
        }
    }

    // Destructor to ensure when department is deleted, its employees are also deleted
    ~Department()
    {
        Console.WriteLine("Department and its employees are being deleted.");
    }
}

class Employee
{
    private string employeeName; // Private field for employee name
    private string role; // Private field for employee's role

    // Constructor to initialize employee name and role
    public Employee(string name, string role)
    {
        employeeName = name;
        this.role = role;
    }

    // Getter method to access employee's name
    public string GetEmployeeName()
    {
        return employeeName;
    }

    // Getter method to access employee's role
    public string GetRole()
    {
        return role;
    }

    // Destructor to delete the employee (this will be invoked when the department is deleted)
    ~Employee()
    {
        Console.WriteLine("Employee " + employeeName + " is being deleted.");
    }
}

class Program
{
    static void Main()
    {
        // Create a company
        Company company = new Company("Tech Innovators");

        // Add departments to the company
        company.AddDepartment("Engineering");
        company.AddDepartment("HR");

        // Add employees to Engineering department
        company.DisplayDepartments(); // Initially no employees

        // Add employees to departments
        foreach (var department in company.GetDepartments()) // Now we can access departments
        {
            if (department.GetDepartmentName() == "Engineering")
            {
                department.AddEmployee("Alice", "Software Engineer");
                department.AddEmployee("Bob", "Senior Developer");
            }
            else if (department.GetDepartmentName() == "HR")
            {
                department.AddEmployee("Charlie", "HR Manager");
            }
        }

        // Display departments and employees after adding them
        company.DisplayDepartments();

        // Simulate the deletion of the company (garbage collection)
        company = null;

        // Force garbage collection to call destructors and show deletion messages
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
