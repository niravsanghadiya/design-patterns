using Single_Factory_Pattern;

namespace Simple_Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ILogger? logger = LogFactory.CreateLogger(LogLevel.INFO);           
            logger.LogMessage($"This is a Log message");
           
        }
    }
}