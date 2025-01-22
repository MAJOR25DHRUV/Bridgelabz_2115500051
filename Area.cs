using System; 

class TriangleArea
{
    public static void Main(string[] args)
    {
        Console.Write("Enter base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine()); // Taking user input for base

        Console.Write("Enter height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine()); // Taking user input for height

        // Area of the triangle in square centimeters
        double areaCm2 = 0.5 * baseLength * height;

        // Converting area from square centimeters to square inches (1 inch = 2.54 cm)
        double areaInch2 = areaCm2 / Math.Pow(2.54, 2);

        // Displaying the result
        Console.WriteLine("The area of the triangle is " + areaCm2 + " square centimeters and " + areaInch2 + " square inches");
    }
}
