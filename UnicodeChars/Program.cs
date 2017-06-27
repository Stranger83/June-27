using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeChars
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var chars = input.Select(c => (int)c).Select(c => $"\\u{c:x4}");
			Console.WriteLine(string.Concat(chars));
			
		}
	}
}
