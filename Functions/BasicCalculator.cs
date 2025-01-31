using System;

class BasicCalculator
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the first num: ");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the sec num :");
		int n2 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter the operation u have to perform ,for addition type + ,for subtraction type - ,for division type /,for multiplication type *");
		char operation = Console.ReadKey().KeyChar;
		Console.WriteLine();
		switch(operation)
		{
			case '+':
				int addition  = Add(n,n2);
				Console.WriteLine(string.Format("Addition of {0},{1} is {2}",n,n2,addition));
				break;
			case '-':
				int sub  = Sub(n,n2);
				Console.WriteLine(string.Format("Subtraction of {0},{1} is {2}",n,n2,sub));
				break;
			case '/':
				if(n2==0){
					Console.WriteLine("Division cannot be done, pls enter the value other than 0");
				}
				else{
				int div   = Div(n,n2);
				Console.WriteLine(string.Format("Division of {0},{1} is {2}",n,n2,div));
				}
				break;
			case '*':
				int mul = Mul(n,n2);
				Console.WriteLine(string.Format("Multiplication of {0},{1} is {2}",n,n2,mul));
				break;
			default:
				Console.WriteLine("pls choose from the following operation");
				break;
		}
	}
	static int Add(int n,int n2)
	{
		return (n+n2);
	}
	static int Sub(int n,int n2)
	{
		return (n-n2);
	}
	static int Div(int n,int n2)
	{
		return (n/n2);
	}
	static int Mul(int n,int n2)
	{
		return (n*n2);
	}
}