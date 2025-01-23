using System;  // Importing the System namespace to use Console

public class FizzBuzz
{
    // Method to print FizzBuzz for numbers from 0 to n
    public static void FizzBuzzMethod(int n)
    {
        // Loop through numbers from 0 to n
        for (int i = 1; i <= n; i++)
        {
            // Check divisibility conditions for Fizz, Buzz, and FizzBuzz
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");  // Divisible by both 3 and 5
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");  // Divisible by 3
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");  // Divisible by 5
            else
                Console.WriteLine(i);  // Print the number
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example input
        int n = 15;  // Replace with user input if needed

        // Call the method to execute FizzBuzz
        FizzBuzzMethod(n);
    }
}
