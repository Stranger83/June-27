using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var num1 = Console.ReadLine().Reverse().ToArray();
			var num2 = Console.ReadLine().Reverse().ToArray();
			var sb = new StringBuilder();
			var shorterNum = num1.Length > num2.Length ? num2 : num1;
			var longerNum = num1.Length > num2.Length ? num1 : num2;
			var numToAdd = 0;
			var remainder = 0;
			for (int i = 0; i < shorterNum.Length; i++)
			{
				int currentSum = int.Parse(num1[i].ToString()) + int.Parse(num2[i].ToString()) + remainder;
				if (currentSum >= 10)
				{
					numToAdd = currentSum % 10;
				}
				else
				{
					numToAdd = currentSum;
				}
				remainder = currentSum / 10;
				sb.Append(numToAdd);
			}
			for (int i = shorterNum.Length; i < longerNum.Length; i++)
			{
				var currentNum = int.Parse(longerNum[i].ToString()) + remainder;
				if (currentNum >= 10)
				{
					numToAdd = currentNum % 10;
				}
				else
				{
					numToAdd = currentNum;
				}
				remainder = currentNum / 10;
				sb.Append(numToAdd);
			}
			if (remainder > 0)
			{
				sb.Append(remainder);
			}
			var result = new string(sb.ToString().Reverse().ToArray());
			Console.WriteLine(result.TrimStart('0'));
		}
	}
}