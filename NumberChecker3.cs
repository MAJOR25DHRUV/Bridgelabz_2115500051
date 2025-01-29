using System;

namespace NumberCheckerQuestion3
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

        // Method to find sum of digits
        public static int GetDigitSum(int number)
        {
            int[] digits = GetDigitsArray(number);
            int sum = 0;
            
            // Calculate sum of digits
            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }
            return sum;
        }

        // Method to find sum of squares of digits
        public static int GetDigitSquareSum(int number)
        {
            int[] digits = GetDigitsArray(number);
            int sum = 0;
            
            // Calculate sum of squares of digits
            for (int i = 0; i < digits.Length; i++)
            {
                sum += (int)Math.Pow(digits[i], 2);
            }
            return sum;
        }

        // Method to check if number is Harshad number
        public static bool IsHarshadNumber(int number)
        {
            int digitSum = GetDigitSum(number);
            return number % digitSum == 0;
        }

        // Method to find frequency of each digit
        public static int[,] GetDigitFrequency(int number)
        {
            int[] digits = GetDigitsArray(number);
            int[,] frequency = new int[10, 2];  // 10 possible digits (0-9)
            
            // Initialize first column with digits 0-9
            for (int i = 0; i < 10; i++)
            {
                frequency[i, 0] = i;
                frequency[i, 1] = 0;
            }
            
            // Count frequency of each digit
            foreach (int digit in digits)
            {
                frequency[digit, 1]++;
            }
            
            return frequency;
        }
    }

    class NumberChecker3
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
            
            // Get digit count and sum
            int digitCount = NumberChecker.CountDigits(number);
            int digitSum = NumberChecker.GetDigitSum(number);
            Console.WriteLine("Number of digits: " + digitCount);
            Console.WriteLine("Sum of digits: " + digitSum);
            
            // Get sum of squares
            int squareSum = NumberChecker.GetDigitSquareSum(number);
            Console.WriteLine("Sum of squares of digits: " + squareSum);
            
            // Check if Harshad number
            bool isHarshad = NumberChecker.IsHarshadNumber(number);
            Console.WriteLine("Is Harshad number: " + isHarshad);
            
            // Get digit frequency
            int[,] frequency = NumberChecker.GetDigitFrequency(number);
            Console.WriteLine("\nDigit Frequency:");
            Console.WriteLine("Digit | Count");
            Console.WriteLine("-------------");
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i, 1] > 0)
                {
                    Console.WriteLine("  " + frequency[i, 0] + "   |   " + frequency[i, 1]);
                }
            }
        }

        static void Main(string[] args)
        {
            TestNumberChecker();
        }
    }
}