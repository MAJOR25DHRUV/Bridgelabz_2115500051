using System;  // Importing the System namespace to use Console

public class MultiplicationTable
{
    // Method to print multiplication table from 6 to 9 for a given number
    public static void PrintMultiplicationTable(int number)
    {
        // Loop through numbers from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            // Multiply and display the result
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example input
        int number = 5;  // Replace with user input if needed

        // Call the method to print the multiplication table
        PrintMultiplicationTable(number);
    }
}
