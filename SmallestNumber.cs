using System;  // Importing the System namespace to use Console

public class SmallestNumber
{
    // Method to check if the first number is the smallest
    public static void CheckSmallest(int number1, int number2, int number3)
    {
        // Check if the first number is smaller than both the second and third numbers
        bool isSmallest = (number1 < number2 && number1 < number3);

        // Output the result to the console
        Console.WriteLine("Is the first number the smallest? " + isSmallest);
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Initialize three numbers
        int number1 = 5, number2 = 10, number3 = 15;

        // Call the CheckSmallest method with the three numbers
        CheckSmallest(number1, number2, number3);
    }
}
