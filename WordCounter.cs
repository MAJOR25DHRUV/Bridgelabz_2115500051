using System;
using System.IO;

class WordCounter
{
	public static void Main(string[] args)
	{
		// Define the file path (Change this to your actual file path)
		string filePath = "WordCounter.txt";

		// Define the word to search for
		Console.Write("Enter the word to count: ");
		string targetWord = Console.ReadLine().ToLower(); // Convert to lowercase for case-insensitive comparison

		// Call the method to count occurrences
		int count = CountWordOccurrences(filePath, targetWord);

		// Display the result
		Console.WriteLine("The word '" + targetWord + "' appears " + count + " times in the file.");
	}

	// Method to count word occurrences in a file
	static int CountWordOccurrences(string filePath, string targetWord)
	{
		int count = 0;

		try
		{
			// Open the file using StreamReader
			using (StreamReader reader = new StreamReader(filePath))
			{
				string line;
				
				// Read the file line by line
				while ((line = reader.ReadLine()) != null)
				{
					// Convert the line to lowercase and split it into words
					string[] words = line.ToLower().Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '"', '\'', '(', ')', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

					// Count occurrences of the target word
					foreach (string word in words)
					{
						if (word == targetWord)
						{
							count++;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
		}

		return count;
	}
}
