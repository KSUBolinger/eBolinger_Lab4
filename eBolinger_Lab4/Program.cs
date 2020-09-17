using System;
using eBolinger_Lab4;

namespace eBolinger_Lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            work();
            Console.WriteLine("Client Happy");
        }

        public static void work()
        {
            Console.WriteLine("Client Requested Help");
            Manager mrg = new Manager();
            Helper h = mrg.requestHelp();
            h.doWork();
            h.finished();
        }
    }
}
