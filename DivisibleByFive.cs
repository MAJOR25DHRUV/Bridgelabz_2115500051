using System;  // Importing the System namespace to use Console

public class DivisibleByFive
{
    // Method to check if the number is divisible by 5
    public static void CheckDivisibility(int number)
    {
        // Check if the number is divisible by 5 using modulus operator (%)
        bool isDivisibleByFive = (number % 5 == 0);

        // Output the result to the console
        Console.WriteLine("Is the number " + number + " divisible by 5? " + isDivisibleByFive);
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Declare an integer variable 'number' and initialize it with a value
        int number = 25;  // Example number, can be changed to user input

        // Call the CheckDivisibility method with the provided number
        CheckDivisibility(number);
    }
}
