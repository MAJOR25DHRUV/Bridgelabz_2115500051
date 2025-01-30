using System;

class ToggleCase
{
    static string ToggleCaseCharacters(string input)
    {
        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (ch >= 'A' && ch <= 'Z') // Convert to lowercase
                result[i] = (char)(ch + 32);
            else if (ch >= 'a' && ch <= 'z') // Convert to uppercase
                result[i] = (char)(ch - 32);
            else
                result[i] = ch;
        }

        string finalString = "";
        for (int i = 0; i < result.Length; i++)
            finalString += result[i];

        return finalString;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Toggled Case: " + ToggleCaseCharacters(input));
    }
}
