using System;

class TriangularPark
{
    // Method to calculate and display the number of rounds to complete 5 km
    static void CalculateRounds(double side1, double side2, double side3)
    {
        // Calculate the perimeter of the triangular park
        double perimeter = side1 + side2 + side3;

        // Convert 5 km to meters (1 km = 1000 m)
        double targetDistance = 5000;

        // Calculate the number of rounds needed
        double rounds = targetDistance / perimeter;

        // Print the number of rounds
        Console.WriteLine("The total number of rounds the athlete will run is " + Math.Ceiling(rounds) + " to complete 5 km");
    }

    // Main method to take inputs and call the calculation method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the three sides of the triangular park (in meters):");
        double side1 = double.Parse(Console.ReadLine()); 
        double side2 = double.Parse(Console.ReadLine()); 
        double side3 = double.Parse(Console.ReadLine()); 

        // Call the method to calculate the number of rounds
        CalculateRounds(side1, side2, side3);
    }
}
