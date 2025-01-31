using System;

class Factors
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter first number:");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter sec number:");
		int b = int.Parse(Console.ReadLine());
		
		int gcf = FindGCF(a,b);
		int lcm = FindLCM(a,b);
	
		Console.WriteLine(string.Format("The Greatest comman factor of {0},{1} is {2}",a,b,gcf));
		Console.WriteLine(string.Format("The Largest comman factor of {0},{1} is {2}",a,b,lcm));
		
	}
	static int FindGCF(int a,int b)
	{
		while(b!=0)
		{
			int temp = b;
			b = a%b;
			a= temp;
		}
		return a;
		
	}
	static int FindLCM(int a,int b)
	{
		return (a*b)/FindGCF(a,b);
	}
}