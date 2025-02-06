using System;
using System.Collections.Generic;

// School class contains students (Aggregation)
class School
{
    private string schoolName; // Private field for school name
    private List<Student> students; // Aggregation: School has a list of students

    // Constructor to initialize school name and student list
    public School(string name)
    {
        schoolName = name;
        students = new List<Student>();
    }

    // Method to add a student to the school
    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    // Method to display all students in the school
    public void DisplayStudents()
    {
        Console.WriteLine("School: " + schoolName);
        foreach (Student student in students)
        {
            Console.WriteLine("  Student: " + student.GetStudentName());
        }
    }
}

// Student class (Association with Course: Many-to-Many)
class Student
{
    private string studentName; // Private field for student name
    private List<Course> enrolledCourses; // List of courses the student is enrolled in

    // Constructor to initialize student name and courses
    public Student(string name)
    {
        studentName = name;
        enrolledCourses = new List<Course>();
    }

    // Getter method for student name
    public string GetStudentName()
    {
        return studentName;
    }

    // Method to enroll in a course
    public void EnrollCourse(Course course)
    {
        enrolledCourses.Add(course);
        course.AddStudent(this); // Ensure association in both directions
    }

    // Method to display enrolled courses
    public void ViewCourses()
    {
        Console.WriteLine("Student: " + studentName + " is enrolled in:");
        foreach (Course course in enrolledCourses)
        {
            Console.WriteLine("  Course: " + course.GetCourseName());
        }
    }
}

// Course class (Association with Student: Many-to-Many)
class Course
{
    private string courseName; // Private field for course name
    private List<Student> enrolledStudents; // List of students enrolled in this course

    // Constructor to initialize course name and students list
    public Course(string name)
    {
        courseName = name;
        enrolledStudents = new List<Student>();
    }

    // Getter method for course name
    public string GetCourseName()
    {
        return courseName;
    }

    // Method to add a student to this course
    public void AddStudent(Student student)
    {
        if (!enrolledStudents.Contains(student)) // Prevent duplicate entries
        {
            enrolledStudents.Add(student);
        }
    }

    // Method to display students enrolled in this course
    public void ViewStudents()
    {
        Console.WriteLine("Course: " + courseName + " has students:");
        foreach (Student student in enrolledStudents)
        {
            Console.WriteLine("  Student: " + student.GetStudentName());
        }
    }
}

class Program
{
    static void Main()
    {
        // Create a school
        School school = new School("Greenwood High School");

        // Create students
        Student student1 = new Student("Alice");
        Student student2 = new Student("Bob");
        
        // Add students to the school
        school.AddStudent(student1);
        school.AddStudent(student2);

        // Create courses
        Course math = new Course("Mathematics");
        Course science = new Course("Science");

        // Students enroll in courses
        student1.EnrollCourse(math);
        student1.EnrollCourse(science);
        student2.EnrollCourse(math);

        // Display school students
        school.DisplayStudents();

        // Display student course enrollments
        student1.ViewCourses();
        student2.ViewCourses();

        // Display students in a course
        math.ViewStudents();
        science.ViewStudents();
    }
}
