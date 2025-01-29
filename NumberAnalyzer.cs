using System;

public class NumberAnalyzer
{
    public static void Main(string[] args)
    {
        // Declare array to store numbers
        int[] numbers = new int[5];
        
        // Get input from user
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter number " + (i + 1) + ":");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            
            // Check if positive or negative
            if(IsPositive(numbers[i]))
            {
                Console.WriteLine("Number is positive");
                // If positive, check if even or odd
                if(IsEven(numbers[i]))
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    Console.WriteLine("Number is odd");
                }
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }
        
        // Compare first and last elements
        int comparison = Compare(numbers[0], numbers[numbers.Length - 1]);
        if(comparison == 1)
        {
            Console.WriteLine("First number is greater than last number");
        }
        else if(comparison == -1)
        {
            Console.WriteLine("First number is less than last number");
        }
        else
        {
            Console.WriteLine("First and last numbers are equal");
        }
    }
    
    public static bool IsPositive(int number)
    {
        // Check if number is positive
        return number >= 0;
    }
    
    public static bool IsEven(int number)
    {
        // Check if number is even
        return number % 2 == 0;
    }
    
    public static int Compare(int number1, int number2)
    {
        // Compare two numbers
        if(number1 > number2)
            return 1;
        else if(number1 < number2)
            return -1;
        else
            return 0;
    }
}