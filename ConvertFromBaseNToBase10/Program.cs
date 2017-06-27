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
			var baseNnum = nums[1];
			var result = 0.0;
			for (int i = 0; i < baseNnum.Length; i++)
			{
				result += int.Parse(baseNnum[baseNnum.Length - 1 - i].ToString()) * Math.Pow(baseN, i);
			}
			Console.WriteLine(result);
		}
	}
}
