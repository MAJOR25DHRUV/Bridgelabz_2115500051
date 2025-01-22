using System; 

class Pen // Declaring the class for pen distribution
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        int totalPens = 14; // Total pens available
        int students = 3; // Total students
        DistributePens(totalPens, students); // Calling the method to calculate pen distribution
    }

    // Method to calculate and display pens per student and remaining pens
    static void DistributePens(int totalPens, int students)
    {
        int pensPerStudent = totalPens / students; // Calculating pens each student will get
        int remainingPens = totalPens % students; // Calculating the remaining pens
        // Displaying the result
        Console.WriteLine("The Pen Per Student is "+pensPerStudent +" and the remaining pen not distributed is "+remainingPens);
    }
}
