using System;

class PalindromeCheck
{
    static bool IsPalindrome(string input)
    {
        int left = 0, right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
                return false;
            left++;
            right--;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine(IsPalindrome(input) ? "Palindrome" : "Not a Palindrome");
    }
}
