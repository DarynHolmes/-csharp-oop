using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
	class LoudLogger : ILogger
	{
		public void Write(string content)
		{
			Console.WriteLine(content.ToUpper() + "!");
		}

		public string Name()
		{
			return "LoudLogger";
		}
	}
}
