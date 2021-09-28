using System;

namespace ChainOfResponsibilityPattern
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level) 
        {
            Level = level;
        }
        protected override void Write(string message)
        {
            Console.WriteLine($"Standard Console::Logger: { message}");
        }
    }
}
