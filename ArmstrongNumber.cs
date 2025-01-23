using System;  // Importing the System namespace

public class ArmstrongNumber
{
    // Method to check if the number is Armstrong or not
    public static void CheckArmstrong(int number)
    {
        int sum = 0;  // Variable to store the sum of cubes of digits
        int originalNumber = number;  // Variable to store the original number
        
        // Loop until the original number is 0
        while (number != 0)
        {
            int digit = number % 10;  // Get the last digit
            sum += digit * digit * digit;  // Cube the digit and add to sum
            number /= 10;  // Remove the last digit from the number
        }

        // Check if the sum of cubes is equal to the original number
        if (sum == originalNumber)
            Console.WriteLine("The number is an Armstrong number.");
        else
            Console.WriteLine("The number is not an Armstrong number.");
    }

    // Main method
    public static void Main(string[] args)
    {
        int number = 153;  // Example number (can replace with user input)
        CheckArmstrong(number);  // Calling method to check Armstrong
    }
}
