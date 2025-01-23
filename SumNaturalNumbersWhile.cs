using System;  // Importing the System namespace to use Console

public class SumNaturalNumbersWhile
{
    // Method to calculate the sum of the first n natural numbers using a while loop
    public static void SumNaturalNumbers(int n)
    {
        if (n > 0)
        {
            int sum = 0;
            int i = 1;
            
            // While loop to iterate from 1 to n
            while (i <= n)
            {
                sum += i;  // Add i to sum
                i++;  // Increment i
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
        int n = 5; // Replace with user input if needed
        
        // Call the method to calculate sum
        SumNaturalNumbers(n);
    }
}
