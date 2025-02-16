using System;

class RotationPoint
{
    public static int FindRotationPoint(int[] arr)
    {
        // If array is empty or has one element, return 0
        if (arr == null || arr.Length <= 1)
            return 0;
            
        int left = 0;
        int right = arr.Length - 1;
        
        // If array is not rotated, return 0
        if (arr[left] < arr[right])
            return 0;
            
        while (left <= right)
        {
            // Calculate middle point
            int mid = left + (right - left) / 2;
            
            // Check if mid+1 is the rotation point
            if (mid < arr.Length - 1 && arr[mid] > arr[mid + 1])
                return mid + 1;
                
            // Check if mid is the rotation point
            if (mid > 0 && arr[mid - 1] > arr[mid])
                return mid;
                
            // If left half is sorted, rotation point is in right half
            if (arr[left] <= arr[mid])
                left = mid + 1;
            // If right half is sorted, rotation point is in left half
            else
                right = mid - 1;
        }
        
        return 0;
    }

    static void Main(string[] args)
    {
        // Test array: Original sorted array: [1,2,3,4,5,6] rotated to [4,5,6,1,2,3]
        int[] rotatedArray = { 4, 5, 6, 1, 2, 3 };
        
        Console.WriteLine("Rotated Array:");
        foreach (int num in rotatedArray)
        {
            Console.Write(num + " ");
        }
        
        int rotationPoint = FindRotationPoint(rotatedArray);
        
        Console.WriteLine("\nRotation Point Index: " + rotationPoint);
        Console.WriteLine("Element at Rotation Point: " + rotatedArray[rotationPoint]);
    }
}