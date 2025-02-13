using System;
using System.Collections.Generic;

public class SortStack
{
    // Method to sort the stack using recursion
    public static Stack<int> Sort(Stack<int> stack)
    {
        // Check if stack is not empty
        if (stack.Count > 0)
        {
            // Remove the top element from the stack
            int temp = stack.Pop();
            
            // Recursively call Sort to sort the remaining elements
            Sort(stack);
            
            // Insert the removed element back in the sorted order
            InsertSorted(stack, temp);
        }
        return stack;
    }

    // Helper method to insert an element into a sorted stack
    private static void InsertSorted(Stack<int> stack, int element)
    {
        // Check if stack is empty or top element is smaller or equal
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            // Push the element onto the stack
            stack.Push(element);
            return;
        }

        // Remove the top element from the stack
        int temp = stack.Pop();
        
        // Recursively call InsertSorted to find the correct position
        InsertSorted(stack, element);
        
        // Push the removed element back to restore stack order
        stack.Push(temp);
    }

    public static void Main(string[] args)
    {
        // Create a new stack of integers
        Stack<int> stack = new Stack<int>();
        
        // Push elements onto the stack
        stack.Push(34);
        stack.Push(3);
        stack.Push(31);
        stack.Push(98);
        stack.Push(92);
        stack.Push(23);

        // Print the original stack
        Console.WriteLine("Original Stack:");
        PrintStack(new Stack<int>(stack));

        // Sort the stack
        stack = Sort(stack);

        // Print the sorted stack
        Console.WriteLine("\nSorted Stack:");
        PrintStack(stack);
    }

    // Method to print the stack elements
    private static void PrintStack(Stack<int> stack)
    {
        // Iterate through the stack and print each element
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
