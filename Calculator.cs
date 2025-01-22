using System; 

class Calculator
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine()); // Taking user input for first number

        Console.Write("Enter second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine()); // Taking user input for second number

        // Performing arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2;

        // Displaying the result
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + number1 + " and " + number2 + " is " + addition + ", " + subtraction + ", " + multiplication + ", and " + division);
    }
}
