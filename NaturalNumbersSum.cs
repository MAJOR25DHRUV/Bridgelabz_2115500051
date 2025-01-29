using System;

class SumOfnNaturalNumber
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is natural and calculate the sum
        CheckAndCalculateSum(number);
    }

    static void CheckAndCalculateSum(int number)
    {
        // Check if the number is a natural number
        if (number >= 0)
        {
            // Calculate the sum using the formula
            int sum = number * (number + 1) / 2;

            // Display the result
            Console.WriteLine("The sum of " + number +" natural numbers is " +sum);
        }
        else
        {
            Console.WriteLine("The number "+number+" is not a natural number.");
        }
    }
}
