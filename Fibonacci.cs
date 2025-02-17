using System;
using System.Diagnostics;

class FibonacciComparison
{
     // Recursive Fibonacci 
    public static long FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Iterative Fibonacci 
    public static long FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;
            
        long a = 0, b = 1, temp;
        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }

    static void Main(string[] args)
    {
        // Test different values of n
        int[] numbers = { 10, 20, 30 }; // Adjusted for better comparison
        
        foreach (int n in numbers)
        {
            Console.WriteLine("Fibonacci Number: " + n);
            
            // Number of iterations for more accurate timing
            int iterations = n <= 20 ? 1000 : 100;
            
            double recursiveTotal = 0;
            double iterativeTotal = 0;
            
            for (int iter = 0; iter < iterations; iter++)
            {
                // Measure recursive approach
                Stopwatch sw = new Stopwatch();
                sw.Start();
                long recursiveResult = FibonacciRecursive(n);
                sw.Stop();
                recursiveTotal = recursiveTotal + ((double)sw.ElapsedTicks / TimeSpan.TicksPerMillisecond);
                
                // Measure iterative approach
                sw.Reset();
                sw.Start();
                long iterativeResult = FibonacciIterative(n);
                sw.Stop();
                iterativeTotal = iterativeTotal + ((double)sw.ElapsedTicks / TimeSpan.TicksPerMillisecond);
            }
            
            double recursiveAvg = recursiveTotal / iterations;
            double iterativeAvg = iterativeTotal / iterations;
            
            Console.WriteLine("Recursive Average Time: " + recursiveAvg.ToString("F6") + " ms");
            Console.WriteLine("Iterative Average Time: " + iterativeAvg.ToString("F6") + " ms");
            Console.WriteLine("Iterative is " + (recursiveAvg / iterativeAvg).ToString("F2") + "x faster");
            Console.WriteLine("------------------------");
        }
    }
}
