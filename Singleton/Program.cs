using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = MySingleTon.GetInstance;
            x.PrintData("Hello");
        }
    }

    public class MySingleTon
    {
        private static readonly MySingleTon Instance = new MySingleTon();
        public static MySingleTon GetInstance
        {
            get
            {
                //if (Instance == null)
                //    Instance = new MySingleTon();
                return Instance;
            }
        }
        private MySingleTon()
        {
            
        }
        public void PrintData(string str)
        {
            Console.WriteLine(str);
        }
    }
}
