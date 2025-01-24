using System;

public class NumberFactorsFinder
{
    public static void FindFactors()
    {
        // Maximum factor capacity
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        
        // Index to track factors
        int factorIndex = 0;

        // Input number from user
        Console.Write("Enter a number to find its factors: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Find factors
        for (int i = 1; i <= number; i++)
        {
            // Check if current number is a factor
            if (number % i == 0)
            {
                // Expand array if needed
                if (factorIndex == maxFactor)
                {
                    maxFactor *= 2;
                    int[] tempArray = new int[maxFactor];
                    
                    // Copy existing factors
                    for (int j = 0; j < factorIndex; j++)
                    {
                        tempArray[j] = factors[j];
                    }
                    
                    // Update factors array
                    factors = tempArray;
                }

                // Store factor
                factors[factorIndex] = i;
                factorIndex++;
            }
        }

        // Display factors
        Console.Write("Factors: ");
        for (int i = 0; i < factorIndex; i++)
        {
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        FindFactors();
    }
}