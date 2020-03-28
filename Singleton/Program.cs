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
            Parallel.Invoke(
                () => CallSingleton(),
                () => CallSingleton1());

            //  var x = MySingleTon.GetInstance;
            //   x.PrintData("Hello");
        }
        public static void CallSingleton()
        {
            var x = MySingleTon.GetInstance;
            x.PrintData("CallSingleton");
        }
        public static void CallSingleton1()
        {
            var x = MySingleTon.GetInstance;
            x.PrintData("CallSingleton1");

        }
    }

    public sealed class MySingleTon
    {
        private static MySingleTon Instance = null;
        private static readonly object InstanceLock = new object();
        public static MySingleTon GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    lock (InstanceLock)
                    {
                        if (Instance == null)
                            Instance = new MySingleTon();
                    }
                }
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
