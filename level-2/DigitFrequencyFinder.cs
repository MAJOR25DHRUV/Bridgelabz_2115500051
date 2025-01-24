using System;

public class DigitFrequencyFinder
{
    public static void FindDigitFrequency()
    {
        // Input number from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Create frequency array
        int[] digitFrequency = new int[10];

        // Extract digits
        int tempNumber = number;
        while (tempNumber > 0)
        {
            // Get last digit
            int digit = tempNumber % 10;
            
            // Increment frequency
            digitFrequency[digit]++;

            // Remove last digit
            tempNumber /= 10;
        }

        // Display frequency
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (digitFrequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + ": " + digitFrequency[i] + " times");
            }
        }
    }

    public static void Main()
    {
        FindDigitFrequency();
    }
}