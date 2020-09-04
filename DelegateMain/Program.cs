using System;
using System.Diagnostics.SymbolStore;

namespace DelegateMain
{	
	class Program
	{
		public class Operation
		{
			public delegate int TwoIntegerOperation(int par1, int par2);

			public static int Run(int b1, int b2, TwoIntegerOperation mathOperation)
			{
				return mathOperation(b2, b2);
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("please enter two integers");

			var firstInt = int.Parse(Console.ReadLine());
			var secondInt = int.Parse(Console.ReadLine());

			
			Console.WriteLine("Add result: {0}", Operation.Run(firstInt, secondInt, Add));
			Console.WriteLine("Multiply result: {0}", Operation.Run(firstInt, secondInt, Multiply));
			Console.WriteLine("Union result: {0}", Operation.Run(firstInt, secondInt, Union));

			Console.ReadLine();
		}

		public static int Add(int a, int b)
		{
			return a + b;
		}

		public static int Multiply(int a1, int a2)
		{
			return a1 * a2;
		}

		public static int Union(int a, int b)
		{
			return int.Parse(a.ToString() + b.ToString());
		}

	}

}
