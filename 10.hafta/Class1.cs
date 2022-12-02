using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _10.hafta.temsilciler;

namespace _10.hafta
{
    class temsilciler
    {
        public delegate void komutmetedu();
        public struct komutyapisi
        {
            public komutmetedu komutmetod;
            public string komut;

        }

        public static void Komut1()
        {
            Console.WriteLine("komut1 çalıştı");

        }
        public static void Komut2()
        {
            Console.WriteLine("komut 2 çalıştı");

        }
        public static void Komut3()
        {
            Console.WriteLine("Komut3 çalıştı.");
        }
        public static void Komut4()

        { Console.WriteLine("Komut4 çalıştı."); }
       
    }
}