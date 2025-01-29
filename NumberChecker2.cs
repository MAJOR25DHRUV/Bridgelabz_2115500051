using System;

namespace NumberCheckerQuestion1
{
    // Utility class for number checking operations
    public class NumberChecker
    {
        // Method to count digits in a number
        public static int CountDigits(int number)
        {
            // Handle negative numbers by converting to positive
            number = Math.Abs(number);
            
            // Handle zero as a special case
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
            // Get count of digits
            int digitCount = CountDigits(number);
            int[] digits = new int[digitCount];
            
            // Handle negative numbers
            number = Math.Abs(number);
            
            // Store digits in reverse order
            for (int i = digitCount - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number = number / 10;
            }
            return digits;
        }

        // Method to check if number is a duck number
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

        // Method to check if number is Armstrong number
        public static bool IsArmstrongNumber(int number)
        {
            int[] digits = GetDigitsArray(number);
            int sum = 0;
            int power = digits.Length;
            
            // Calculate sum of digits raised to power
            for (int i = 0; i < digits.Length; i++)
            {
                sum += (int)Math.Pow(digits[i], power);
            }
            
            return sum == Math.Abs(number);
        }

        // Method to find largest and second largest digits
        public static int[] FindTwoLargestDigits(int number)
        {
            int[] digits = GetDigitsArray(number);
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            
            // Find largest and second largest
            foreach (int digit in digits)
            {
                if (digit > largest)
                {
                    secondLargest = largest;
                    largest = digit;
                }
                else if (digit > secondLargest && digit < largest)
                {
                    secondLargest = digit;
                }
            }
            
            return new int[] { largest, secondLargest };
        }

        // Method to find smallest and second smallest digits
        public static int[] FindTwoSmallestDigits(int number)
        {
            int[] digits = GetDigitsArray(number);
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;
            
            // Find smallest and second smallest
            foreach (int digit in digits)
            {
                if (digit < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digit;
                }
                else if (digit < secondSmallest && digit > smallest)
                {
                    secondSmallest = digit;
                }
            }
            
            return new int[] { smallest, secondSmallest };
        }
    }

    class NumberChecker2
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
            
            // Count digits
            int digitCount = NumberChecker.CountDigits(number);
            Console.WriteLine("Number of digits: " + digitCount);
            
            // Check if duck number
            bool isDuck = NumberChecker.IsDuckNumber(number);
            Console.WriteLine("Is duck number: " + isDuck);
            
            // Check if Armstrong number
            bool isArmstrong = NumberChecker.IsArmstrongNumber(number);
            Console.WriteLine("Is Armstrong number: " + isArmstrong);
            
            // Find largest and second largest
            int[] largestTwo = NumberChecker.FindTwoLargestDigits(number);
            Console.WriteLine("Largest digit: " + largestTwo[0]);
            Console.WriteLine("Second largest digit: " + largestTwo[1]);
            
            // Find smallest and second smallest
            int[] smallestTwo = NumberChecker.FindTwoSmallestDigits(number);
            Console.WriteLine("Smallest digit: " + smallestTwo[0]);
            Console.WriteLine("Second smallest digit: " + smallestTwo[1]);
        }

        static void Main(string[] args)
        {
            TestNumberChecker();
        }
    }
}