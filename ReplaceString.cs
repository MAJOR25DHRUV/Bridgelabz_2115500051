using System;

class ReplaceWord
{
    static string Replace(string sentence, string oldWord, string newWord)
    {
        int i = 0, j = 0, matchIndex = -1;
        char[] result = new char[sentence.Length + newWord.Length]; 
        int resultIndex = 0;

        while (i < sentence.Length)
        {
            if (sentence[i] == oldWord[j])
            {
                if (matchIndex == -1)
                    matchIndex = i;

                j++;

                if (j == oldWord.Length) // Full match found
                {
                    for (int k = 0; k < newWord.Length; k++)
                        result[resultIndex++] = newWord[k];

                    matchIndex = -1;
                    j = 0;
                }
            }
            else
            {
                if (matchIndex != -1)
                {
                    for (int k = matchIndex; k < i; k++)
                        result[resultIndex++] = sentence[k];

                    matchIndex = -1;
                    j = 0;
                }
                result[resultIndex++] = sentence[i];
            }
            i++;
        }

        string finalString = "";
        for (int k = 0; k < resultIndex; k++)
            finalString += result[k];

        return finalString;
    }

    static void Main()
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        string modifiedSentence = Replace(sentence, oldWord, newWord);
        Console.WriteLine("Modified Sentence: " + modifiedSentence);
    }
}
