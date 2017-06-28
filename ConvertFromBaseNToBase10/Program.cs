using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBaseNToBase10
{
	class Program
	{
		static void Main(string[] args)
		{
			var nums = Console.ReadLine().Split(' ').ToArray();
			var baseN = int.Parse(nums[0]);
			var baseNnum = nums[1].Reverse().ToArray();
			var result = new BigInteger();
			for (int power = 0; power < baseNnum.Length; power++)
			{
				var currentNum = int.Parse(baseNnum[power].ToString());
				result += currentNum * BigInteger.Pow(baseN, power);
			}
			Console.WriteLine(result);
		}
	}
}
