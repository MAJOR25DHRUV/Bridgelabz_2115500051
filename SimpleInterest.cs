using System;

class SimpleInterest
{
    public static void Main(string[] args)
    {
        double principal = 10000; // Example principal
        double rate = 5; // Example rate of interest
        double time = 2; // Example time in years
        CalculateSimpleInterest(principal, rate, time); // Calling method to calculate simple interest
    }

    // Method to calculate simple interest and display result
    static void CalculateSimpleInterest(double principal, double rate, double time)
    {
        double interest = (principal * rate * time) / 100; // Simple Interest formula
        // Displaying the result
        Console.WriteLine("The Simple Interest is " + interest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
    }
}
