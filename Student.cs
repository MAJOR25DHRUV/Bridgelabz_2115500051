using System;

class Student
{
    // Static variable shared by all students to store the university name
    static string UniversityName = "Global University"; 
    
    // Instance variables for Name, RollNumber, and Grade
    public string Name;
    
    // Readonly variable for RollNumber to ensure it is unique and cannot be changed once assigned
    public readonly int RollNumber;
    
    public string Grade;

    // Static variable to keep track of the total number of students enrolled
    private static int totalStudents = 0;

    // Static method to display the total number of students enrolled
    public static void DisplayTotalStudents()
    {
        // Printing the total number of students enrolled
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }

    // Constructor to initialize Name, RollNumber, and Grade using 'this' keyword
    public Student(int rollNumber, string name, string grade)
    {
        // Initializing instance variables using constructor parameters
        this.RollNumber = rollNumber;
        this.Name = name;
        this.Grade = grade;
        
        // Incrementing the total number of students whenever a new student is created
        totalStudents++;
    }

    // Instance method to display student details
    public void DisplayDetails()
    {
        // Checking if the current object is an instance of the Student class using 'is' operator
        if (this is Student)
        {
			Console.WriteLine("University Name: " + UniversityName);
            // Printing student details including the RollNumber, Name, and Grade
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Grade: " + Grade);
        }
    }

    // Instance method to update student's grade, only if the object is an instance of Student class
    public void UpdateGrade(string newGrade)
    {
        // Checking if the current object is an instance of the Student class using 'is' operator
        if (this is Student)
        {
            // Updating the student's grade
            Grade = newGrade;
            Console.WriteLine("Grade updated to: " + Grade);
        }
    }

    static void Main(string[] args)
    {
        // Creating student objects
        Student student1 = new Student(101, "Alice", "A");
        Student student2 = new Student(102, "Bob", "B");
        
		
        // Displaying details of the students
        student1.DisplayDetails();
        student2.DisplayDetails();

        // Displaying the total number of students enrolled
        Student.DisplayTotalStudents();

        // Updating grade for student1
        student1.UpdateGrade("A+");
        
        // Displaying updated details of student1
        student1.DisplayDetails();
    }
}
