using System;
using System.Collections.Generic;

// University class contains departments (Composition) and faculty members (Aggregation)
class University
{
    private string universityName; // Private field for university name
    private List<Department> departments; // Composition: University owns departments
    private List<Faculty> facultyMembers; // Aggregation: Faculty can exist independently

    // Constructor to initialize university
    public University(string name)
    {
        universityName = name;
        departments = new List<Department>();
        facultyMembers = new List<Faculty>();
    }

    // Method to add a department (Composition)
    public void AddDepartment(string departmentName)
    {
        departments.Add(new Department(departmentName));
    }

    // Method to add a faculty member (Aggregation)
    public void AddFaculty(Faculty faculty)
    {
        facultyMembers.Add(faculty);
    }

    // Method to display university information
    public void DisplayUniversityDetails()
    {
        Console.WriteLine("University: " + universityName);
        Console.WriteLine("Departments:");
        foreach (Department dept in departments)
        {
            Console.WriteLine("  - " + dept.GetDepartmentName());
        }
        Console.WriteLine("Faculty Members:");
        foreach (Faculty faculty in facultyMembers)
        {
            Console.WriteLine("  - " + faculty.GetFacultyName());
        }
    }
}

// Department class (Composition: Exists only inside a University)
class Department
{
    private string departmentName; // Private field for department name

    // Constructor to initialize department
    public Department(string name)
    {
        departmentName = name;
    }

    // Getter method for department name
    public string GetDepartmentName()
    {
        return departmentName;
    }
}

// Faculty class (Aggregation: Can exist independently of University)
class Faculty
{
    private string facultyName; // Private field for faculty name

    // Constructor to initialize faculty
    public Faculty(string name)
    {
        facultyName = name;
    }

    // Getter method for faculty name
    public string GetFacultyName()
    {
        return facultyName;
    }
}

class Program
{
    static void Main()
    {
        // Create a university
        University university = new University("Oxford University");

        // Add departments (Composition: Part of University)
        university.AddDepartment("Computer Science");
        university.AddDepartment("Mathematics");

        // Create faculty members (Aggregation: Independent existence)
        Faculty faculty1 = new Faculty("Dr. Smith");
        Faculty faculty2 = new Faculty("Prof. Johnson");
        
        // Add faculty members to university
        university.AddFaculty(faculty1);
        university.AddFaculty(faculty2);

        // Display university details
        university.DisplayUniversityDetails();
    }
}
