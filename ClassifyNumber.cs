using System;

public class NumberClassifier
{
    public static void ClassifyNumber(int number)
    {
        // Check and classify the number
        if (number > 0)
        {
            Console.WriteLine("Positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }

    public static void Main()
    {
        // Get user input
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        
        // Call classification method
        ClassifyNumber(inputNumber);
    }
}