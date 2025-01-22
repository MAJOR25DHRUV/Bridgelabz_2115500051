using System;

class TemperatureFC

{
    public static void Main(string[] args)
    {
        double fahrenheit = 77; // Example Fahrenheit input
        ConvertFahrenheitToCelsius(fahrenheit); // Calling method to convert Fahrenheit to Celsius
    }

    // Method to convert Fahrenheit to Celsius and print the result
    static void ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double celsiusResult = (fahrenheit - 32) * 5 / 9; // Fahrenheit to Celsius conversion formula
        // Displaying the result
        Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsiusResult + " Celsius");
    }
}
