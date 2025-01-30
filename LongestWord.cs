using System;

class LongestWord
{
    static string FindLongestWord(string input)
    {
        int maxLength = 0, start = 0, wordStart = 0, wordLength = 0;
        string longestWord = "";

        for (int i = 0; i <= input.Length; i++)
        {
            if (i < input.Length && input[i] != ' ')
            {
                if (wordLength == 0) 
                    wordStart = i;
                wordLength++;
            }
            else
            {
                if (wordLength > maxLength)
                {
                    maxLength = wordLength;
                    start = wordStart;
                }
                wordLength = 0;
            }
        }

        for (int i = start; i < start + maxLength; i++)
            longestWord += input[i];

        return longestWord;
    }

    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        Console.WriteLine("Longest Word: " + FindLongestWord(input));
    }
}
