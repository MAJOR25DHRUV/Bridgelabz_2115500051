using System; 

class Earth
{
    public static void Main(string[] args)
    {
        double radius = 6378; // Radius of the Earth in kilometers
        double pi = 3.141592653589793; // Value of Pi

        // Volume of the Earth in cubic kilometers
        double volumeKm3 = (4.0 / 3.0) * pi * Math.Pow(radius, 3);

        // Convert the volume from cubic kilometers to cubic miles (1 mile = 1.60934 km)
        double volumeMiles3 = volumeKm3 / Math.Pow(1.60934, 3);

        // Displaying the result
        Console.WriteLine("The volume of Earth in cubic kilometers is " + volumeKm3 + " and cubic miles is " + volumeMiles3);
    }
}
