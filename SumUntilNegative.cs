using System;  // Importing the System namespace to use Console

public class SumUntilNegative
{
    // Method to calculate the sum of numbers until user enters 0 or a negative number
    public static void CalculateSum()
    {
        double total = 0.0;
        double input = 0.0;

        // Keep asking the user for numbers until they enter 0 or a negative number
        while (true)
        {
            input = Convert.ToDouble(Console.ReadLine());  // Get user input
            if (input <= 0)
            {
                break;  // Exit the loop if input is 0 or negative
            }
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
