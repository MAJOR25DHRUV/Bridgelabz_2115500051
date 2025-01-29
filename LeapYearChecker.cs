using System;

public class LeapYearChecker
{
    public static void Main(string[] args)
    {
        // Declare variable for user input
        int year;
        
        // Get input from user
        Console.WriteLine("Enter a year to check if it's a leap year:");
        year = Convert.ToInt32(Console.ReadLine());
        
        // Check if year is valid and leap year
        if(IsLeapYear(year))
        {
            Console.WriteLine(year + " is a leap year");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year");
        }
    }
    
    public static bool IsLeapYear(int year)
    {
        // Check if year is valid (>= 1582)
        if(year < 1582)
            return false;
            
        // Check leap year conditions
        if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            return true;
            
        return false;
    }
}