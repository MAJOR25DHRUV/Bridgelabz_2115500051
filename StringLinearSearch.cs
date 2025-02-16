using System;

class LinearSearchSentences
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the number of sentences
        Console.WriteLine("Enter the number of sentences: ");
        // Read the input size and convert it to an integer
        int size = int.Parse(Console.ReadLine());

        // Declare an array to store the sentences
        string[] sentences = new string[size];

        // Prompt the user to enter the sentences
        Console.WriteLine("Enter the sentences:");
        // Loop to read each sentence and store it in the array
        for (int i = 0; i < size; i++)
        {
            sentences[i] = Console.ReadLine();
        }

        // Prompt the user to enter the word to search for
        Console.WriteLine("Enter the word to search for: ");
        // Read the search word
        string searchWord = Console.ReadLine();

        // Call the function to search for the word in the sentences
        SearchWordInSentences(sentences, searchWord);
    }

    // Method to search for a word in an array of sentences
    static void SearchWordInSentences(string[] sentences, string searchWord)
    {
        // Loop through each sentence in the array
        for (int i = 0; i < sentences.Length; i++)
        {
            // Check if the current sentence contains the search word
            if (sentences[i].Contains(searchWord))
            {
                // Print the first sentence that contains the word
                Console.WriteLine("First sentence containing the word: " + sentences[i]);
                // Stop searching after finding the first match
                return;
            }
        }

        // If no sentence contains the word, print a message
        Console.WriteLine("No sentence contains the word.");
    }
}
