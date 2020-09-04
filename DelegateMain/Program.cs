using System;

namespace DelegateMain
{	
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("please enter two integers");

			var firstInt = int.Parse(Console.ReadLine());
			var secondInt = int.Parse(Console.ReadLine());

			Console.WriteLine("Add result: {0}", Add(firstInt, secondInt));
			Console.WriteLine("Multiply result: {0}", Multiply(firstInt, secondInt));
			Console.WriteLine("Union result: {0}", Union(firstInt, secondInt));

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
			return a * 10 + b;
		}

	}

}
