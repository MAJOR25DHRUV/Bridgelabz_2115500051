using System;
using System.Collections.Generic;

public class StockSpan
{
    // Method to calculate stock span values
    public static int[] CalculateSpan(int[] prices)
    {
        // Create an array to store the span values
        int[] spans = new int[prices.Length];

        // Create a stack to store indices of elements
        Stack<int> stack = new Stack<int>();

        // The first day's span is always 1
        spans[0] = 1;

        // Push the index of the first element onto the stack
        stack.Push(0);

        // Iterate through the price array starting from index 1
        for (int i = 1; i < prices.Length; i++)
        {
            // Pop elements from stack while the stack is not empty 
            // and the price at the top index is less than or equal to the current price
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            // Calculate the span based on stack status
            spans[i] = stack.Count == 0 ? (i + 1) : (i - stack.Peek());

            // Push the current index onto the stack
            stack.Push(i);
        }

        // Return the calculated span array
        return spans;
    }

    public static void Main(string[] args)
    {
        // Define an array of stock prices
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        
        // Print the original stock prices
        Console.WriteLine("Stock Prices:");
        PrintArray(prices);

        // Compute the stock span values
        int[] spans = CalculateSpan(prices);
        
        // Print the computed stock span values
        Console.WriteLine("\nStock Spans:");
        PrintArray(spans);
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
