using System;

class FirstLastOccurrence
{
    // Function to find first occurrence
    public static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int result = -1;
        
        while (left <= right)
        {
            // Calculate middle point
            int mid = left + (right - left) / 2;
            
            // If target found, look in left half for first occurrence
            if (arr[mid] == target)
            {
                result = mid;
                right = mid - 1;
            }
            // If target is greater, look in right half
            else if (arr[mid] < target)
                left = mid + 1;
            // If target is smaller, look in left half
            else
                right = mid - 1;
        }
        
        return result;
    }
    
    // Function to find last occurrence
    public static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int result = -1;
        
        while (left <= right)
        {
            // Calculate middle point
            int mid = left + (right - left) / 2;
            
            // If target found, look in right half for last occurrence
            if (arr[mid] == target)
            {
                result = mid;
                left = mid + 1;
            }
            // If target is greater, look in right half
            else if (arr[mid] < target)
                left = mid + 1;
            // If target is smaller, look in left half
            else
                right = mid - 1;
        }
        
        return result;
    }

    static void Main(string[] args)
    {
        // Test array with multiple occurrences
        int[] array = { 1, 2, 2, 2, 2, 3, 4, 7, 8, 8 };
        int target = 2;
        
        Console.WriteLine("Array:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        
        int firstOccurrence = FindFirstOccurrence(array, target);
        int lastOccurrence = FindLastOccurrence(array, target);
        
        Console.WriteLine("\nTarget: " + target);
        Console.WriteLine("First Occurrence: " + firstOccurrence);
        Console.WriteLine("Last Occurrence: " + lastOccurrence);
    }
}