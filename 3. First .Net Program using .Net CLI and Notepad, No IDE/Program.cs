using System;

namespace MyFirstProgram
{
	public class Program
	{
		public static void Main()
		{
			string fullName = "james bond";
			int age = 10;
			
			int number1;
			int number2;
			int result;
			
			number1 = 10;
			number2 = 20;
			
			result = number1 + number2;
			
			Console.WriteLine("my name is" + fullName);
			Console.WriteLine("age is "+ age);
			Console.WriteLine("the result is "+ result);
			Console.WriteLine("Hello World!");
		}
	}
}