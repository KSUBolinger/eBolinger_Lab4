using System;
using System.Collections.Generic;
using System.Text;

namespace eBolinger_Lab4Part2
{
    public class Manager
    {
        public Helper requestHelp()
        {
            Helper h = new Helper(this);
            active.Add(h);
            Console.WriteLine("New Helper Added");
            return h;
        }

        private List<Helper> active = new List<Helper>();

        public Helper Remove(Helper h)
        {
            active.Remove(h);
            //Console.WriteLine("Helper Removed");

            return h;
        }
    }
}
