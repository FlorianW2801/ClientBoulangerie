using System;

namespace WhatIsAnException
{
	class Program
	{
		static void Main(string[] args)
		{
			ThrowCodeException();
			//ThrowManualException();
			//ThrowExceptionFromClass();
		}

		static void ThrowManualException()
		{
			Console.WriteLine("Do you want to throw an exception? (Y/N)");
			var answer = Console.ReadLine();
			if (answer == "Y")
			{
				throw new Exception("I am become exception, the destroyer of code execution");
			}
			Console.WriteLine("Have a nice day :^)");
		}

		static void ThrowCodeException()
		{
			Console.WriteLine("Do you want to divide by zero? (Y/N)");
			var answer = Console.ReadLine();
			if (answer == "Y")
			{
				var min = Math.Min(4, 0);
				var result = 17 / min;
			}
			Console.WriteLine("phew, close one :^)");
		}

		static void ThrowExceptionFromClass()
		{
			var littleKiddy = new LittleKiddy();
			Console.WriteLine("Do you want to give littleKiddy his toy? (Y/N)");
			var answer = Console.ReadLine();
			if (answer != "Y")
			{
				littleKiddy.NotHappy();
			}
			littleKiddy.Happy();
			Console.WriteLine("Ooh, he's such a good boy :^)");
		}
	}
}
