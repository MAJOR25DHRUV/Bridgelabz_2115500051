using System;
using System.Text;
using System.Collections.Generic;

class StringBuilderProblem2
{
	public static void Main(string[] args)
	{
		// Asking user for input
		Console.WriteLine("Enter the string: ");
		
		// Reading the input string
		string str = Console.ReadLine();
		
		// Creating a StringBuilder instance with the user input
		StringBuilder sb = new StringBuilder(RemoveDuplicates(str.ToLower()));
		
		// Printing the modified string
		Console.WriteLine("String after removing duplicates: " + sb);
	}
	
	// Method to remove duplicate characters from a string
	static string RemoveDuplicates(string str)
	{
		// HashSet to store unique characters
		HashSet<char> seen = new HashSet<char>();
		
		// StringBuilder to construct the result
		StringBuilder result = new StringBuilder();
		
		// Iterating through the input string
		foreach (char c in str)
		{
			// If character is not already seen, add it to result
			if (!seen.Contains(c))
			{
				seen.Add(c);
				result.Append(c);
			}
		}
		
		// Returning the string without duplicates
		return result.ToString();
	}
}
