using System;

namespace DIP_Demo
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log to Console: {message}");
        }
    }
}