using System;

class MostFrequentCharacter
{
    static char FindMostFrequent(string input)
    {
        int[] freq = new int[256]; 
        char mostFrequent = '\0';
        int maxCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            freq[input[i]]++;
            if (freq[input[i]] > maxCount)
            {
                maxCount = freq[input[i]];
                mostFrequent = input[i];
            }
        }
        return mostFrequent;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Most Frequent Character: " + FindMostFrequent(input));
    }
}
