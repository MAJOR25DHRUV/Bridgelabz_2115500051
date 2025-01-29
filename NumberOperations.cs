using System;

public class NumberOperations
{
    public static void Main(string[] args)
    {
        // Declare variables for user input
        int number1, number2, number3;
        
        // Get input from user
        Console.WriteLine("Enter first number:");
        number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter second number:");
        number2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter third number:");
        number3 = Convert.ToInt32(Console.ReadLine());
        
        // Call method to find smallest and largest
        int[] result = FindSmallestAndLargest(number1, number2, number3);
        
        // Display results
        Console.WriteLine("Smallest number: " + result[0]);
        Console.WriteLine("Largest number: " + result[1]);
    }
    
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        // Array to store results (smallest and largest)
        int[] result = new int[2];
        
        // Find smallest number
        result[0] = Math.Min(Math.Min(number1, number2), number3);
        
        // Find largest number
        result[1] = Math.Max(Math.Max(number1, number2), number3);
        
        return result;
    }
}