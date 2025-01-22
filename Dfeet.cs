using System; 

class Dfeet
{
    public static void Main(string[] args)
    {
        Console.Write("Enter distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine()); // Taking user input for distance in feet

        // Converting feet to yards and miles
        double distanceInYards = distanceInFeet / 3; // 1 yard = 3 feet
        double distanceInMiles = distanceInYards / 1760; // 1 mile = 1760 yards

        // Displaying the result
        Console.WriteLine("Your distance in yards is " + distanceInYards + " and in miles is " + distanceInMiles);
    }
}
