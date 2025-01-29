using System;

public class FactorCalculator
{
    public static void Main(string[] args)
    {
        // Declare variable for user input
        int number;
        
        // Get input from user
        Console.WriteLine("Enter a number to find its factors:");
        number = Convert.ToInt32(Console.ReadLine());
        
        // Get factors array
        int[] factors = FindFactors(number);
        
        // Display factors
        Console.WriteLine("\nFactors are:");
        foreach(int factor in factors)
        {
            Console.Write(factor + " ");
        }
        
        // Calculate and display results
        Console.WriteLine("\nSum of factors: " + CalculateSum(factors));
        Console.WriteLine("Product of factors: " + CalculateProduct(factors));
        Console.WriteLine("Sum of squares of factors: " + CalculateSumOfSquares(factors));
    }
    
    public static int[] FindFactors(int number)
    {
        // First loop to count factors
        int count = 0;
        for(int i = 1; i <= number; i++)
        {
            if(number % i == 0)
            {
                count++;
            }
        }
        
        // Initialize array with count
        int[] factors = new int[count];
        
        // Second loop to store factors
        int index = 0;
        for(int i = 1; i <= number; i++)
        {
            if(number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }
        
        return factors;
    }
    
    public static int CalculateSum(int[] factors)
    {
        int sum = 0;
        foreach(int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }
    
    public static int CalculateProduct(int[] factors)
    {
        int product = 1;
        foreach(int factor in factors)
        {
            product *= factor;
        }
        return product;
    }
    
    public static double CalculateSumOfSquares(int[] factors)
    {
        double sum = 0;
        foreach(int factor in factors)
        {
            sum += Math.Pow(factor, 2);
        }
        return sum;
    }
}