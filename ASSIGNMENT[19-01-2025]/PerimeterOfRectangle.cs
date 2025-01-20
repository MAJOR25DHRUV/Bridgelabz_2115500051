using System;

class PerimeterOfRectangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter of the rectangle: " + perimeter);
    }
}
