using System;

class Athlete
{
    public static void Main(string[] args)
    {
        double side1 = 300; // Example side of the triangle
        double side2 = 400; // Example side of the triangle
        double side3 = 500; // Example side of the triangle
        CalculateRounds(side1, side2, side3); // Calling method to calculate the number of rounds
    }

    // Method to calculate the total number of rounds to complete 5 km
    static void CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3; // Calculating perimeter of the triangle
        double rounds = 5000 / perimeter; // 5 km is 5000 meters
        // Displaying the result
        Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
    }
}
