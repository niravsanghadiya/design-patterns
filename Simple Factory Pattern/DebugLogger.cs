using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Factory_Pattern
{
    public class DebugLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Debug :{message}");
        }
    }
}
