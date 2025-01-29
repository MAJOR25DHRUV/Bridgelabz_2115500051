using System;

public class UnitConverter1
{
    // Constants for conversion
    private static readonly double km2miles = 0.621371;
    private static readonly double miles2km = 1.60934;
    private static readonly double meters2feet = 3.28084;
    private static readonly double feet2meters = 0.3048;

    public static void Main(string[] args)
    {
        // Demonstrate each conversion
        Console.WriteLine("Enter kilometers to convert to miles:");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(km + " kilometers = " + ConvertKmToMiles(km) + " miles");

        Console.WriteLine("\nEnter miles to convert to kilometers:");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(miles + " miles = " + ConvertMilesToKm(miles) + " kilometers");

        Console.WriteLine("\nEnter meters to convert to feet:");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(meters + " meters = " + ConvertMetersToFeet(meters) + " feet");

        Console.WriteLine("\nEnter feet to convert to meters:");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(feet + " feet = " + ConvertFeetToMeters(feet) + " meters");
    }
    
    public static double ConvertKmToMiles(double km)
    {
        return km * km2miles;
    }

    public static double ConvertMilesToKm(double miles)
    {
        return miles * miles2km;
    }

    public static double ConvertMetersToFeet(double meters)
    {
        return meters * meters2feet;
    }

    public static double ConvertFeetToMeters(double feet)
    {
        return feet * feet2meters;
    }
}
