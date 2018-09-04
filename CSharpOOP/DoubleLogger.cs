using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
	class DoubleLogger: ILogger
	{
		private readonly ILogger primaryLogger;
		private readonly ILogger secondaryLogger;

		public DoubleLogger(ILogger primaryLogger, ILogger secondaryLogger)
		{
			this.primaryLogger = primaryLogger;
			this.secondaryLogger = secondaryLogger;
		}

		public void Write(string content)
		{
			
			primaryLogger.Write(content);
			secondaryLogger.Write(content);
		}

		public string Name()
		{
			throw new NotImplementedException();
		}
	}
}
