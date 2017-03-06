using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7
{
    class chanotafazol
    {
        public void tarikh()
        {
            DateTime tr = DateTime.Now;
            Console.Write("chandomin roz sal:");
            Console.WriteLine(tr.DayOfYear);

        }
        public void tafazol()
        {
            DateTime firstDate = DateTime.Now;
            DateTime secondDate = new DateTime(2017, 05, 31);

            TimeSpan diff = secondDate.Subtract(firstDate);
            Console.WriteLine(diff);
            Console.ReadLine();
        }
    }
}