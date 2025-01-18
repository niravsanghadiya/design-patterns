using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Factory_Pattern
{
    public class LogFactory
    {
        public static ILogger? CreateLogger(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.DEBUG:
                    return new DebugLogger();                 
                case LogLevel.INFO:
                    return new InfoLogger();
                case LogLevel.ERROR:
                    return new ErrorLogger();
                default:
                    return null;

            }
        }

    }
}
