using System;

class RemoveCharacter
{
    static string RemoveChar(string input, char remove)
    {
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != remove)
                result += input[i];
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter character to remove: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("Modified String: " + RemoveChar(input, ch));
    }
}
