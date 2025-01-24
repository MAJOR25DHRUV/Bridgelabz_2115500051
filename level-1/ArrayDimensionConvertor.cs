using System;

public class ArrayDimensionConverter
{
    public static void ConvertArrayDimensions()
    {
        // Input rows and columns
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        // Create 2D array
        int[,] twoDArray = new int[rows, columns];

        // Input 2D array elements
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Enter element for position [" + i + ", " + j + "]: ");
                twoDArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Create 1D array
        int[] oneDArray = new int[rows * columns];
        
        // Index for 1D array
        int index = 0;

        // Convert 2D array to 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                oneDArray[index] = twoDArray[i, j];
                index++;
            }
        }

        // Display 1D array
        Console.Write("Converted 1D Array: ");
        for (int i = 0; i < oneDArray.Length; i++)
        {
            Console.Write(oneDArray[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        ConvertArrayDimensions();
    }
}