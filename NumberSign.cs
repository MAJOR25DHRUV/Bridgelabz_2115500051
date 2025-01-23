using System;  // Importing the System namespace to use Console

public class NumberSign
{
    // Method to check if a number is positive, negative, or zero
    public static void CheckNumberSign(int number)
    {
        // Check if the number is positive
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        // Check if the number is negative
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        // Check if the number is zero
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Declare a number variable and initialize it
        int number = -5;  // Example number; replace with user input if needed

        // Call the CheckNumberSign method with the provided number
        CheckNumberSign(number);
    }
}
