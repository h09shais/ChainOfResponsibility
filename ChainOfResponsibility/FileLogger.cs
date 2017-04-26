namespace ChainOfResponsibility
{
    using System;

    public class FileLogger : Logger
    {
        public FileLogger(LogLevel loglevel)
            : base(loglevel)
        {
        }

        protected override void WriteMessage(string message)
        {
            Console.WriteLine("Writing to Log File: " + message);
        }
    }
}
