using System;
using System.Text;

class StringBuilderProblem1
{
    static void Main(string[] args)
    {
        // Create a StringBuilder instance with the initial string "Hello"
        StringBuilder sb = new StringBuilder("Hello");
        
        // Reverse the string by converting StringBuilder to string, reversing, and reassigning
        sb = new StringBuilder(ReverseString(sb.ToString()));
        
        // Print the reversed string
        Console.WriteLine(sb);
    }
    
    // Method to reverse a given string
    static string ReverseString(string str)
    {
        // Convert the string to a character array
        char[] charArray = str.ToCharArray();
        // Reverse the character array
        Array.Reverse(charArray);
        // Convert the reversed character array back to a string and return
        return new string(charArray);
    }
}
