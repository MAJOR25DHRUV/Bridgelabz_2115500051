using System;
using System.Collections.Generic;

// University class manages departments and professors
class University
{
    private string universityName;
    private List<Department> departments;
    private List<Professor> professors;

    public University(string name)
    {
        universityName = name;
        departments = new List<Department>();
        professors = new List<Professor>();
    }

    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }

    public void AddProfessor(Professor professor)
    {
        professors.Add(professor);
    }

    public void DisplayUniversityDetails()
    {
        Console.WriteLine("University: " + universityName);
        Console.WriteLine("Departments:");
        foreach (Department department in departments)
        {
            Console.WriteLine("  - " + department.GetDepartmentName());
        }
        Console.WriteLine("Professors:");
        foreach (Professor professor in professors)
        {
            Console.WriteLine("  - " + professor.GetProfessorName());
        }
    }
}

class Department
{
    private string departmentName;

    public Department(string name)
    {
        departmentName = name;
    }

    public string GetDepartmentName()
    {
        return departmentName;
    }
}

class Professor
{
    private string professorName;

    public Professor(string name)
    {
        professorName = name;
    }

    public string GetProfessorName()
    {
        return professorName;
    }
}

class Program
{
    static void Main()
    {
        University university = new University("Tech University");

        Department department1 = new Department("Computer Science");
        Department department2 = new Department("Mathematics");

        university.AddDepartment(department1);
        university.AddDepartment(department2);

        Professor professor1 = new Professor("Dr. John Watson");
        Professor professor2 = new Professor("Dr. Emily Carter");

        university.AddProfessor(professor1);
        university.AddProfessor(professor2);

        university.DisplayUniversityDetails();
    }
}
