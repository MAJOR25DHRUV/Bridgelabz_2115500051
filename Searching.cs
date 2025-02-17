using System;
using System.Diagnostics;

class Searching
{
    // Linear Search implementation - O(n)
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    // Binary Search implementation - O(log n)
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        // Test different dataset sizes
        int[] sizes = { 1000, 10000, 1000000 };
        
        foreach (int size in sizes)
        {
            // Generate sorted array for testing
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }
            
            // Number of iterations for more accurate timing
            int iterations = 1000;
            
            Console.WriteLine("Dataset Size: " + size);
            
            // Measure Linear Search
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                // Search for random values to get average case
                LinearSearch(arr, new Random().Next(size));
            }
            sw.Stop();
            double linearTimeMs = (double)sw.ElapsedTicks / TimeSpan.TicksPerMillisecond / iterations;
            
            // Measure Binary Search
            sw.Reset();
            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                // Search for random values to get average case
                BinarySearch(arr, new Random().Next(size));
            }
            sw.Stop();
            double binaryTimeMs = (double)sw.ElapsedTicks / TimeSpan.TicksPerMillisecond / iterations;
            
            Console.WriteLine("Linear Search Average Time: " + linearTimeMs.ToString("F6") + " ms");
            Console.WriteLine("Binary Search Average Time: " + binaryTimeMs.ToString("F6") + " ms");
            Console.WriteLine("Performance Ratio: " + (linearTimeMs/binaryTimeMs).ToString("F2") + "x faster with Binary Search");
            Console.WriteLine("------------------------");
        }
    }
}