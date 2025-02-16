using System;

class ChallengeProgram
{
    // Function to find first missing positive integer using Linear Search
    public static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;
        
        // Mark numbers that are out of range or negative
        for (int i = 0; i < n; i++)
        {
            if (arr[i] <= 0 || arr[i] > n)
                arr[i] = n + 1;
        }
        
        // Mark numbers that are present by making their corresponding index negative
        for (int i = 0; i < n; i++)
        {
            int num = Math.Abs(arr[i]);
            if (num <= n)
            {
                arr[num - 1] = -Math.Abs(arr[num - 1]);
            }
        }
        
        // Find first positive number - its index + 1 is the answer
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
                return i + 1;
        }
        
        return n + 1;
    }
    
    // Function to find target using Binary Search
    public static int FindTarget(int[] arr, int target)
    {
        // Sort array first
        Array.Sort(arr);
        
        int left = 0;
        int right = arr.Length - 1;
        
        while (left <= right)
        {
            // Calculate middle point
            int mid = left + (right - left) / 2;
            
            // If target found, return index
            if (arr[mid] == target)
                return mid;
                
            // If target is greater, look in right half
            if (arr[mid] < target)
                left = mid + 1;
            // If target is smaller, look in left half
            else
                right = mid - 1;
        }
        
        return -1;
    }

    static void Main(string[] args)
    {
        // Test array
        int[] array = { 3, 4, -1, 1 };
        int target = 3;
        
        Console.WriteLine("Original Array:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        
        // Make a copy for binary search as original array will be modified
        int[] searchArray = new int[array.Length];
        Array.Copy(array, searchArray, array.Length);
        
        int missingPositive = FindFirstMissingPositive(array);
        int targetIndex = FindTarget(searchArray, target);
        
        Console.WriteLine("\nFirst Missing Positive Integer: " + missingPositive);
        Console.WriteLine("Target " + target + " found at index: " + targetIndex);
    }
}