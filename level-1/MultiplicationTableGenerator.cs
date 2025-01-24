using System;

public class MultiplicationTableGenerator
{
    // Method to generate multiplication table
    public static void GenerateMultiplicationTable()
    {
        // Get number from user
        Console.Write("Enter a number to generate multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Array to store multiplication results
        int[] multiplicationTable = new int[10];

        // Generate multiplication table
        for (int i = 1; i <= 10; i++)
        {
            multiplicationTable[i - 1] = number * i;
        }

        // Display multiplication table
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + multiplicationTable[i - 1]);
        }
    }

    public static void Main()
    {
        GenerateMultiplicationTable();
    }
}
