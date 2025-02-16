using System;

class PeakElement
{
    public static int FindPeakElement(int[] arr)
    {
        // If array is empty or has one element, return 0
        if (arr == null || arr.Length <= 1)
            return 0;
            
        int left = 0;
        int right = arr.Length - 1;
        
        while (left <= right)
        {
            // Calculate middle point
            int mid = left + (right - left) / 2;
            
            // Check if mid is peak
            bool isPeak = true;
            
            // Compare with left neighbor if exists
            if (mid > 0 && arr[mid - 1] >= arr[mid])
                isPeak = false;
                
            // Compare with right neighbor if exists
            if (mid < arr.Length - 1 && arr[mid + 1] >= arr[mid])
                isPeak = false;
                
            if (isPeak)
                return mid;
                
            // If left neighbor is greater, search left half
            if (mid > 0 && arr[mid - 1] > arr[mid])
                right = mid - 1;
            // Otherwise search right half
            else
                left = mid + 1;
        }
        
        return -1;
    }

    static void Main(string[] args)
    {
        // Test array with multiple peaks
        int[] array = { 1, 3, 20, 4, 1, 0 };
        
        Console.WriteLine("Array:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        
        int peakIndex = FindPeakElement(array);
        
        Console.WriteLine("\nPeak Element Index: " + peakIndex);
        if (peakIndex != -1)
        {
            Console.WriteLine("Peak Element: " + array[peakIndex]);
        }
    }
}