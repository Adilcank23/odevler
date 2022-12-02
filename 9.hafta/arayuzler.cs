using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.hafta
{
    interface Iarayuz
    {
        int metot1();
       void metot2();
        int sayi
        {
            get;
            set;
        }
        int this[int indeks]
        {
            get;
        }
    }
    class sinif : Iarayuz
    {
        private int sayi;
        public int metot1() { return 0; }
        public void metot2() {  }
         public int Sayi 
        {
            get
            {
                return sayi;
            }
            set { sayi = value; }
        }
        public int this[int indeks]
        {
            get { return indeks; }
            set { }
        }

    }
}