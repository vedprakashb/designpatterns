using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //var paidProvider = new PaidUserProvider().GetChart();
            //paidProvider.PlotChart();

            //var freeProvider = new FreeUserProvider().GetChart();
            //freeProvider.PlotChart();


            DatabaseLoggerProvider dp = new DatabaseLoggerProvider();
            ILogger dblogger = dp.GetLogger();
            dblogger.Value = "Database Logger sample";

            dblogger.Log();
            FileLoggerProvider fp = new FileLoggerProvider();
            ILogger fileLogger = fp.GetLogger();
            fileLogger.Value = "File Logger sample";
            fileLogger.Log();
            Console.ReadLine();
        }
    }

}
