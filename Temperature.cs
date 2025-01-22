using System;

class Temperature
{
    public static void Main(string[] args)
    {
        double celsius = 25; // Example Celsius input
        ConvertCelsiusToFahrenheit(celsius); // Calling method to convert Celsius to Fahrenheit
    }

    // Method to convert Celsius to Fahrenheit and print the result
    static void ConvertCelsiusToFahrenheit(double celsius)
    {
        double fahrenheitResult = (celsius * 9 / 5) + 32; // Celsius to Fahrenheit conversion formula
        // Displaying the result
        Console.WriteLine("The " + celsius + " Celsius is " + fahrenheitResult + " Fahrenheit");
    }
}
