using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3.hafta
{
    internal class Class2
    {
        public void ornek7(string s)
        {
            for (s = Console.ReadLine(); s != "çıkış";
                s = Console.ReadLine())
                Console.WriteLine(s);
        }
        public void ornek8()
        {
            int i = 0, a, n;
            Console.Write("bir sayı girin"); n = Convert.ToInt32(Console.ReadLine());
            Console.Write("artım miktarı"); a = Convert.ToInt32(Console.ReadLine());
            for (; i < n;)
            {
                Console.Write("{0} ", i); i += a;

            }

        }
        public void ornek9()
        {
            int k,t,toplam,n1,n2;
            Console.Write("aralık başlangıcı :");n1= Convert.ToInt32(Console.ReadLine());
            Console.Write("aralık sonu :"); n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 <= n2)
            {
                for (k = n1; k <= n2; k++)
                {
                    toplam = 0;
                    for (t = 1; t <= k; t++) { if (k % t == 0) toplam += t; }
                    if (toplam == k + 1) Console.WriteLine(k);
                }
            }
            else
                Console.WriteLine("geçerli bir aralık giriniz"  );
        }

        public void ornek10()
        {
            int sayi;
            Console.WriteLine("bir tamsayı girin");
            sayi= Convert.ToInt32(Console.ReadLine());

        for(int bit = 32; bit >= 1; bit--)
            {
                Console.Write("{0}", (sayi >> bit - 1) & 1);
            }
            Console.WriteLine();
        }
    }
}
