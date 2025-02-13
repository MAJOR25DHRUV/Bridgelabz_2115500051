using System;
using System.Collections.Generic;

public class SlidingWindow
{
    // Method to find the maximum in each sliding window of size k
    public static int[] FindMaxInWindow(int[] arr, int k)
    {
        // Check for edge cases where array is empty or window size is invalid
        if (arr.Length == 0 || k <= 0)
        {
            return new int[0];
        }

        // Create an array to store the maximum values
        int[] result = new int[arr.Length - k + 1];

        // Use a deque (double-ended queue) to store indices of useful elements
        LinkedList<int> deque = new LinkedList<int>();
        
        // Process the first k elements
        for (int i = 0; i < k; i++)
        {
            // Remove elements from the back if they are smaller than the current element
            while (deque.Count > 0 && arr[i] >= arr[deque.Last.Value])
            {
                deque.RemoveLast();
            }
            // Add the current index to the deque
            deque.AddLast(i);
        }

        // Process the rest of the elements
        for (int i = k; i < arr.Length; i++)
        {
            // Store the maximum of the previous window
            result[i - k] = arr[deque.First.Value];

            // Remove elements that are out of the current window
            while (deque.Count > 0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            // Remove elements from the back if they are smaller than the current element
            while (deque.Count > 0 && arr[i] >= arr[deque.Last.Value])
            {
                deque.RemoveLast();
            }

            // Add the current index to the deque
            deque.AddLast(i);
        }

        // Store the maximum for the last window
        result[arr.Length - k] = arr[deque.First.Value];

        // Return the result array containing maximum values in each window
        return result;
    }

    public static void Main(string[] args)
    {
        // Define an array of integers
        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };

        // Define the size of the sliding window
        int windowSize = 3;

        // Print the original array
        Console.WriteLine("Original Array:");
        PrintArray(arr);

        // Compute the maximum in each sliding window
        int[] result = FindMaxInWindow(arr, windowSize);
        
        // Print the result containing maximum values for each window
        Console.WriteLine("\nMaximum in each window of size " + windowSize + ":");
        PrintArray(result);
    }

    // Method to print an array
    private static void PrintArray(int[] arr)
    {
        // Iterate through the array and print each element
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
