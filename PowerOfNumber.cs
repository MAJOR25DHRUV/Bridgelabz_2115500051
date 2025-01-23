using System;  // Importing the System namespace to use Console

public class PowerOfNumber
{
    // Method to calculate the power of a number
    public static void FindPower(int number, int power)
    {
        int result = 1;  // Initialize result to 1

        // Loop to calculate number raised to the power
        for (int i = 1; i <= power; i++)
        {
            result *= number;  // Multiply result by the number
        }

        // Output the result
        Console.WriteLine(number + " raised to the power of " + power + " is: " + result);
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example inputs
        int number = 2, power = 3;  // Replace with user input if needed

        // Call the method to calculate the power
        FindPower(number, power);
    }
}
