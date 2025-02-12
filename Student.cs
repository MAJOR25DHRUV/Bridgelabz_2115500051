using System;

// Define a node for the linked list containing student details
class StudentNode
{
    // Student attributes
    public string Name;
    public int Age;
    public int RollNo;
    public char Grade;
    public StudentNode next; // Pointer to the next node in the linked list
    
    // Constructor to initialize the student node
    public StudentNode(string Name, int Age, int RollNo, char Grade){
        this.Name = Name;
        this.Age = Age;
        this.RollNo = RollNo;
        this.Grade = Grade;
        next = null;
    }
}

// Define the linked list class to manage student nodes
class Student
{
    private StudentNode head; // Head node of the linked list
    
    // Constructor to initialize an empty student list
    public Student()
    {
        head = null;
    }
    
    // Method to insert a student at the beginning of the list
    public void InsertStudentBeginning(string Name, int Age, int RollNo, char Grade)
    {
        StudentNode newStudent = new StudentNode(Name, Age, RollNo, Grade);
        newStudent.next = head;
        head = newStudent;
    }
    
    // Method to delete a student based on roll number
    public void DeleteStudent(int RollNo){
        
        // Check if the list is empty
        if(head == null)
        {
            return;
        }
        // Check if the head node is the one to be deleted
        if(head.RollNo == RollNo)
        {
            head = head.next;
            Console.WriteLine("Student with Roll No " + RollNo + " deleted.");
            return;
        }
        
        StudentNode temp = head;
        StudentNode previous = null;
        
        // Traverse the list to find the node to delete
        while(temp != null && temp.RollNo != RollNo)
        {
            previous = temp;
            temp = temp.next;
        }
        
        // If roll number is not found
        if(temp == null)
        {
            Console.WriteLine("Student not found");
            return;
        }
        
        // Remove the student from the list
        previous.next = temp.next;
        Console.WriteLine("Student with Roll No " + RollNo + " deleted.");
    }
    
    // Method to search for a student by roll number
    public StudentNode Search(int RollNo)
    {
        StudentNode temp = head;

        // Traverse the list and return the student node if found
        while (temp != null)
        {
            if (temp.RollNo == RollNo)
            {
                return temp; 
            }
            temp = temp.next;
        }
        return null; 
    }

    // Method to update a student's grade by roll number
    public void UpdateGrade(int RollNo, char Grade)
    {
        StudentNode temp = head;
        
        // Traverse the list to find the student and update the grade
        while(temp != null)
        {
            if(temp.RollNo == RollNo)
            {
                temp.Grade = Grade;
                Console.WriteLine("The Grades of " + temp.Name + " have been updated to " + Grade + "." );
                return;
            }
            temp = temp.next;
        }
        
        // If student not found
        Console.WriteLine("Student not found");
    }
    
    // Method to display the list of students
    public void Display()
    {
        StudentNode temp = head;
        
        // Traverse the list and print student details
        while(temp != null)
        {
            Console.WriteLine("RollNo: " + temp.RollNo + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Grade: " + temp.Grade);
            temp = temp.next;
        }
    }
    
    public static void Main()
    {
        // Create an instance of the Student class
        Student student = new Student();
        
        // Insert students into the linked list
        student.InsertStudentBeginning("Arihant", 20, 8, 'A');
        student.InsertStudentBeginning("Dhruv", 21, 20, 'F');
        
        // Display the list of students
        student.Display();
        
        // Prompt user to update a student's grade
        Console.WriteLine("Enter the roll number you want to update the grade of: ");
        int rollGrade = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Grade you want to update to: ");
        char grade = char.Parse(Console.ReadLine());
        student.UpdateGrade(rollGrade, grade);
        
        // Display updated student list
        student.Display();
        
        // Prompt user to search for a student
        Console.WriteLine("Enter the roll number you want to search: ");
        int rollSearch = int.Parse(Console.ReadLine());
        StudentNode foundStudent = student.Search(rollSearch);

        // Display search results
        if (foundStudent != null)
        {
            Console.WriteLine("Student Found - RollNo: " + foundStudent.RollNo + 
                            ", Name: " + foundStudent.Name + 
                            ", Age: " + foundStudent.Age + 
                            ", Grade: " + foundStudent.Grade);
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
        
        // Prompt user to delete a student
        Console.WriteLine("Enter the roll number you want to delete: ");
        int rollNo = int.Parse(Console.ReadLine());
        student.DeleteStudent(rollNo);
        
        // Display the updated list after deletion
        student.Display();
    }
}