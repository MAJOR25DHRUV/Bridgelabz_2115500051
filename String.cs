using System;
using System.Diagnostics;
using System.Text;

class StringComparison
{
    // String concatenation using + operator
    public static string ConcatenateString(int count)
    {
        string result = "";
        for (int i = 0; i < count; i++)
        {
            result = result + "a";
        }
        return result;
    }

    // String concatenation using StringBuilder
    public static string ConcatenateStringBuilder(int count)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            sb.Append("a");
        }
        return sb.ToString();
    }

   static void Main(string[] args)
    {
        // Test different operation counts
        int[] counts = { 1000, 10000, 100000 };
        
        foreach (int count in counts)
        {
            Console.WriteLine("Operation Count: " + count);
            
            // Number of iterations for more accurate timing
            int iterations = count <= 10000 ? 100 : 10;
            
            double stringTotal = 0;
            double stringBuilderTotal = 0;
            
            for (int iter = 0; iter < iterations; iter++)
            {
                // Measure string concatenation
                Stopwatch sw = new Stopwatch();
                sw.Start();
                ConcatenateString(count);
                sw.Stop();
                stringTotal = stringTotal + ((double)sw.ElapsedTicks / TimeSpan.TicksPerMillisecond);
                
                // Measure StringBuilder
                sw.Reset();
                sw.Start();
                ConcatenateStringBuilder(count);
                sw.Stop();
                stringBuilderTotal = stringBuilderTotal + ((double)sw.ElapsedTicks / TimeSpan.TicksPerMillisecond);
            }
            
            double stringAvg = stringTotal / iterations;
            double stringBuilderAvg = stringBuilderTotal / iterations;
            
            Console.WriteLine("String Concatenation Average Time: " + stringAvg.ToString("F6") + " ms");
            Console.WriteLine("StringBuilder Average Time: " + stringBuilderAvg.ToString("F6") + " ms");
            Console.WriteLine("StringBuilder is " + (stringAvg / stringBuilderAvg).ToString("F2") + "x faster");
            Console.WriteLine("------------------------");
        }
    }
}
