using System;

public class NumberStorageCalculator
{
    public static void StoreAndCalculateNumbers()
    {
        // Array to store numbers
        double[] numberArray = new double[10];
        
        // Total sum variable
        double totalSum = 0.0;
        
        // Index to track array position
        int arrayIndex = 0;

        // Infinite loop for number input
        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double userNumber = Convert.ToDouble(Console.ReadLine());

            // Break conditions
            if (userNumber <= 0 || arrayIndex == 10)
            {
                break;
            }

            // Store number in array
            numberArray[arrayIndex] = userNumber;
            arrayIndex++;
        }

        // Calculate total sum
        for (int i = 0; i < arrayIndex; i++)
        {
            totalSum += numberArray[i];
        }

        // Display numbers and total
        Console.WriteLine("Entered numbers:");
        for (int i = 0; i < arrayIndex; i++)
        {
            Console.WriteLine(numberArray[i]);
        }
        Console.WriteLine("Total sum: " + totalSum);
    }

    public static void Main()
    {
        StoreAndCalculateNumbers();
    }
}