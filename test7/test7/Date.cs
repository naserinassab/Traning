using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
        }

        public int Day
        {
            set
            {
                day = value;
            }
            get
            {
                return day;
            }
        }
        public int Month
        {
            set
            {
                month = value;
            }
            get
            {
                return month;
            }
        }
        public int Year
        {
            set
            {
                year = value;
            }
            get
            {
                return year;
            }
        }
    }

}
