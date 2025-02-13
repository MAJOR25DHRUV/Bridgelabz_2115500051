using System;
using System.Collections.Generic;

public class LongestConsecutiveSequence
{
    // Method to find the longest consecutive sequence in an array
    public static int FindLongestSequence(int[] nums)
    {
        // If the array is null or empty, return 0
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        // Use a HashSet to store unique numbers for quick lookup
        HashSet<int> numSet = new HashSet<int>(nums);
        
        // Variable to track the longest sequence found
        int longestStreak = 0;

        // Iterate through each number in the set
        foreach (int num in numSet)
        {
            // Check if the number is the starting number of a sequence
            if (!numSet.Contains(num - 1))
            {
                // Initialize variables for the current sequence
                int currentNum = num;
                int currentStreak = 1;

                // Check for consecutive numbers in the sequence
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                // Update the longest sequence if a longer one is found
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        // Return the length of the longest consecutive sequence
        return longestStreak;
    }

    public static void Main(string[] args)
    {
        // Define the first test array
        int[] numbers = { 100, 4, 200, 1, 3, 2, 2 };

        // Print the input array
        Console.WriteLine("Array: " + string.Join(", ", numbers));

        // Find and print the longest consecutive sequence in the array
        int result = FindLongestSequence(numbers);
        Console.WriteLine("Length of longest consecutive sequence: " + result);

        // Define the second test array
        int[] numbers2 = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

        // Print the second input array
        Console.WriteLine("\nArray 2: " + string.Join(", ", numbers2));

        // Find and print the longest consecutive sequence in the second array
        Console.WriteLine("Length of longest consecutive sequence: " + 
                        FindLongestSequence(numbers2));
    }
}
