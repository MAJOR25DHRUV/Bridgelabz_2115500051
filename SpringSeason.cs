using System;

public class SpringSeasonChecker
{
    public static void CheckSpringSeason(int month, int day)
    {
        // Check if the date falls in Spring Season (March 20 to June 20)
        if ((month == 3 && day >= 20) || (month == 4 || month == 5) || (month == 6 && day <= 20))
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }

    public static void Main(string[] args)
    {
        // Check if command line arguments are provided
        if (args.Length != 2)
        {
            Console.WriteLine("Please provide month and day as command line arguments.");
            return;
        }

        // Parse command line arguments
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);

        // Call spring season check method
        CheckSpringSeason(month, day);
    }
}