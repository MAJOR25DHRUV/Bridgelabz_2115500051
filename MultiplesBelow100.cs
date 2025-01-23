using System;  // Importing the System namespace to use Console

public class MultiplesBelow100
{
    // Method to find multiples of a number below 100
    public static void FindMultiples(int number)
    {
        // Loop from 100 down to 1
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)  // Check if i is a multiple of number
            {
                Console.WriteLine(i);  // Output the multiple
            }
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example input
        int number = 5;  // Replace with user input if needed

        // Call the method to find multiples
        FindMultiples(number);
    }
}
