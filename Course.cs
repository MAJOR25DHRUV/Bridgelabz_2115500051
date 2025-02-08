using System;

// Base class representing a general Course
class Course
{
    public string CourseName { get; set; }  // Stores the course name
    public int Duration { get; set; }  // Stores course duration in weeks

    // Method to display course details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks");
    }
}

// OnlineCourse class inherits from Course
class OnlineCourse : Course
{
    public string Platform { get; set; }  // Stores the platform name
    public bool IsRecorded { get; set; }  // Stores whether the course is recorded

    // Overriding DisplayDetails() to include OnlineCourse details
    public override void DisplayDetails()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks, Platform: {Platform}, Recorded: {IsRecorded}");
    }
}

// PaidOnlineCourse class inherits from OnlineCourse
class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }  // Stores the course fee
    public double Discount { get; set; }  // Stores the discount on the fee

    // Overriding DisplayDetails() to include PaidOnlineCourse details
    public override void DisplayDetails()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks, Platform: {Platform}, Fee: ${Fee}, Discount: {Discount}%");
    }
}

// Main program to test the classes
class Program
{
    static void Main()
    {
        // Creating an instance of PaidOnlineCourse
        PaidOnlineCourse course = new PaidOnlineCourse
        {
            CourseName = "AI & ML Fundamentals",
            Duration = 10,
            Platform = "Coursera",
            IsRecorded = true,
            Fee = 199.99,
            Discount = 20.0
        };

        // Displaying course details
        course.DisplayDetails();
    }
}
