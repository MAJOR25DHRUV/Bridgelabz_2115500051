using System; // Importing System namespace for basic functionalities

class SquareSide
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine()); // Taking user input for perimeter

        // Calculating the side of the square
        double side = perimeter / 4;

        // Displaying the result
        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }
}
