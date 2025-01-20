using System;

class AverageOfThree
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double num3 = double.Parse(Console.ReadLine());
        double average = (num1 + num2 + num3) / 3;
        Console.WriteLine("Average: " + average);
    }
}
