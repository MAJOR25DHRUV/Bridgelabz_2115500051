using System;

class LinearSearch
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the size of the array
        Console.WriteLine("Enter the size of the array: ");
        // Read the input size and convert it to an integer
        int size = int.Parse(Console.ReadLine());
        
        // Declare an integer array with the given size
        int[] arr = new int[size];
        
        // Prompt the user to enter the elements of the array
        Console.WriteLine("Enter the elements of the array: ");
        // Loop to read each element and store it in the array
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Call the function to find the first negative number in the array
        FindNegative(arr);
    }

    // Method to find and print the first negative number in the array
    static void FindNegative(int[] arr)
    {
        // Initialize a boolean variable to track if a negative number is found
        bool found = false;

        // Loop through each element in the array
        for (int i = 0; i < arr.Length; i++)
        {
            // Check if the current element is negative
            if (arr[i] < 0)
            {
                // Print the first negative element found
                Console.WriteLine("The negative element is: " + arr[i]);
                // Set found to true
                found = true;
                // Exit the loop after finding the first negative number
                break;
            }
        }

        // If no negative number is found, print a message
        if (!found)
        {
            Console.WriteLine("No negative element found.");
        }
    }
}
