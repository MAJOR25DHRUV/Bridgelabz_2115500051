using System;  // Importing the System namespace

public class AbundantNumber
{
    // Method to check if the number is an Abundant number
    public static void CheckAbundant(int number)
    {
        int sum = 0;  // Variable to store sum of divisors
        
        // Loop to find divisors of the number
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)  // If i is a divisor
                sum += i;  // Add to sum of divisors
        }

        // Check if sum of divisors is greater than the number
        if (sum > number)
            Console.WriteLine("The number is an Abundant number.");
        else
            Console.WriteLine("The number is not an Abundant number.");
    }

    // Main method
    public static void Main(string[] args)
    {
        int number = 12;  // Example number (can replace with user input)
        CheckAbundant(number);  // Calling method to check Abundant number
    }
}
