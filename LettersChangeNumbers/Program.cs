using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var strings = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			var sum = 0m;
			foreach (var str in strings)
			{
				var firstLetter = str.First();
				var lastLetter = str.Last();
				var number = decimal.Parse(str.Substring(1, str.Length - 2));

				if (char.IsUpper(firstLetter))
				{
					number /= firstLetter - ('A' - 1);
				}
				else
				{
					number *= firstLetter - ('a' - 1);
				}
				if (char.IsUpper(lastLetter))
				{
					number -= lastLetter - ('A' - 1);
				}
				else
				{
					number += lastLetter - ('a' - 1);
				}
				sum += number;
			}
			Console.WriteLine($"{sum:f2}");
		}
	}
}
