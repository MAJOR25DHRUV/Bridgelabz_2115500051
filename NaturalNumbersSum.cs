using System;  // Importing the System namespace to use Console

public class NaturalNumbersSum
{
    // Method to calculate the sum of the first n natural numbers
    public static void SumNaturalNumbers(int number)
    {
        // Check if the number is a positive integer
        if (number > 0)
        {
            // Calculate the sum using the formula n * (n + 1) / 2
            int sum = number * (number + 1) / 2;

            // Output the result to the console
            Console.WriteLine("The sum of " + number + " natural numbers is " + sum);
        }
        else
        {
            // Handle case where the number is not positive
            Console.WriteLine("The number " + number + " is not a natural number");
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Declare a number to calculate the sum of natural numbers
        int number = 5;  // Example number; replace with user input if needed

        // Call the SumNaturalNumbers method with the provided number
        SumNaturalNumbers(number);
    }
}
