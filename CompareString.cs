using System;

class CompareStrings
{
    static int Compare(string str1, string str2)
    {
        int len1 = str1.Length, len2 = str2.Length, minLen = len1 < len2 ? len1 : len2;

        for (int i = 0; i < minLen; i++)
        {
            if (str1[i] < str2[i])
                return -1;
            if (str1[i] > str2[i])
                return 1;
        }
        return len1 == len2 ? 0 : (len1 < len2 ? -1 : 1);
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int result = Compare(str1, str2);
        if (result == 0)
            Console.WriteLine("Both strings are equal.");
        else if (result == -1)
            Console.WriteLine($"\"{str1}\" comes before \"{str2}\".");
        else
            Console.WriteLine($"\"{str1}\" comes after \"{str2}\".");
    }
}
