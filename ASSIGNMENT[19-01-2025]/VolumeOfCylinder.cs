using System;

class VolumeOfCylinder
{
    static void Main(string[] args)
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        double volume = Math.PI * radius * radius * height;
        Console.WriteLine("Volume of the cylinder: " + volume);
    }
}
