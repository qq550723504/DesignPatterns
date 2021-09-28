namespace ChainOfResponsibilityPattern
{
    public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int Level;

        protected AbstractLogger _nextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            _nextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if (Level <= level)
            {
                Write(message);
            }
            if (_nextLogger != null)
            {
                _nextLogger.LogMessage(level, message);
            }
        }

        abstract protected void Write(string message);
    }
}
