using System;

class PrintFib
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the number : " );
		int num = int.Parse(Console.ReadLine());
		
		Console.WriteLine("fibonacci series " );
		Fibonacci(num);
	
	}
	
	static void Fibonacci(int num)
	{
	int n0 = 0;
	int n1 = 1;
	int n3;
	for(int i=0;i<num;i++)
	{
		Console.WriteLine(n0+" ");
		n3 = n0+n1;
		n0 = n1;
		n1 = n3;
	}
	}
	
}
		