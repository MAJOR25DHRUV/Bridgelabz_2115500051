using System;

class Student
{
    public int RollNumber { get; set; }
    protected string Name { get; set; }
    private double CGPA;

    public Student(int rollNumber, string name, double cgpa)
    {
        RollNumber = rollNumber;
        Name = name;
        CGPA = cgpa;
    }

    public void SetCGPA(double cgpa)
    {
        CGPA = cgpa;
    }

    public double GetCGPA()
    {
        return CGPA;
    }
}

class PostgraduateStudent : Student
{
    public PostgraduateStudent(int rollNumber, string name, double cgpa)
        : base(rollNumber, name, cgpa) { }

    public void Display()
    {
        Console.WriteLine($"Postgraduate Student: Roll No: {RollNumber}, Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student(101, "Alice", 3.8);
        student.SetCGPA(4.0);
        Console.WriteLine($"Updated CGPA: {student.GetCGPA()}");

        PostgraduateStudent pgStudent = new PostgraduateStudent(102, "Bob", 3.9);
        pgStudent.Display();
    }
}