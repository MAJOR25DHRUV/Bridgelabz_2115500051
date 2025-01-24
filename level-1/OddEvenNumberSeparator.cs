using System;

public class OddEvenNumberSeparator
{
    public static void SeparateOddAndEvenNumbers()
    {
        // Input number from user
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate natural number
        if (number <= 0)
        {
            Console.WriteLine("Error: Not a natural number");
            return;
        }

        // Arrays for odd and even numbers
        int[] evenNumbers = new int[(number / 2) + 1];
        int[] oddNumbers = new int[(number / 2) + 1];

        // Index trackers for odd and even arrays
        int evenIndex = 0;
        int oddIndex = 0;

        // Separate odd and even numbers
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        // Print even numbers
        Console.Write("Even numbers: ");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
        Console.WriteLine();

        // Print odd numbers
        Console.Write("Odd numbers: ");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        SeparateOddAndEvenNumbers();
    }
}