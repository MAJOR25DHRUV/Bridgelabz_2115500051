using System;

public class DynamicDigitsFinder
{
    public static void FindLargestDigits()
    {
        // Input number from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initial array size and tracking variables
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;
        int tempNumber = number;

        // Extract digits
        while (tempNumber != 0)
        {
            // Expand array if needed
            if (index == maxDigit)
            {
                // Create larger temp array
                maxDigit += 10;
                int[] tempArray = new int[maxDigit];

                // Copy existing digits
                for (int j = 0; j < index; j++)
                {
                    tempArray[j] = digits[j];
                }

                // Update digits array
                digits = tempArray;
            }

            // Extract last digit
            int lastDigit = tempNumber % 10;
            digits[index] = lastDigit;

            // Remove last digit
            tempNumber /= 10;
            index++;
        }

        // Find largest and second largest
        int largest = 0;
        int secondLargest = 0;

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        // Display results
        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }

    public static void Main()
    {
        FindLargestDigits();
    }
}