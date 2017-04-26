namespace ChainOfResponsibility
{
    using System;

    public class EmailLogger : Logger
    {
        public EmailLogger(LogLevel loglevel)
            : base(loglevel)
        {
        }

        protected override void WriteMessage(string message)
        {
            Console.WriteLine("Sending via email: " + message);
        }
    }
}
