using Factory_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class InfoLogger : ILogger
    {
        public void LogMessage(string message)
        {
           Console.WriteLine($"Info:{message}");
        }
    }
}
