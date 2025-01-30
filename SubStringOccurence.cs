using System;

class SubstringOccurrences
{
    static int CountOccurrences(string text, string pattern)
    {
        int count = 0, textLen = text.Length, patLen = pattern.Length;

        for (int i = 0; i <= textLen - patLen; i++)
        {
            bool match = true;
            for (int j = 0; j < patLen; j++)
            {
                if (text[i + j] != pattern[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
                count++;
        }
        return count;
    }

    static void Main()
    {
        Console.Write("Enter main string: ");
        string text = Console.ReadLine();
        Console.Write("Enter substring: ");
        string pattern = Console.ReadLine();

        Console.WriteLine("Occurrences: " + CountOccurrences(text, pattern));
    }
}
