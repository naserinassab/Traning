using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7
{
    class Program
    {
        static void Main(string[] args)
        {       
            Date save = new Date();
            chanotafazol yu = new chanotafazol();
            cdt n = new cdt();
            save.Day = n.day();
            save.Month = n.month();
            save.Year = n.year();
            Console.ReadLine(); 
            yu.tarikh();
            Console.WriteLine();
            yu.tafazol();
            Console.ReadLine();
          
            Console.Write(save.Day.ToString());
            Console.Write(save.Month.ToString());
            Console.WriteLine(save.Year.ToString());
            Console.ReadLine();
        }
    }
}


