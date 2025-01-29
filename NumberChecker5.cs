using System;

namespace NumberCheckerQuestion5
{
    public class NumberChecker
    {
        // Method to check if number is prime
        public static bool IsPrimeNumber(int number)
        {
            // Handle special cases
            if (number <= 1) 
                return false;
            if (number <= 3) 
                return true;
            if (number % 2 == 0 || number % 3 == 0) 
                return false;
            
            // Check for divisibility up to square root
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        // Method to check if number is neon number
        public static bool IsNeonNumber(int number)
        {
            // Calculate square
            int square = number * number;
            
            // Calculate sum of digits of square
            int sum = 0;
            while (square > 0)
            {
                sum += square % 10;
                square = square / 10;
            }
            
            return sum == number;
        }

        // Method to check if number is spy number
        public static bool IsSpyNumber(int number)
        {
            int sum = 0;
            int product = 1;
            
            // Calculate sum and product of digits
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                product *= digit;
                number = number / 10;
            }
            
            return sum == product;
        }

        // Method to check if number is automorphic
        public static bool IsAutomorphicNumber(int number)
        {
            // Calculate square
            long square = (long)number * number;
            
            // Check if square ends with the number
            while (number > 0)
            {
                if (number % 10 != square % 10)
                    return false;
                    
                number = number / 10;
                square = square / 10;
            }
            
            return true;
        }

        // Method to check if number is buzz number
        public static bool IsBuzzNumber(int number)
        {
            return (number % 7 == 0) || (number % 10 == 7);
        }
    }

    class NumberChecker5
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
            
            // Check if prime
            bool isPrime = NumberChecker.IsPrimeNumber(number);
            Console.WriteLine("Is prime number: " + isPrime);
            
            // Check if neon
            bool isNeon = NumberChecker.IsNeonNumber(number);
            Console.WriteLine("Is neon number: " + isNeon);
            
            // Check if spy
            bool isSpy = NumberChecker.IsSpyNumber(number);
            Console.WriteLine("Is spy number: " + isSpy);
            
            // Check if automorphic
            bool isAutomorphic = NumberChecker.IsAutomorphicNumber(number);
            Console.WriteLine("Is automorphic number: " + isAutomorphic);
            
            // Check if buzz
            bool isBuzz = NumberChecker.IsBuzzNumber(number);
            Console.WriteLine("Is buzz number: " + isBuzz);
        }

        static void Main(string[] args)
        {
            TestNumberChecker();
        }
    }
}