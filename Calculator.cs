using System;  // Importing the System namespace

public class Calculator
{
    // Method to perform calculator operations based on the operator
    public static void PerformCalculation(double first, double second, string op)
    {
        double result = 0;  // Variable to store the result
        
        // Switch case to check the operator and perform corresponding operations
        switch (op)
        {
            case "+":
                result = first + second;  // Addition
                break;
            case "-":
                result = first - second;  // Subtraction
                break;
            case "*":
                result = first * second;  // Multiplication
                break;
            case "/":
                if (second != 0)
                    result = first / second;  // Division
                else
                    Console.WriteLine("Cannot divide by zero!");
                return;
            default:
                Console.WriteLine("Invalid operator!");  // Invalid operator
                return;
        }

        // Output the result
        Console.WriteLine("Result: " + result);
    }

    // Main method
    public static void Main(string[] args)
    {
        double first = 10;  // Example first number (replace with user input)
        double second = 5;  // Example second number (replace with user input)
        string op = "+";    // Example operator (replace with user input)
        
        PerformCalculation(first, second, op);  // Calling method to perform the calculation
    }
}
