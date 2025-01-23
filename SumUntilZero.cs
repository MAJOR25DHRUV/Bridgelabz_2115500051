using System;  // Importing the System namespace to use Console

public class SumUntilZero
{
    // Method to calculate the sum of numbers until user inputs 0
    public static void CalculateSum()
    {
        double total = 0.0;
        double input = 0.0;

        // Keep asking the user for numbers until they enter 0
        while (input != 0)
        {
            input = Convert.ToDouble(Console.ReadLine());  // Get user input
            total += input;  // Add the input to the total
        }

        // Output the result to the console
        Console.WriteLine("The total sum is: " + total);
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Call the CalculateSum method
        CalculateSum();
    }
}
