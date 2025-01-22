namespace Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ILoggerFactory loggerFactory = new DebugLoggerFactory();
            var logger = loggerFactory.CreateLogger();
            logger.LogMessage($"This is a log message");
        }
    }
}