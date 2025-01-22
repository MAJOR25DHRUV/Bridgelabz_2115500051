using System;

class Trip
{
    public static void Main(string[] args)
    {
        string name = "Dhruv kushwah"; // Example name
        string fromCity = "Mathura"; // Example from city
        string viaCity = "Ghaziabad"; // Example via city
        string toCity = "Delhi"; // Example to city
        double fromToVia = 110; // Distance from fromCity to viaCity in miles
        double viaToFinalCity = 100; // Distance from viaCity to toCity in miles
        double timeTaken = 10; // Example time taken for the trip in hours

        CalculateTrip(name, fromCity, viaCity, toCity, fromToVia, viaToFinalCity, timeTaken); // Calling method to calculate the trip details
    }

    // Method to calculate and display trip details
    static void CalculateTrip(string name, string fromCity, string viaCity, string toCity, double fromToVia, double viaToFinalCity, double timeTaken)
    {
        double totalDistance = fromToVia + viaToFinalCity; // Total distance for the trip
        double averageSpeed = totalDistance / timeTaken; // Average speed of the trip

        // Displaying the trip details
        Console.WriteLine("The results of the trip are: Name: " + name + ", From: " + fromCity + " to " + toCity + " via " + viaCity + ", Total Distance: " + totalDistance + " miles, and Average Speed: " + averageSpeed + " miles/hour");
    }
}
