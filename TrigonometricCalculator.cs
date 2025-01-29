using System;

public class TrigonometricCalculator
{
    public static void Main(string[] args)
    {
        // Declare variable for user input
        double angle;
        
        // Get input from user
        Console.WriteLine("Enter angle in degrees:");
        angle = Convert.ToDouble(Console.ReadLine());
        
        // Calculate trigonometric values
        double[] result = CalculateTrigonometricFunctions(angle);
        
        // Display results
        Console.WriteLine("Sine: " + result[0]);
        Console.WriteLine("Cosine: " + result[1]);
        Console.WriteLine("Tangent: " + result[2]);
    }
    
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Array to store results (sine, cosine, tangent)
        double[] result = new double[3];
        
        // Convert angle to radians
        double radians = angle * Math.PI / 180.0;
        
        // Calculate trigonometric values
        result[0] = Math.Sin(radians);
        result[1] = Math.Cos(radians);
        result[2] = Math.Tan(radians);
        
        return result;
    }
}