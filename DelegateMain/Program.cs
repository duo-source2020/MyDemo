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

			Console.ReadLine();
		}

		public static int Add(int a, int b)
		{
			return a + b;
		}
	}

}
