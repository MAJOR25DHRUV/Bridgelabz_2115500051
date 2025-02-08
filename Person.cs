using System;

// Base class representing a general Person
class Person
{
    public string Name { get; set; }  // Stores the person's name
    public int Age { get; set; }  // Stores the person's age

    // Method to display role
    public virtual void DisplayRole()
    {
        Console.WriteLine("This is a generic person.");
    }
}

// Teacher class inherits from Person
class Teacher : Person
{
    public string Subject { get; set; }  // Stores the subject taught

    // Overriding DisplayRole() to specify Teacher role
    public override void DisplayRole()
    {
        Console.WriteLine($"Teacher: {Name}, Subject: {Subject}");
    }
}

// Student class inherits from Person
class Student : Person
{
    public string Grade { get; set; }  // Stores the student's grade

    // Overriding DisplayRole() to specify Student role
    public override void DisplayRole()
    {
        Console.WriteLine($"Student: {Name}, Grade: {Grade}");
    }
}

// Staff class inherits from Person
class Staff : Person
{
    public string Department { get; set; }  // Stores the department name

    // Overriding DisplayRole() to specify Staff role
    public override void DisplayRole()
    {
        Console.WriteLine($"Staff: {Name}, Department: {Department}");
    }
}

// Main program to test the classes
class Program
{
    static void Main()
    {
        // Creating instances of different roles
        Teacher teacher = new Teacher { Name = "Alice", Age = 35, Subject = "Mathematics" };
        Student student = new Student { Name = "Bob", Age = 16, Grade = "10th" };
        Staff staff = new Staff { Name = "Charlie", Age = 40, Department = "Administration" };

        // Displaying roles
        teacher.DisplayRole();
        student.DisplayRole();
        staff.DisplayRole();
    }
}
