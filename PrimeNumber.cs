using System;  // Importing the System namespace to use Console

public class PrimeNumber
{
    // Method to check if the number is prime
    public static void CheckPrime(int number)
    {
        // Prime number must be greater than 1
        if (number <= 1)
        {
            Console.WriteLine(number + " is not a prime number.");
            return;  // Exit method if number is less than or equal to 1
        }

        bool isPrime = true;  // Boolean variable to check primality

        // Loop to check divisibility from 2 to number - 1
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)  // Check if number is divisible by i
            {
                isPrime = false;  // Set isPrime to false if divisible
                break;  // Exit loop as we found a divisor
            }
        }

        // Output the result based on isPrime value
        if (isPrime)
            Console.WriteLine(number + " is a prime number.");
        else
            Console.WriteLine(number + " is not a prime number.");
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example input
        int number = 29;  // Replace with user input if needed

        // Call the method to check prime
        CheckPrime(number);
    }
}
