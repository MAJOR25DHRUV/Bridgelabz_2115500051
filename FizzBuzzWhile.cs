using System;  // Importing the System namespace to use Console

public class FizzBuzzWhile
{
    // Method to print FizzBuzz using a while loop
    public static void FizzBuzzMethod(int n)
    {
        int i = 1;  // Initialize counter

        // Loop while i is less than or equal to n
        while (i <= n)
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

            i++;  // Increment counter
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
