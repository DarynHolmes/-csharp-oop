using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
	class ConsoleLogger : ILogger
	{
		public void Write(string desc)
		{
			var dateTime = DateTime.Now;
			var dateTimeString = dateTime.ToShortTimeString();
			Console.WriteLine($"{dateTimeString}: {desc}");
		}

		public string Name()
		{
			return "ConsoleLogger";
		}
	}
}
