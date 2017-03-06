using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7
{
    class cdt
    {
        public int day()
        {
            DateTime dy = DateTime.Now;
            int getdy = dy.Day;
            return getdy;
        }
        public int month()
        {
            DateTime mnth = DateTime.Now;
            int getmnt = mnth.Month;
            return getmnt;
        }
        public int year()
        {
            DateTime yer = DateTime.Now;
            int getyer = yer.Year;
            Console.WriteLine(yer);
            return getyer;


        }
    }
}
