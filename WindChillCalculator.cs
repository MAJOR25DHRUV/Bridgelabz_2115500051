using System;

public class WindChillCalculator
{
    public static void Main(string[] args)
    {
        // Declare variables for user input
        double temperature, windSpeed;
        
        // Get input from user
        Console.WriteLine("Enter temperature (in Fahrenheit):");
        temperature = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter wind speed (in mph):");
        windSpeed = Convert.ToDouble(Console.ReadLine());
        
        // Calculate wind chill
        double windChill = CalculateWindChill(temperature, windSpeed);
        
        // Display result
        Console.WriteLine("Wind Chill Temperature: " + windChill + " Fahrenheit");
    }
    
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        // Calculate wind chill using the formula
        double windChill = 35.74 + 0.6215 * temperature + 
                          (0.4275 * temperature - 35.75) * 
                          Math.Pow(windSpeed, 0.16);
        
        return windChill;
    }
}