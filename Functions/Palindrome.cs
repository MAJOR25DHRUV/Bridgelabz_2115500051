using System;

class Palindrome
{
	static void Main(string[] args)
	{
		string str = Input();
		bool isPalindrome = CheckPalindrome(str);
		PrintString(str, isPalindrome);
	}
	static string Input()
	{
		Console.WriteLine("Enter the string: ");
		return Console.ReadLine().ToLower().Replace(" ","");
	}
	
	static bool CheckPalindrome(string str)
	{
		int left = 0;
		int right = str.Length-1;
		while(left<right)
		{
			if(str[left]!=str[right])
				return false;
		left++;
		right--;
		}
		return true;
		
	}
	
	static void PrintString(string str , bool isPalindrome)
	{
		if(isPalindrome)
		{
			Console.WriteLine(str+"is palindrom");
		}
		else
		{
			Console.WriteLine(str+"is not palindrome");
		}
	}
}
	