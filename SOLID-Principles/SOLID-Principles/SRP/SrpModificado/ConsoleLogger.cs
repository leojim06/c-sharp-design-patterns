using System;

namespace SrpModificado
{
    internal interface ILogger
    {
        void Info(string message);
        void Debug(string message);
        void Error(string message, Exception ex);
    }

    internal class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {

        }

        public void Debug(string message)
        {
            Console.WriteLine(message);
        }

        public void Error(string message, Exception ex)
        {
            Console.WriteLine(message + " - " + ex.Message);
        }

        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
