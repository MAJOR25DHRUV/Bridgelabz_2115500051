using System;

class DoubleOpt
{
    public static void Main(string[] args)
    {
        double a = 5.5, b = 3.2, c = 2.1; // Example double inputs
        PerformDoubleOperations(a, b, c); // Calling method to perform double operations
    }

    // Method to perform double operations and print results
    static void PerformDoubleOperations(double a, double b, double c)
    {
        double result1 = a + b * c; // Operator precedence: multiplication first
        double result2 = a * b + c; // Operator precedence: multiplication first
        double result3 = c + a / b; // Operator precedence: division first
        double result4 = a % b + c; // Operator precedence: modulus first
        // Displaying the results
        Console.WriteLine("The results of Double Operations are " + result1 + ", " + result2 + ", and " + result3);
    }
}
