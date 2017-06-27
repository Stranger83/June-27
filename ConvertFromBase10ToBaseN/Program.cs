using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertFromBase10ToBaseN
{
	class Program
	{
		static void Main(string[] args)
		{
			StringBuilder sb = new StringBuilder();
			var nums = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
			var baseN = nums[0];
			var base10 = nums[1];
			while (base10 > 0)
			{
				var rem = base10 % baseN;
				sb.Append(rem);
				base10 /= baseN;
			}
			Console.WriteLine(new string(sb.ToString().Reverse().ToArray()));
		}
	}
}
