using Single_Factory_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class DebugLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new DebugLogger();
        }
    }
}
