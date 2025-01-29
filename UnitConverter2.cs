using System;

public class UnitConverter2
{
    // Constants for conversion
    private static readonly double yards2feet = 3;
    private static readonly double feet2yards = 0.333333;
    private static readonly double meters2inches = 39.3701;
    private static readonly double inches2meters = 0.0254;
    private static readonly double inches2cm = 2.54;

    public static void Main(string[] args)
    {
        // Demonstrate each conversion
        Console.WriteLine("Enter yards to convert to feet:");
        double yards = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(yards + " yards = " + ConvertYardsToFeet(yards) + " feet");

        Console.WriteLine("\nEnter feet to convert to yards:");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(feet + " feet = " + ConvertFeetToYards(feet) + " yards");

        Console.WriteLine("\nEnter meters to convert to inches:");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(meters + " meters = " + ConvertMetersToInches(meters) + " inches");

        Console.WriteLine("\nEnter inches to convert to meters:");
        double inches = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(inches + " inches = " + ConvertInchesToMeters(inches) + " meters");

        Console.WriteLine("\nEnter inches to convert to centimeters:");
        inches = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(inches + " inches = " + ConvertInchesToCm(inches) + " centimeters");
    }

    public static double ConvertYardsToFeet(double yards)
    {
        return yards * yards2feet;
    }

    public static double ConvertFeetToYards(double feet)
    {
        return feet * feet2yards;
    }

    public static double ConvertMetersToInches(double meters)
    {
        return meters * meters2inches;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        return inches * inches2meters;
    }

    public static double ConvertInchesToCm(double inches)
    {
        return inches * inches2cm;
    }
}
