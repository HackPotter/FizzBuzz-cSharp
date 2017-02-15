using System;

namespace FizzBuzz
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Where should FizzBuzz start?");
			int start = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Where should FizzBuzz Stop?");
			int stop = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ($"FizzBuzz from {start} to {stop}:");
			for (int i = start; i <= stop; ++i)
			{
				if (i % 3 == 0)
				{
					Console.Write ("Fizz");
				}
				if (i % 5 == 0)
				{
					Console.Write ("Buzz");
				}
				if (i % 3 != 0 && i % 5 != 0)
				{
					Console.Write(i);
				}
				Console.Write("\n");
			}
		}
	}
}
