using System;  // Importing the System namespace to use Console

public class FactorialFor
{
    // Method to calculate the factorial of a number using a for loop
    public static void CalculateFactorial(int num)
    {
        // Check if the number is positive
        if (num >= 0)
        {
            int result = 1;

            // For loop to calculate factorial
            for (int i = 1; i <= num; i++)
            {
                result *= i;  // Multiply result by i
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
