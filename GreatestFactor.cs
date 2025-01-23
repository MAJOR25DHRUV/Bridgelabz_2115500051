using System;  // Importing the System namespace to use Console

public class GreatestFactor
{
    // Method to find the greatest factor of a number
    public static void FindGreatestFactor(int number)
    {
        int greatestFactor = 1;  // Initialize the greatest factor to 1

        // Loop from number - 1 down to 1
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)  // Check if i is a factor of number
            {
                greatestFactor = i;  // Assign the greatest factor
                break;  // Exit loop as we found the greatest factor
            }
        }

        // Output the greatest factor
        Console.WriteLine("The greatest factor of " + number + " (besides itself) is: " + greatestFactor);
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example input
        int number = 28;  // Replace with user input if needed

        // Call the method to find the greatest factor
        FindGreatestFactor(number);
    }
}
