using System;
using System.Collections.Generic;

public class PairWithGivenSum
{
    // Method to check if a pair exists in the array with the given sum
    public static bool HasPairWithSum(int[] arr, int target)
    {
        // Dictionary to store visited numbers and their indices
        Dictionary<int, bool> seenNumbers = new Dictionary<int, bool>();

        // Iterate through each number in the array
        for (int i = 0; i < arr.Length; i++)
        {
            // Calculate the required complement that would sum to the target
            int complement = target - arr[i];

            // Check if the complement already exists in the dictionary
            if (seenNumbers.ContainsKey(complement))
            {
                return true; // Pair found, return true
            }

            // Store the current number in the dictionary
            if (!seenNumbers.ContainsKey(arr[i]))
            {
                seenNumbers[arr[i]] = true;
            }
        }

        // If no pair is found, return false
        return false;
    }

    public static void Main(string[] args)
    {
        // Define the test array
        int[] numbers = { 2, 7, 11, 15, 1, 8 };

        // Define the target sum
        int target = 9;

        // Print the input array
        Console.WriteLine("Array: " + string.Join(", ", numbers));

        // Print the target sum
        Console.WriteLine("Target Sum: " + target);

        // Check if a pair exists and print the result
        if (HasPairWithSum(numbers, target))
        {
            Console.WriteLine("Pair with the given sum exists.");
        }
        else
        {
            Console.WriteLine("No pair with the given sum found.");
        }
    }
}
