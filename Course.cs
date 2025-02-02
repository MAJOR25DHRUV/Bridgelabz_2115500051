
using System;

class Course
{
    private string courseName;
    private int duration; // Duration in weeks
    private double fee;
    private static string instituteName = "Default Institute"; // Class Variable

    // Constructor
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Course: {courseName}, Duration: {duration} weeks, Fee: {fee}, Institute: {instituteName}");
    }

    // Class method to update the institute name
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
        Console.WriteLine($"Institute name updated to: {instituteName}");
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Course.UpdateInstituteName("Global Tech Academy");

        Course course1 = new Course("AI & ML", 12, 5000);
        Course course2 = new Course("Web Development", 10, 4000);

        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}

