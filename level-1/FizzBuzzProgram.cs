using System;

public class FizzBuzzProgram
{
    public static void PlayFizzBuzz()
    {
        // Input number from user
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate positive integer
        if (number <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        // Array to store FizzBuzz results
        string[] results = new string[number + 1];

        // Generate FizzBuzz results
        for (int i = 0; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz";
            }
            else
            {
                results[i] = i.ToString();
            }
        }

        // Display results
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine("Position " + i + " = " + results[i]);
        }
    }

    public static void Main()
    {
        PlayFizzBuzz();
    }
}