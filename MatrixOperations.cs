using System;

// Program to perform various matrix operations
class MatrixOperations
{
    // Method to create a random matrix with given dimensions
    public static double[,] CreateRandomMatrix(int rows, int cols)
    {
        Random random = new Random();
        double[,] matrix = new double[rows, cols];
        
        // Fill matrix with random values between 1 and 10
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 11);
            }
        }
        return matrix;
    }

    // Method to add two matrices
    public static double[,] AddMatrices(double[,] matrixA, double[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        double[,] result = new double[rows, cols];

        // Add corresponding elements
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }
        return result;
    }

    // Method to subtract two matrices
    public static double[,] SubtractMatrices(double[,] matrixA, double[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        double[,] result = new double[rows, cols];

        // Subtract corresponding elements
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }
        return result;
    }

    // Method to multiply two matrices
    public static double[,] MultiplyMatrices(double[,] matrixA, double[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);
        double[,] result = new double[rowsA, colsB];

        // Multiply matrices
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                double sum = 0;
                for (int k = 0; k < colsA; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }

    // Method to find transpose of a matrix
    public static double[,] TransposeMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transpose = new double[cols, rows];

        // Swap rows and columns
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }
        return transpose;
    }

    // Method to display a matrix
    public static void DisplayMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Print each element
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Main method to test matrix operations
    static void Main(string[] args)
    {
        Console.WriteLine("Matrix Operations Program");
        Console.WriteLine("------------------------");

        // Create two random matrices
        double[,] matrixA = CreateRandomMatrix(2, 3);
        double[,] matrixB = CreateRandomMatrix(3, 2);

        // Display original matrices
        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrixA);
        Console.WriteLine("\nMatrix B:");
        DisplayMatrix(matrixB);

        // Display transpose
        Console.WriteLine("\nTranspose of Matrix A:");
        DisplayMatrix(TransposeMatrix(matrixA));

        // Create matrices for addition/subtraction
        double[,] matrix1 = CreateRandomMatrix(2, 2);
        double[,] matrix2 = CreateRandomMatrix(2, 2);

        // Display addition result
        Console.WriteLine("\nAddition Result:");
        DisplayMatrix(AddMatrices(matrix1, matrix2));

        // Display multiplication result
        Console.WriteLine("\nMultiplication Result:");
        DisplayMatrix(MultiplyMatrices(matrixA, matrixB));
    }
}