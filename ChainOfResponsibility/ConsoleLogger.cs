namespace ChainOfResponsibility
{
    using System;

    public class ConsoleLogger : Logger
    {
        public ConsoleLogger(LogLevel loglevel)
            : base(loglevel)
        {
        }

        protected override void WriteMessage(string message)
        {
            Console.WriteLine("Writing to console: " + message);
        }
    }
}
