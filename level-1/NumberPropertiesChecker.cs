using System;

public class NumberPropertiesChecker
{
    // Method to analyze number properties
    public static void AnalyzeNumberProperties()
    {
        // Array to store 5 numbers
        int[] numbers = new int[5];

        // Input 5 numbers from user
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Analyze each number
        for (int i = 0; i < numbers.Length; i++)
        {
            // Check if number is positive
            if (numbers[i] > 0)
            {
                // Check if positive number is even or odd
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("Number " + numbers[i] + " is positive and even");
                }
                else
                {
                    Console.WriteLine("Number " + numbers[i] + " is positive and odd");
                }
            }
            // Check if number is negative
            else if (numbers[i] < 0)
            {
                Console.WriteLine("Number " + numbers[i] + " is negative");
            }
            // Check if number is zero
            else
            {
                Console.WriteLine("Number is zero");
            }
        }

        // Compare first and last elements
        int firstNumber = numbers[0];
        int lastNumber = numbers[numbers.Length - 1];

        // Comparison logic
        if (firstNumber == lastNumber)
        {
            Console.WriteLine("First and last numbers are equal");
        }
        else if (firstNumber > lastNumber)
        {
            Console.WriteLine("First number is greater than last number");
        }
        else
        {
            Console.WriteLine("First number is less than last number");
        }
    }

    public static void Main()
    {
        AnalyzeNumberProperties();
    }
}
