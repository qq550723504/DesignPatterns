using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        private static AbstractLogger GetChainOfLoggers()
        {
            var errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            var fileLogger = new FileLogger(AbstractLogger.DEBUG);
            var consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }

        static void Main(string[] args)
        {
            var loggerChain = GetChainOfLoggers();

            loggerChain.LogMessage(AbstractLogger.INFO, "This is an information.");

            loggerChain.LogMessage(AbstractLogger.DEBUG,
               "This is a debug level information.");

            loggerChain.LogMessage(AbstractLogger.ERROR,
               "This is an error information.");

            Console.ReadKey();
        }
    }
}
