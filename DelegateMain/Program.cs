using System;

namespace DelegateMain
{	
	class Program
	{
		public delegate int TwoIntegerOperation(int par1, int par2);

		static void Main(string[] args)
		{
			Console.WriteLine("please enter two integers");

			var firstInt = int.Parse(Console.ReadLine());
			var secondInt = int.Parse(Console.ReadLine());

			//original 
			var addOperation = new TwoIntegerOperation(Add);
			Console.WriteLine("Add result: {0}", addOperation(firstInt, secondInt));

			//C# 2.0 inline function
			TwoIntegerOperation multiplyOperation = delegate (int a, int b) { return a * b; };
			Console.WriteLine("Multiply result: {0}", multiplyOperation(firstInt, secondInt));

			//C# 3.0 lambda
			TwoIntegerOperation unionOperation = (a, b) => (a * 10 + b);
			Console.WriteLine("Union result: {0}", unionOperation(firstInt, secondInt));

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
