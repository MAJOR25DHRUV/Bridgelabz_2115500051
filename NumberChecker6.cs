using System;

namespace NumberCheckerQuestion6
{
    public class NumberChecker
    {
        // Method to find factors of a number
        public static int[] GetFactors(int number)
        {
            // First pass to count factors
            int factorCount = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    factorCount++;
            }
            
            // Create array and store factors
            int[] factors = new int[factorCount];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }
            return factors;
        }

        // Method to find greatest factor
        public static int GetGreatestFactor(int number)
        {
            int[] factors = GetFactors(number);
            return factors[factors.Length - 2];  // Second last element (last is number itself)
        }

        // Method to find sum of factors
        public static int GetFactorSum(int number)
        {
            int[] factors = GetFactors(number);
            int sum = 0;
            
            // Sum all factors except the number itself
            for (int i = 0; i < factors.Length - 1; i++)
            {
                sum += factors[i];
            }
            return sum;
        }

        // Method to find product of factors
        public static long GetFactorProduct(int number)
        {
            int[] factors = GetFactors(number);
            long product = 1;
            
            foreach (int factor in factors)
            {
                product *= factor;
            }
            return product;
        }

        // Method to find product of cubes of factors
        public static double GetFactorCubesProduct(int number)
        {
            int[] factors = GetFactors(number);
            double product = 1;
            
            foreach (int factor in factors)
            {
                product *= Math.Pow(factor, 3);
            }
            return product;
        }

        // Method to check if number is perfect
        public static bool IsPerfectNumber(int number)
        {
            return GetFactorSum(number) == number;
        }

        // Method to check if number is abundant
        public static bool IsAbundantNumber(int number)
        {
            return GetFactorSum(number) > number;
        }

        // Method to check if number is deficient
        public static bool IsDeficientNumber(int number)
        {
            return GetFactorSum(number) < number;
        }

        // Method to calculate factorial
        private static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        // Method to check if number is strong
        public static bool IsStrongNumber(int number)
        {
            int originalNumber = number;
            int sum = 0;
            
            while (number > 0)
            {
                sum += Factorial(number % 10);
                number = number / 10;
            }
            
            return sum == originalNumber;
        }
    }

    class NumberChecker6
    {
        static void TestNumberChecker()
        {
            // Get input from user
            Console.Write("Enter a number to analyze: ");
            string userInput = Console.ReadLine();
            int number;
            
            // Validate input
            if (!int.TryParse(userInput, out number) || number <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            // Perform factor analysis
            Console.WriteLine("\nFactor Analysis Results:");
            Console.WriteLine("------------------------");
            
            // Get and display factors
            int[] factors = NumberChecker.GetFactors(number);
            Console.WriteLine("Factors: " + string.Join(", ", factors));
            
            // Display greatest factor
            Console.WriteLine("Greatest factor: " + NumberChecker.GetGreatestFactor(number));
            
            // Display factor sum and product
            Console.WriteLine("Sum of factors: " + NumberChecker.GetFactorSum(number));
            Console.WriteLine("Product of factors: " + NumberChecker.GetFactorProduct(number));
            
            // Check number properties
            Console.WriteLine("\nNumber Properties:");
            Console.WriteLine("Is perfect number: " + NumberChecker.IsPerfectNumber(number));
            Console.WriteLine("Is abundant number: " + NumberChecker.IsAbundantNumber(number));
            Console.WriteLine("Is deficient number: " + NumberChecker.IsDeficientNumber(number));
            Console.WriteLine("Is strong number: " + NumberChecker.IsStrongNumber(number));
        }

        static void Main(string[] args)
        {
            TestNumberChecker();
        }
    }
}