using System;
using System.Text;

class ConcatenateStrings
{
	public static void Main(string[] args)
	{
		// Defining an array of strings
		string[] words = { "Hello", " ", "World", "!", " ", "Welcome", " ", "to", " ", "C#" };

		// Concatenating all strings efficiently using StringBuilder
		string result = ConcatenateEfficiently(words);

		// Printing the concatenated result
		Console.WriteLine("Concatenated String: " + result);
	}

	// Method to concatenate an array of strings efficiently
	static string ConcatenateEfficiently(string[] words)
	{
		// Creating a StringBuilder instance
		StringBuilder sb = new StringBuilder();

		// Iterating through the array and appending each string to StringBuilder
		foreach (string word in words)
		{
			sb.Append(word);
		}

		// Returning the final concatenated string
		return sb.ToString();
	}
}
