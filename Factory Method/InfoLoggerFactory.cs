using Factory_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class InfoLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new InfoLogger();
        }
    }
}
