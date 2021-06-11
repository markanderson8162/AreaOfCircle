using System;

namespace AreaOfCircle
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is the radius of your circle?");
			var radius = double.Parse(Console.ReadLine());
			double circleArea = Math.PI * (radius * radius);
			Console.WriteLine($"The area of your circle is {circleArea}");
		}
	}
}
