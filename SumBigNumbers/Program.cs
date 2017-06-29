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
			var rem = 0;
			for (int i = 0; i < shorterNum.Length; i++)
			{
				int currentSum = int.Parse(num1[i].ToString()) + int.Parse(num2[i].ToString()) + rem;
				if (currentSum >= 10)
				{
					numToAdd = currentSum % 10;
					rem = 1;
				}
				else
				{
					numToAdd = currentSum;
					rem = 0;
				}
				sb.Append(numToAdd);
			}
			for (int i = shorterNum.Length; i < longerNum.Length; i++)
			{
				var currentNum = int.Parse(longerNum[i].ToString()) + rem;
				if (currentNum >= 10)
				{
					numToAdd = currentNum % 10;
					rem = 1;
				}
				else
				{
					numToAdd = currentNum;
					rem = 0;
				}
				sb.Append(numToAdd);
			}
			if (rem > 0)
			{
				sb.Append(rem);
			}
			var result = new string(sb.ToString().Reverse().ToArray());
			Console.WriteLine(result.TrimStart('0'));
		}
	}
}