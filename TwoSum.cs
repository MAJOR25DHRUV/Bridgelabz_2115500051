using System;
using System.Collections.Generic;

public class TwoSum
{
    // Method to find two indices whose values add up to the target
    public static int[] FindTwoSum(int[] numbers, int target)
    {
        // Dictionary to store numbers and their indices
        Dictionary<int, int> seen = new Dictionary<int, int>();

        // Traverse the array
        for (int i = 0; i < numbers.Length; i++)
        {
            // Calculate the complement (number needed to reach the target)
            int complement = target - numbers[i];

            // Check if the complement exists in the dictionary
            if (seen.ContainsKey(complement))
            {
                // Return the indices if a valid pair is found
                return new int[] { seen[complement], i };
            }

            // Store the current number with its index if not already in the dictionary
            if (!seen.ContainsKey(numbers[i]))
            {
                seen.Add(numbers[i], i);
            }
        }

        // Return -1, -1 if no solution is found
        return new int[] { -1, -1 };
    }

    public static void Main(string[] args)
    {
        // Initialize the array of numbers
        int[] numbers = { 2, 7, 11, 15 };

        // Define the target sum
        int target = 9;

        // Print the array elements
        Console.WriteLine("Array: " + string.Join(", ", numbers));

        // Print the target sum
        Console.WriteLine("Target: " + target);

        // Call the method to find two numbers that sum to the target
        int[] result = FindTwoSum(numbers, target);

        // Print the result if a valid pair is found
        if (result[0] != -1)
        {
            Console.WriteLine("Found indices: " + result[0] + ", " + result[1]);
            Console.WriteLine("Numbers: " + numbers[result[0]] + " + " + numbers[result[1]] + " = " + target);
        }
        else
        {
            // Print a message if no solution is found
            Console.WriteLine("No solution found");
        }
    }
}
