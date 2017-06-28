using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
	class Program
	{
		static void Main(string[] args)
		{
			var words = Console.ReadLine().Split();
			var word1 = words[0];
			var word2 = words[1];
			var sum = 0;
			for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
			{
				if (i >= word1.Length)
				{
					sum += (int)word2[i];
				} else if (i >= word2.Length)
				{
					sum += (int)word1[i];
				}
				else
				{
					sum += (int)word1[i] * (int)word2[i];
				}
			}
			Console.WriteLine(sum);
		}
	}
}
