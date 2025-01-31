using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Convert Fahrenheit to Celsius");
        Console.WriteLine("2. Convert Celsius to Fahrenheit");
        Console.Write("Choose an option (1 or 2): ");
        
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.Write("Invalid choice. Please enter 1 or 2: ");
        }

        Console.Write("Enter the temperature: ");
        double temp;
        while (!double.TryParse(Console.ReadLine(), out temp))
        {
            Console.Write("Invalid input. Please enter a numeric value: ");
        }

        if (choice == 1)
        {
            double celsius = FahrenheitToCelsius(temp);
            Console.WriteLine(string.Format(" {0}°F is equal to {1:F2}°C",temp,celsius));
        }
        else
        {
            double fahrenheit = CelsiusToFahrenheit(temp);
            Console.WriteLine(string.Format(" {0}°C is equal to {1:F2}°F",temp,fahrenheit));
        }
    }

    // Function to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Function to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}
