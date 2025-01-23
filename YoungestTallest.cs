using System;  // Importing the System namespace to use Console

public class YoungestTallest
{
    // Method to find the youngest and tallest friend
    public static void FindYoungestTallest(int age1, int age2, int age3, double height1, double height2, double height3)
    {
        // Find the youngest friend by checking the minimum age
        int youngestAge = Math.Min(age1, Math.Min(age2, age3));
        Console.WriteLine("The youngest friend is " + youngestAge + " years old.");

        // Find the tallest friend by checking the maximum height
        double tallestHeight = Math.Max(height1, Math.Max(height2, height3));
        Console.WriteLine("The tallest friend is " + tallestHeight + " cm tall.");
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example inputs
        int age1 = 25, age2 = 23, age3 = 30;  // Replace with user input if needed
        double height1 = 170, height2 = 180, height3 = 175;  // Replace with user input if needed

        // Call the method to find the youngest and tallest friend
        FindYoungestTallest(age1, age2, age3, height1, height2, height3);
    }
}
