using Single_Factory_Pattern;

namespace Simple_Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ILogger? infoLogger = LogFactory.CreateLogger(LogLevel.INFO);
            ILogger? debugLogger = LogFactory.CreateLogger(LogLevel.DEBUG);
            ILogger? errorLogger = LogFactory.CreateLogger(LogLevel.ERROR);
            infoLogger.LogMessage($"This is a Info Log");
            debugLogger.LogMessage($"This is a Debug Log");
            errorLogger.LogMessage($"This is a Error Log");
        }
    }
}