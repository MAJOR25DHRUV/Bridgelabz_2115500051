using System;

public class NumberReversal
{
    public static void ReverseNumber()
    {
        // Input number from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is negative
        bool isNegative = number < 0;

        // Work with the absolute value of the number
        number = Math.Abs(number);

        // Variable to store the reversed number
        int reversedNumber = 0;

        // Reverse the digits of the number
        while (number > 0)
        {
            // Extract the last digit
            int lastDigit = number % 10;

            // Add the digit to the reversed number
            reversedNumber = reversedNumber * 10 + lastDigit;

            // Remove the last digit from the number
            number /= 10;
        }

        // Add the negative sign back if the original number was negative
        if (isNegative)
        {
            reversedNumber = -reversedNumber;
        }

        // Display the reversed number
        Console.WriteLine("Reversed number: " + reversedNumber);
    }

    public static void Main()
    {
        ReverseNumber();
    }
}
