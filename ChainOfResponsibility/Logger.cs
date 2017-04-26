namespace ChainOfResponsibility
{
    public abstract class Logger
    {
        protected LogLevel logLevel;

        protected Logger next;

        public Logger(LogLevel loglevel)
        {
            this.logLevel = loglevel;
        }

        public Logger SetNext(Logger nextLogger)
        {
            this.next = nextLogger;
            return nextLogger;
        }

        protected abstract void WriteMessage(string message);

        public void Message(string message, LogLevel severity)
        {
            if ((severity & this.logLevel) != 0)
            {
                this.WriteMessage(message);
            }

            this.next?.Message(message, severity);
        }
    }
}
