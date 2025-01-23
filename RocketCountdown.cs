using System;  // Importing the System namespace to use Console

public class RocketCountdown
{
    // Method to perform a countdown for rocket launch using a while loop
    public static void Countdown(int start)
    {
        // Use a while loop to countdown from the start value to 1
        while (start > 0)
        {
            Console.WriteLine(start);
            start--;  // Decrement the counter
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Declare the starting value for countdown
        int start = 10;  // Example starting value; replace with user input if needed

        // Call the Countdown method with the starting value
        Countdown(start);
    }
}
