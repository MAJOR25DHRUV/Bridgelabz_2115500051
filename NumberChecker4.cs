using System;

namespace NumberCheckerQuestion4
{
    public class NumberChecker
    {
        // Method to count digits in a number
        public static int CountDigits(int number)
        {
            // Handle negative numbers
            number = Math.Abs(number);
            
            if (number == 0)
                return 1;
                
            int count = 0;
            while (number > 0)
            {
                count++;
                number = number / 10;
            }
            return count;
        }

        // Method to store digits in array
        public static int[] GetDigitsArray(int number)
        {
            int digitCount = CountDigits(number);
            int[] digits = new int[digitCount];
            
            // Handle negative numbers
            number = Math.Abs(number);
            
            for (int i = digitCount - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number = number / 10;
            }
            return digits;
        }

        // Method to reverse digits array
        public static int[] ReverseDigitsArray(int[] digits)
        {
            int[] reversed = new int[digits.Length];
            
            // Copy array in reverse order
            for (int i = 0; i < digits.Length; i++)
            {
                reversed[i] = digits[digits.Length - 1 - i];
            }
            return reversed;
        }

        // Method to compare two arrays
        public static bool AreArraysEqual(int[] array1, int[] array2)
        {
            // Check if arrays have same length
            if (array1.Length != array2.Length)
                return false;
                
            // Compare elements
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }
            return true;
        }

        // Method to check if number is palindrome
        public static bool IsPalindrome(int number)
        {
            int[] digits = GetDigitsArray(number);
            int[] reversed = ReverseDigitsArray(digits);
            return AreArraysEqual(digits, reversed);
        }

        // Method to check if number is duck number
        public static bool IsDuckNumber(int number)
        {
            int[] digits = GetDigitsArray(number);
            
            // Check if any digit is zero (except first position)
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] == 0)
                    return true;
            }
            return false;
        }
    }

    class NumberChecker4
    {
        static void TestNumberChecker()
        {
            // Get input from user
            Console.Write("Enter a number to analyze: ");
            string userInput = Console.ReadLine();
            int number;
            
            // Validate input
            if (!int.TryParse(userInput, out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            // Perform number analysis
            Console.WriteLine("\nNumber Analysis Results:");
            Console.WriteLine("------------------------");
            
            // Get digits array
            int[] digits = NumberChecker.GetDigitsArray(number);
            Console.WriteLine("Digits: " + string.Join(", ", digits));
            
            // Get reversed digits
            int[] reversed = NumberChecker.ReverseDigitsArray(digits);
            Console.WriteLine("Reversed: " + string.Join(", ", reversed));
            
            // Check if palindrome
            bool isPalindrome = NumberChecker.IsPalindrome(number);
            Console.WriteLine("Is palindrome: " + isPalindrome);
            
            // Check if duck number
            bool isDuck = NumberChecker.IsDuckNumber(number);
            Console.WriteLine("Is duck number: " + isDuck);
        }

        static void Main(string[] args)
        {
            TestNumberChecker();
        }
    }
}