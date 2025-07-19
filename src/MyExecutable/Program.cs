using System;
using MyLibrary;

namespace MyExecutable;

internal sealed class Program
{
	public static void Main(string[] args)
	{
		int num1 = 5;
		int num2 = 5;
		var sum = Calculator.Add(num1, num2);
		Console.WriteLine($"The sum of {num1} + {num2} is {sum}.");
	}
}
