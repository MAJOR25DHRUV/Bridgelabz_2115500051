using System;  // Importing the System namespace to use Console

public class BMI
{
    // Method to calculate BMI and determine weight status
    public static void CalculateBMI(double weight, double height)
    {
        // Convert height from cm to meters
        height = height / 100;

        // Calculate BMI
        double bmi = weight / (height * height);

        // Output BMI value
        Console.WriteLine("Your BMI is: " + bmi);

        // Determine weight status based on the BMI value
        if (bmi < 18.5)
            Console.WriteLine("You are underweight.");
        else if (bmi >= 18.5 && bmi <= 24.9)
            Console.WriteLine("You have a normal weight.");
        else if (bmi >= 25 && bmi <= 29.9)
            Console.WriteLine("You are overweight.");
        else if (bmi >= 30 && bmi <= 39.9)
            Console.WriteLine("You are obese.");
        else if (bmi >= 40)
            Console.WriteLine("You are severely obese.");
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example inputs
        double weight = 70;  // Replace with user input if needed
        double height = 175;  // Replace with user input if needed

        // Call the method to calculate BMI
        CalculateBMI(weight, height);
    }
}
