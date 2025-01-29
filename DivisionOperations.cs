using System;

public class DivisionOperations
{
    public static void Main(string[] args)
    {
        // Declare variables for user input
        int number, divisor;
        
        // Get input from user
        Console.WriteLine("Enter number:");
        number = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter divisor:");
        divisor = Convert.ToInt32(Console.ReadLine());
        
        // Call method to find remainder and quotient
        int[] result = FindRemainderAndQuotient(number, divisor);
        
        // Display results
        Console.WriteLine("Quotient: " + result[0]);
        Console.WriteLine("Remainder: " + result[1]);
    }
    
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        // Array to store results (quotient and remainder)
        int[] result = new int[2];
        
        // Calculate quotient
        result[0] = number / divisor;
        
        // Calculate remainder
        result[1] = number % divisor;
        
        return result;
    }
}