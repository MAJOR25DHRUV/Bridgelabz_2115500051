using System; // Importing System namespace for basic functionalities

class Quotient
{
    public static void Main(string[] args)
    {
        int number1 = 100; // Example number 1
        int number2 = 30; // Example number 2
        CalculateQuotientRemainder(number1, number2); // Calling method to calculate quotient and remainder
    }

    // Method to calculate and display quotient and remainder
    static void CalculateQuotientRemainder(int number1, int number2)
    {
        int quotient = number1 / number2; // Using division operator to calculate quotient
        int remainder = number1 % number2; // Using modulus operator to calculate remainder
        // Displaying the result
        Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + " of two numbers " + number1 + " and " + number2);
    }
}
