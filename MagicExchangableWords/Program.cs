using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangableWords
{
	class Program
	{
		static void Main(string[] args)
		{
			var words = Console.ReadLine().Split();
			var word1 = words[0];
			var word2 = words[1];
			var longerWord = word1.Length > word2.Length ? word1 : word2;
			var shorterWord = longerWord == word1 ? word2 : word1;
			
			var charDict = new Dictionary<char, char>();
			bool isExchangeable = true;
			for (int i = 0; i < shorterWord.Length; i++)
			{
				if (!charDict.ContainsKey(shorterWord[i]))
				{
					if (!charDict.ContainsValue(longerWord[i]))
					{
						charDict[shorterWord[i]] = longerWord[i];
					}
					else
					{
						isExchangeable = false;
					}
					
				}
				else
				{
					if (!(charDict[shorterWord[i]] == longerWord[i]))
					{
						isExchangeable = false;
					}
				}
			}
			for (int i = shorterWord.Length; i < longerWord.Length; i++)
			{
				if (!charDict.ContainsValue(longerWord[i]))
				{
					isExchangeable = false;
				}
			}
			Console.WriteLine(isExchangeable.ToString().ToLower());
		}
	}
}
