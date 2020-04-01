using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{

    public interface IChartFactory
    {
        public IChart GetChart();
    }
    public interface IChart
    {
        public void PlotChart();
    }
    public class BarChart : IChart
    {
        public void PlotChart()
        {
            Console.WriteLine("BarChart plotted");
        }
    }
    public class PiChart : IChart
    {
        public void PlotChart()
        {
            Console.WriteLine("Pichart Plotted");
        }
    }

    public class PaidUserProvider : IChartFactory
    {
        public IChart GetChart()
        {
            return new PiChart();
        }
    }
    public class FreeUserProvider : IChartFactory
    {
        public IChart GetChart()
        {
            return new BarChart();
        }
    }
}
