using System;  // Importing the System namespace to use Console

public class OddEvenNumbers
{
    // Method to print odd and even numbers between 1 and n
    public static void PrintOddEvenNumbers(int n)
    {
        // Check if the number is natural
        if (n > 0)
        {
            // Loop from 1 to n
            for (int i = 1; i <= n; i++)
            {
                // Check if the number is odd or even
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is even.");
                }
                else
                {
                    Console.WriteLine(i + " is odd.");
                }
            }
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
        int n = 10;  // Replace with user input if needed

        // Call the method to print odd and even numbers
        PrintOddEvenNumbers(n);
    }
}
