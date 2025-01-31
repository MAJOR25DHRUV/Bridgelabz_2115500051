using System;

class MaxOfThreeNumbers
{
    static int FindMaximum(int a, int b, int c)
    {
        return (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int max = FindMaximum(num1, num2, num3);
        Console.WriteLine(string.Format("The maximum number is: {0}",max));
    }
}