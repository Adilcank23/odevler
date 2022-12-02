using _10.hafta;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.hafta
{
    public delegate int OlayYoneticisi();
    interface IArayuz
    {
        int Metot1(); int Metot2();
        int sahteozellik { set; get; }
        int this[int indeks] { get; }
        event OlayYoneticisi Olay;
    }
    class deneme : IArayuz
    {
        public int Metot1() { return 1; }
        public int Metot2() { return 2; }
        public int sahteozellik
        {
            set { }
            get
            { return 3; }
        }
        public int this[int indeks]
        { get { return indeks; } }
        public event OlayYoneticisi Olay;
        


    }
}