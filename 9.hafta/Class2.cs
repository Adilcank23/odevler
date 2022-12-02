using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.hafta
{
    abstract class A
    {
        public int x;
        abstract public int y
        {
            get;
            set;
        }
        public A(int x)
        {
            this.x = x;
        }
        abstract public void metot();
    }
    class S : A
    {
        int s;
        public S(int x) : base(x)
        {

        }
        public override int y
        {
            get { return x; }
            set { x = value; }
        }
        public override void metot()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
    class program
    {
        static void Main()
        {
            S e = new S(5);
            e.y = 2 * e.x;
            e.metot();
        }
    }
}
