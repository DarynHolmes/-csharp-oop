using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
	interface ILogger
	{
		void Write(string content);
		string Name();
	}
}
