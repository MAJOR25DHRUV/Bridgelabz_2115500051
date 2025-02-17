using System;
using System.Diagnostics;

class Sorting
{
     // Bubble Sort implementation - O(n²)
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Merge Sort implementation - O(n log n)
    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        
        int[] L = new int[n1];
        int[] R = new int[n2];
        
        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);
        
        int i = 0, j = 0, k = left;
        
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
        
        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }
        
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    // Quick Sort implementation - O(n log n)
    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            QuickSort(arr, left, pivot - 1);
            QuickSort(arr, pivot + 1, right);
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;
        
        for (int j = left; j < right; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[right];
        arr[right] = temp1;
        
        return i + 1;
    }

    static void Main(string[] args)
    {
        // Test different dataset sizes
        int[] sizes = { 1000, 10000, 100000 };
        
        foreach (int size in sizes)
        {
            Console.WriteLine("Dataset Size: " + size);
            
            // Number of iterations for more accurate timing
            int iterations = size <= 10000 ? 100 : 10;
            
            double bubbleSortTotal = 0;
            double mergeSortTotal = 0;
            double quickSortTotal = 0;
            
            for (int iter = 0; iter < iterations; iter++)
            {
                // Generate random array
                int[] arr1 = new int[size];
                Random rand = new Random();
                for (int i = 0; i < size; i++)
                {
                    arr1[i] = rand.Next(1000000);
                }
                
                // Create copies for different sorts
                int[] arr2 = new int[size];
                int[] arr3 = new int[size];
                Array.Copy(arr1, arr2, size);
                Array.Copy(arr1, arr3, size);
                
                // Measure Bubble Sort
                Stopwatch sw = new Stopwatch();
                sw.Start();
                BubbleSort(arr1);
                sw.Stop();
                bubbleSortTotal += (double)sw.ElapsedTicks / TimeSpan.TicksPerMillisecond;
                
                // Measure Merge Sort
                sw.Reset();
                sw.Start();
                MergeSort(arr2, 0, size - 1);
                sw.Stop();
                mergeSortTotal += (double)sw.ElapsedTicks / TimeSpan.TicksPerMillisecond;
                
                // Measure Quick Sort
                sw.Reset();
                sw.Start();
                QuickSort(arr3, 0, size - 1);
                sw.Stop();
                quickSortTotal += (double)sw.ElapsedTicks / TimeSpan.TicksPerMillisecond;
            }
            
            double bubbleSortAvg = bubbleSortTotal / iterations;
            double mergeSortAvg = mergeSortTotal / iterations;
            double quickSortAvg = quickSortTotal / iterations;
            
            Console.WriteLine("Bubble Sort Average Time: " + bubbleSortAvg.ToString("F6") + " ms");
            Console.WriteLine("Merge Sort Average Time: " + mergeSortAvg.ToString("F6") + " ms");
            Console.WriteLine("Quick Sort Average Time: " + quickSortAvg.ToString("F6") + " ms");
            Console.WriteLine("Merge Sort is " + (bubbleSortAvg/mergeSortAvg).ToString("F2") + "x faster than Bubble Sort");
            Console.WriteLine("Quick Sort is " + (bubbleSortAvg/quickSortAvg).ToString("F2") + "x faster than Bubble Sort");
            Console.WriteLine("------------------------");
        }
    }
}