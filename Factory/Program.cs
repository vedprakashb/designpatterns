using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var paidProvider = new PaidUserProvider().GetChart();
            paidProvider.PlotChart();

            var freeProvider = new FreeUserProvider().GetChart();
            freeProvider.PlotChart();
            Console.ReadLine();
        }
    }

}
