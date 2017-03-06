using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test9
{
    class stringg
    {
        public string str = "Hello ali ";

        public void ANAGRAM()
        {
            string makos = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                makos = makos + str[i];
            }
            Console.WriteLine(makos);
            Console.ReadLine();
        }
        public void serch()
        {
            int serc = 0;
            stringg tr = new stringg();
            string s = "Hi alireza";
            Console.WriteLine("Add Char:");
            string a = Console.ReadLine();
            a = Console.ReadLine();
            serc = string.Compare(s, a);
            Console.WriteLine(serc);
            Console.ReadLine();
        }
    }
}