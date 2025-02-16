using System;
using System.Diagnostics;
using System.Text;

class CompareStringPerformance
{
	public static void Main(string[] args)
	{
		// Defining the number of iterations
		int iterations = 100000;

		// Measuring performance of string concatenation
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		string result = "";
		for (int i = 0; i < iterations; i++)
		{
			result += "a"; 
		}
		stopwatch.Stop();
		Console.WriteLine("String Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");

		// Measuring performance of StringBuilder
		stopwatch.Restart();
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < iterations; i++)
		{
			sb.Append("a"); 
		}
		stopwatch.Stop();
		Console.WriteLine("StringBuilder Time: " + stopwatch.ElapsedMilliseconds + " ms");
	}
}
