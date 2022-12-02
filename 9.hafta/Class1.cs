using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.hafta
{
 class Oto
    {
        protected double motorgucu = 5;
        protected double tork = 800;
        protected string renk = "sarı";

        public Oto(double motorgucu, double tork, string renk)
        {
            this.motorgucu = motorgucu;
            this.tork = tork;
            this.renk = renk;
        }
        public void ozellikgoster()
        {
            Console.WriteLine("motor gücü ="+motorgucu);
            Console.WriteLine("tork ="+tork);
            Console.WriteLine("renk ="+renk);

        }public double Mototgucu
        {
            get { return motorgucu; }
            set { motorgucu = value; }
        }
        public double Tork
        {
            get { return tork; }
            set { tork = value; }
        }
        public string Renk
        {
            get { return renk; }
            set
            {
                renk = value;
            }
        }
    }
    class Model1 : Oto

    {
        public string tur;
        public Model1(string tur,double guc,double tork,string renk):base( guc,tork,renk)
        {
            this.tur = tur;
        }
        public void turgoster()
        {
            Console.WriteLine("türü "+ tur);
        }
    }
    class Model2 : Oto
    {
        public string tur;
        public Model2(string tur, double guc, double tork, string renk) : base(guc, tork, renk)
        {
            this.tur = tur;
        }
        public void turgoster()
        {
            Console.WriteLine("türü " + tur);
        }
    }
}
