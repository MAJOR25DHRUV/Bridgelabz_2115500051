using System;  // Importing the System namespace to use Console

public class SumNaturalNumbersFor
{
    // Method to calculate the sum of the first n natural numbers using a for loop
    public static void SumNaturalNumbers(int n)
    {
        if (n > 0)
        {
            int sum = 0;

            // For loop to iterate from 1 to n
            for (int i = 1; i <= n; i++)
            {
                sum += i;  // Add i to sum
            }
            // Output the result
            Console.WriteLine("The sum of first " + n + " natural numbers is: " + sum);
        }
        else
        {
            Console.WriteLine("Enter a positive number.");
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example input
        int n = 5;  // Replace with user input if needed
        
        // Call the method to calculate sum
        SumNaturalNumbers(n);
    }
}
