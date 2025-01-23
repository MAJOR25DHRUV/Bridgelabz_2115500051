using System;  // Importing the System namespace

public class DayOfWeek
{
    // Method to calculate the day of the week
    public static void CalculateDayOfWeek(int month, int day, int year)
    {
        int y0 = year - (14 - month) / 12;  // Calculate y0
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;  // Calculate x
        int m0 = month + 12 * ((14 - month) / 12) - 2;  // Calculate m0
        int d0 = (day + x + 31 * m0 / 12) % 7;  // Calculate d0 (Day of the week)
        
        // Output the result (0 = Sunday, 1 = Monday, ..., 6 = Saturday)
        Console.WriteLine("Day of the week: " + d0);
    }

    // Main method
    public static void Main(string[] args)
    {
        int month = 9;  // Example month (replace with user input)
        int day = 25;   // Example day (replace with user input)
        int year = 2025;  // Example year (replace with user input)
        CalculateDayOfWeek(month, day, year);  // Calling method to calculate the day of the week
    }
}
