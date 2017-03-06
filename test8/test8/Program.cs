using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test8
{
    class Program
    {
            static void Main(string[] args)
            {
                Active bin = new Active();
                Console.Write("Add Nummber:");
                int q = int.Parse(Console.ReadLine());
                Console.ReadLine();
                bin.Bainerii(q);
                bin.Anagram(q);
                bin.Aval(q);         
        }
    }
}