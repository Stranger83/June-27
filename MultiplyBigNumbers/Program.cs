using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var num1 = Console.ReadLine().TrimStart('0').Reverse().ToArray();
			var num2 = int.Parse(Console.ReadLine());
			if (num1.Equals('0') || num2 == 0)
			{
				Console.WriteLine("0");
				return;
			}
			var sb = new StringBuilder();
			var numToAdd = 0;
			var remainder = 0;
			for (int i = 0; i < num1.Length; i++)
			{
				int currentResult = int.Parse(num1[i].ToString()) * num2 + remainder;
				if (currentResult >= 10)
				{
					numToAdd = currentResult % 10;
				}
				else
				{
					numToAdd = currentResult;
				}
				remainder = currentResult / 10;
				sb.Append(numToAdd);
			}
			if (remainder > 0)
			{
				sb.Append(remainder);
			}
			var result = new string(sb.ToString().Reverse().ToArray());
			Console.WriteLine(result);
		}
	}
}
