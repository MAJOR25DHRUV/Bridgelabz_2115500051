using System;

class SwapNumbers
{
    public static void Main(string[] args)
    {
        int number1 = 10, number2 = 20; // Example numbers
        Swap(number1, number2); // Calling method to swap numbers
    }

    // Method to swap two numbers and display the result
    static void Swap(int number1, int number2)
    {
        int temp = number1; // Temporary variable to hold number1
        number1 = number2; // Assign number2 to number1
        number2 = temp; // Assign the original number1 to number2
        // Displaying the swapped result
        Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
    }
}
