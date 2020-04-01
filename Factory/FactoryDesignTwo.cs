using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface ILoggerProvider
    {
        public ILogger GetLogger();
    }
    public interface ILogger
    {
        public string Value { get; set; }
        public void Log();
    }

    public class DatabaseLoggerProvider : ILoggerProvider
    {
        public ILogger GetLogger()
        {
            return new DataBaseLogger();
        }
    }
    public class FileLoggerProvider : ILoggerProvider
    {
        public ILogger GetLogger()
        {
            return new FileLogger();
        }
    }
    public class DataBaseLogger : ILogger
    {
        public string Value { get ; set; }

        public void Log()
        {
            Console.WriteLine($"Log { Value } to Database");
        }
    }
    public class FileLogger : ILogger
    {
        public string Value { get ; set; }

        public void Log()
        {
            Console.WriteLine($"Log { Value } to file ");
        }
    }

}
