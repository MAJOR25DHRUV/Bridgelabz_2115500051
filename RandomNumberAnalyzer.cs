using System;

public class RandomNumberAnalyzer
{
    public static void Main(string[] args)
    {
        // Generate 5 random numbers
        int[] randomNumbers = Generate4DigitRandomArray(5);
        
        // Display generated numbers
        Console.WriteLine("Generated 4-digit random numbers:");
        foreach(int number in randomNumbers)
        {
            Console.WriteLine(number);
        }
        
        // Calculate statistics
        double[] stats = FindAverageMinMax(randomNumbers);
        
        // Display results
        Console.WriteLine("\nStatistics:");
        Console.WriteLine("Average: " + stats[0]);
        Console.WriteLine("Minimum: " + stats[1]);
        Console.WriteLine("Maximum: " + stats[2]);
    }
    
    public static int[] Generate4DigitRandomArray(int size)
    {
        // Create Random object
        Random random = new Random();
        
        // Generate array of 4-digit random numbers
        int[] numbers = new int[size];
        for(int i = 0; i < size; i++)
        {
            // Generate number between 1000 and 9999
            numbers[i] = random.Next(1000, 10000);
        }
        
        return numbers;
    }
    
    public static double[] FindAverageMinMax(int[] numbers)
    {
        // Array to store results (average, min, max)
        double[] results = new double[3];
        
        // Calculate average
        double sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        results[0] = sum / numbers.Length;
        
        // Find minimum and maximum
        int min = numbers[0];
        int max = numbers[0];
        for(int i = 1; i < numbers.Length; i++)
        {
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }
        results[1] = min;
        results[2] = max;
        
        return results;
    }
}