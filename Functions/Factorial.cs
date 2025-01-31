using System;

class Factorial
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int n = int.Parse(Console.ReadLine());

        

        int result = FactorialPrint(n);
		Console.WriteLine(string.Format("Factorial series of the given number:{0}",result));
		
	}
    static int FactorialPrint(int n)
    {
        if (n == 0 || n == 1) return 1; 
        return n * FactorialPrint(n - 1);
    }
}
