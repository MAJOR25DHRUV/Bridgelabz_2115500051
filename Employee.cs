
using System;

class Employee
{
    public int EmployeeID { get; set; }
    protected string Department { get; set; }
    private double Salary;

    public Employee(int employeeID, string department, double salary)
    {
        EmployeeID = employeeID;
        Department = department;
        Salary = salary;
    }

    public void SetSalary(double salary)
    {
        Salary = salary;
    }

    public double GetSalary()
    {
        return Salary;
    }
}

class Manager : Employee
{
    public Manager(int employeeID, string department, double salary) : base(employeeID, department, salary) { }

    public void Display()
    {
        Console.WriteLine($"Manager: ID: {EmployeeID}, Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee(101, "IT", 60000);
        emp.SetSalary(65000);
        Console.WriteLine($"Updated Salary: {emp.GetSalary()}");

        Manager mgr = new Manager(201, "HR", 80000);
        mgr.Display();
    }
}

