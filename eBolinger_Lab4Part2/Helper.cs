using System;
using System.Collections.Generic;
using System.Text;

namespace eBolinger_Lab4Part2
{
    public class Helper
    {
        public Manager myManager = new Manager();

        public Helper(Manager mrg)
        {

        }

        public void doWork()
        {
            Console.WriteLine("Doing Work");
        }

        public void finished()
        {
            Console.WriteLine("Worked Finished");
            Done job = RemoveMethod;
        }

        private delegate void Done(Helper h);

        public void RemoveMethod(Helper h)
        {
            myManager.Remove(h);
        }
    }
}
