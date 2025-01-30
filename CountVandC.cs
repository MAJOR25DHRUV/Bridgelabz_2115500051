using System;

class CountVowelsConsonants
{
    static void CountCharacters(string input, out int vowels, out int consonants)
    {
        vowels = 0;
        consonants = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            // Convert uppercase to lowercase manually
            if (ch >= 'A' && ch <= 'Z')
                ch = (char)(ch + 32);

            if (ch >= 'a' && ch <= 'z')
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowels++;
                else
                    consonants++;
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int vowels, consonants;

        CountCharacters(input, out vowels, out consonants);

        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }
}
