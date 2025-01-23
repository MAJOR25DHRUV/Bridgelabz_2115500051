using System;  // Importing the System namespace to use Console

public class SpringSeason
{
    // Method to check if the given month and day fall in the spring season
    public static void CheckSpringSeason(int month, int day)
    {
        // Check if the date is between March 20 and June 20
        if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20))
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Declare month and day variables
        int month = 3, day = 21;  // Example values; replace with user input if needed

        // Call the CheckSpringSeason method with the provided month and day
        CheckSpringSeason(month, day);
    }
}
