using System;

public class ChocolateDistribution
{
    public static void Main(string[] args)
    {
        // Declare variables for user input
        int numberOfChocolates, numberOfChildren;
        
        // Get input from user
        Console.WriteLine("Enter number of chocolates:");
        numberOfChocolates = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter number of children:");
        numberOfChildren = Convert.ToInt32(Console.ReadLine());
        
        // Call method to calculate distribution
        int[] result = FindChocolateDistribution(numberOfChocolates, numberOfChildren);
        
        // Display results
        Console.WriteLine("Chocolates per child: " + result[0]);
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }
    
    public static int[] FindChocolateDistribution(int chocolates, int children)
    {
        // Array to store results (chocolates per child and remaining)
        int[] result = new int[2];
        
        // Calculate chocolates per child
        result[0] = chocolates / children;
        
        // Calculate remaining chocolates
        result[1] = chocolates % children;
        
        return result;
    }
}