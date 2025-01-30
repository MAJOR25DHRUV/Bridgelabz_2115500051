using System;

class ReverseString
{
    static string Reverse(string input)
    {
        char[] reversed = new char[input.Length];
        int j = 0;

        for (int i = input.Length - 1; i >= 0; i--) 
        {
            reversed[j++] = input[i];
        }

        string result = "";
        for (int k = 0; k < reversed.Length; k++)
            result += reversed[k];

        return result;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Reversed String: " + Reverse(input));
    }
}
