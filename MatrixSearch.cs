using System;

class MatrixSearch
{
    public static bool SearchMatrix(int[,] matrix, int target)
    {
        // Check if matrix is empty
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return false;
            
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        // Start from top-right corner
        int row = 0;
        int col = cols - 1;
        
        while (row < rows && col >= 0)
        {
            // If current element is target, return true
            if (matrix[row, col] == target)
                return true;
                
            // If current element is greater than target, move left
            if (matrix[row, col] > target)
                col--;
            // If current element is smaller than target, move down
            else
                row++;
        }
        
        return false;
    }

    static void Main(string[] args)
    {
        // Test matrix with sorted rows
        int[,] matrix = {
            { 1,  4,  7,  11 },
            { 2,  5,  8,  12 },
            { 3,  6,  9,  16 },
            { 10, 13, 14, 17 }
        };
        
        int target = 5;
        
        Console.WriteLine("Matrix:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + "\t");
            }
            Console.WriteLine();
        }
        
        bool found = SearchMatrix(matrix, target);
        
        Console.WriteLine("\nTarget: " + target);
        Console.WriteLine("Found: " + found);
    }
}