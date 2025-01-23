using System;  // Importing the System namespace to use Console

public class Factors
{
    // Method to find the factors of a number
    public static void FindFactors(int number)
    {
        // Loop through numbers from 1 to number - 1
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)  // Check if i is a factor of number
            {
                Console.WriteLine(i);  // Output the factor
            }
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example input
        int number = 20;  // Replace with user input if needed

        // Call the method to find the factors
        FindFactors(number);
    }
}
