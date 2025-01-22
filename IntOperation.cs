using System;

class IntOperations
{
    public static void Main(string[] args)
    {
        int a = 5, b = 3, c = 2; // Example integer inputs
        PerformIntOperations(a, b, c); // Calling method to perform integer operations
    }

    // Method to perform integer operations and print results
    static void PerformIntOperations(int a, int b, int c)
    {
        int result1 = a + b * c; // Operator precedence: multiplication first
        int result2 = a * b + c; // Operator precedence: multiplication first
        int result3 = c + a / b; // Operator precedence: division first
        int result4 = a % b + c; // Operator precedence: modulus first
        // Displaying the results
        Console.WriteLine("The results of Int Operations are " + result1 + ", " + result2 + ", " + result3 + ", and " + result4);
    }
}
