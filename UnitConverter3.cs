using System;
public class UnitConverter3
{
    // Constants for conversion
    private static readonly double pounds2kilograms = 0.453592;
    private static readonly double kilograms2pounds = 2.20462;
    private static readonly double gallons2liters = 3.78541;
    private static readonly double liters2gallons = 0.264172;

    public static void Main(string[] args)
    {
        // Demonstrate each conversion
        Console.WriteLine("Enter Fahrenheit temperature to convert to Celsius:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(fahrenheit + "°F = " + ConvertFahrenheitToCelsius(fahrenheit) + "°C");

        Console.WriteLine("\nEnter Celsius temperature to convert to Fahrenheit:");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(celsius + "°C = " + ConvertCelsiusToFahrenheit(celsius) + "°F");

        Console.WriteLine("\nEnter pounds to convert to kilograms:");
        double pounds = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(pounds + " pounds = " + ConvertPoundsToKilograms(pounds) + " kilograms");

        Console.WriteLine("\nEnter kilograms to convert to pounds:");
        double kilograms = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(kilograms + " kilograms = " + ConvertKilogramsToPounds(kilograms) + " pounds");

        Console.WriteLine("\nEnter gallons to convert to liters:");
        double gallons = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(gallons + " gallons = " + ConvertGallonsToLiters(gallons) + " liters");

        Console.WriteLine("\nEnter liters to convert to gallons:");
        double liters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(liters + " liters = " + ConvertLitersToGallons(liters) + " gallons");
    }

    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        return pounds * pounds2kilograms;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        return kilograms * kilograms2pounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        return gallons * gallons2liters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        return liters * liters2gallons;
    }
}
