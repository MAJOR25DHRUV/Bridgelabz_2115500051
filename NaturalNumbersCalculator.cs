using System;

public class NaturalNumbersCalculator
{
    public static void Main(string[] args)
    {
        // Declare variable for user input
        int number;
        
        // Get input from user
        Console.WriteLine("Enter a natural number:");
        number = Convert.ToInt32(Console.ReadLine());
        
        // Check if number is natural
        if(number <= 0)
        {
            Console.WriteLine("Please enter a positive natural number");
            return;
        }
        
        // Calculate sums using both methods
        int recursiveSum = CalculateSumRecursive(number);
        int formulaSum = CalculateSumFormula(number);
        
        // Display results
        Console.WriteLine("Sum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula: " + formulaSum);
        Console.WriteLine("Results match: " + (recursiveSum == formulaSum));
    }
    
    public static int CalculateSumRecursive(int n)
    {
        // Base case
        if(n == 1)
            return 1;
            
        // Recursive case
        return n + CalculateSumRecursive(n - 1);
    }
    
    public static int CalculateSumFormula(int n)
    {
        // Calculate using formula n*(n+1)/2
        return (n * (n + 1)) / 2;
    }
}