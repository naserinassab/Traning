using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test8
{
    class Active
    {
        public void Bainerii(int o)
        {
            int b = 0;
            string c = "";
            string x = "";
            while (o >= 1)
            {
                b = o / 2;
                c += (o % 2).ToString();
                o = b;
            }
            for (int i = c.Length - 1; i >= 0; i--)
            {
                x = x + c[i];
            }
            Console.WriteLine("Bainari:{0}", x);
        }
        public void Anagram(int x)
        {
            string c = "";
            string a = "";
            string b = "";
            c = x.ToString();
            for (int i = 0; i <= c.Length; i++)
            {
                a += x.ToString();
            }
            for (int i = c.Length - 1; i >= 0; i--)
            {
                b = b + a[i];
            }
            Console.WriteLine("Anagram:" + b);
        }
        public void Aval(int a)
        {
            int c = 1;
            int b = 0;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    b++;
                }
            }
            if (b != 0)
            {
                Console.WriteLine("Aval nist ");
            }
            else
            {
                Console.WriteLine("Aval ");
            }
            Console.ReadLine();
        }
    }
}