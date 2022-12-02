using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.hafta
{
    internal class ornek5tensonrakiler
    {
        static int buyukbul(int a,int b)
        {
            if (a > b)
                return a;
            return b;
        }
        static int buyukbul13(int a,int b,int c)
        {
            return buyukbul(a, buyukbul(b, c));
        }    
        static void diziyaz(int[] a,int sekil)
        {
            if (sekil == 0)
            {
                foreach(object o in a)
                    Console.Write(o.ToString()+" ");
                Console.WriteLine();
            }
           else if(sekil==1)
            {
                int x = 1;
                foreach(object o in a)
                {
                    Console.Write("{0,5}", o.ToString());
                    if(x%3==0) Console.WriteLine();
                    x++;
                }
            }
            else
            {
                foreach (object o in a)
                    Console.WriteLine(o.ToString());
            }
            Console.WriteLine();
        }
        static int Faktoriyel(int a)
        {
            if (a == 0)
                return 1;
            return a * Faktoriyel(a - 1);
        }
        }
}
