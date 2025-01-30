using System;

class RemoveDuplicates
{
    static string RemoveDuplicateCharacters(string input)
    {
        char[] result = new char[input.Length];
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < index; j++)
            {
                if (result[j] == input[i])
                {
                    found = true;
                    break;
                }
            }
            if (!found)
                result[index++] = input[i];
        }

        string finalString = "";
        for (int i = 0; i < index; i++)
            finalString += result[i];

        return finalString;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Modified String: " + RemoveDuplicateCharacters(input));
    }
}
