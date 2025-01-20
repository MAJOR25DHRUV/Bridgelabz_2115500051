using System;

class PowerCalculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter base: ");
        double baseNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter exponent: ");
        double exponent = double.Parse(Console.ReadLine());
        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine("Result: " + result);
    }
}
