using System;  // Importing the System namespace to use Console

public class Factorial
{
    // Method to calculate the factorial of a number
    public static void CalculateFactorial(int num)
    {
        // Check if the number is positive
        if (num >= 0)
        {
            int result = 1;

            // Use a while loop to calculate factorial
            while (num > 1)
            {
                result *= num;  // Multiply result by current num
                num--;  // Decrement num
            }
            // Output the factorial result
            Console.WriteLine("The factorial is: " + result);
        }
        else
        {
            Console.WriteLine("Please enter a non-negative integer.");
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example input
        int num = 5;  // Replace with user input if needed

        // Call the method to calculate factorial
        CalculateFactorial(num);
    }
}
