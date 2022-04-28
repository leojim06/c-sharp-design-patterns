using System;

namespace OrderSystem
{
    public interface ILoggerService
    {
        void Info(string message); 
        void Debug(string message);
        void Error(string message, Exception exception);
    }

    public class LoggerService : ILoggerService
    {
        public LoggerService()
        {
            // here we need to write the code for initialization
            // that is creating the log file with necessary details
        }
        public void Debug(string message)
        {
            // here we need to write the code to log the debug message
        }

        public void Error(string message, Exception exception)
        {
            // here we need to write the code to log the error message
        }

        public void Info(string message)
        {
            // here we need to write the code to log the info message
        }
    }
}
