using System; // Importing System namespace for basic functionalities

class DistanceConverter
{
    public static void Main(string[] args)
    {
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine()); // Taking user input for kilometers

        // Conversion factor
        double miles = km / 1.6; // 1 mile = 1.6 kilometers

        // Displaying the result
        Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
    }
}
