using System;  // Importing the System namespace

public class HarshadNumber
{
    // Method to check if the number is a Harshad number
    public static void CheckHarshad(int number)
    {
        int sum = 0;  // Variable to store sum of digits
        int originalNumber = number;  // Store the original number
        
        // Loop to access each digit of the number
        while (number != 0)
        {
            sum += number % 10;  // Add the last digit to sum
            number /= 10;  // Remove the last digit
        }

        // Check if the original number is divisible by the sum of digits
        if (originalNumber % sum == 0)
            Console.WriteLine("The number is a Harshad number.");
        else
            Console.WriteLine("The number is not a Harshad number.");
    }

    // Main method
    public static void Main(string[] args)
    {
        int number = 21;  // Example number (can replace with user input)
        CheckHarshad(number);  // Calling method to check Harshad number
    }
}
