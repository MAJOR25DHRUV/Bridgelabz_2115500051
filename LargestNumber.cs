using System;  // Importing the System namespace to use Console

public class LargestNumber
{
    // Method to check which number is the largest among the three
    public static void CheckLargest(int number1, int number2, int number3)
    {
        // Check if the first number is the largest
        Console.WriteLine("Is the first number the largest? " + (number1 > number2 && number1 > number3));

        // Check if the second number is the largest
        Console.WriteLine("Is the second number the largest? " + (number2 > number1 && number2 > number3));

        // Check if the third number is the largest
        Console.WriteLine("Is the third number the largest? " + (number3 > number1 && number3 > number2));
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Initialize three numbers
        int number1 = 5, number2 = 10, number3 = 15;

        // Call the CheckLargest method with the three numbers
        CheckLargest(number1, number2, number3);
    }
}
