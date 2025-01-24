using System;

public class MultiplicationRangeCalculator
{
    public static void CalculateMultiplicationRange()
    {
        // Input number from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Array to store multiplication results
        int[] multiplicationResult = new int[4];

        // Calculate multiplication for range 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;
        }

        // Display multiplication results
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + multiplicationResult[i - 6]);
        }
    }

    public static void Main()
    {
        CalculateMultiplicationRange();
    }
}