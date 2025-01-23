using System;  // Importing the System namespace

public class CountDigits
{
    // Method to count digits in an integer
    public static void CountNumberOfDigits(int number)
    {
        int count = 0;  // Variable to store count of digits
        
        // Loop until the number becomes 0
        while (number != 0)
        {
            number /= 10;  // Remove the last digit
            count++;  // Increase the count
        }

        // Output the number of digits
        Console.WriteLine("The number has " + count + " digits.");
    }

    // Main method
    public static void Main(string[] args)
    {
        int number = 12345;  // Example number (can replace with user input)
        CountNumberOfDigits(number);  // Calling method to count digits
    }
}
