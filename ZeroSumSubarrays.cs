using System;
using System.Collections.Generic;

public class ZeroSumSubarrays
{
    // Method to find all subarrays with a sum of zero
    public static List<Tuple<int, int>> FindZeroSumSubarrays(int[] arr)
    {
        // List to store the pairs of indices for zero-sum subarrays
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();

        // Dictionary to store cumulative sums and their corresponding indices
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();

        // Variable to keep track of cumulative sum
        int sum = 0;

        // Handle the case when a subarray starts from index 0
        sumMap[0] = new List<int> { -1 };

        // Traverse through the array
        for (int i = 0; i < arr.Length; i++)
        {
            // Update the cumulative sum
            sum += arr[i];

            // Check if the sum has been seen before
            if (sumMap.ContainsKey(sum))
            {
                // Add all subarrays ending at index i that sum to zero
                foreach (int startIndex in sumMap[sum])
                {
                    result.Add(new Tuple<int, int>(startIndex + 1, i));
                }
            }

            // Store the current sum and its corresponding index
            if (!sumMap.ContainsKey(sum))
            {
                sumMap[sum] = new List<int>();
            }
            sumMap[sum].Add(i);
        }

        // Return the list of zero-sum subarrays
        return result;
    }

    public static void Main(string[] args)
    {
        // Initialize the input array
        int[] arr = { 6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7 };

        // Print the original array
        Console.WriteLine("Array: " + string.Join(", ", arr));

        // Print a message indicating that zero-sum subarrays will be displayed
        Console.WriteLine("\nZero sum subarrays:");

        // Call the method to find zero-sum subarrays
        List<Tuple<int, int>> results = FindZeroSumSubarrays(arr);

        // Iterate through the results and print each subarray
        foreach (var result in results)
        {
            Console.WriteLine("Subarray from index " + result.Item1 + 
                            " to " + result.Item2 + ": " + 
                            string.Join(", ", GetSubarray(arr, result.Item1, result.Item2)));
        }
    }

    // Method to extract a subarray from the given array based on start and end indices
    private static int[] GetSubarray(int[] arr, int start, int end)
    {
        // Create a new array to store the subarray
        int[] subarray = new int[end - start + 1];

        // Copy elements from the original array to the subarray
        Array.Copy(arr, start, subarray, 0, subarray.Length);

        // Return the extracted subarray
        return subarray;
    }
}
