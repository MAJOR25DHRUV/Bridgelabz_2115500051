using System;

class AnagramCheck
{
    static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        int[] count = new int[256];

        for (int i = 0; i < str1.Length; i++)
        {
            count[str1[i]]++;
            count[str2[i]]--;
        }

        for (int i = 0; i < 256; i++)
            if (count[i] != 0)
                return false;

        return true;
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        Console.WriteLine(AreAnagrams(str1, str2) ? "Anagrams" : "Not Anagrams");
    }
}
