

class ogrenci
{
    public ulong ogrencino;
    public string ad;
    public string soyad;
    public string bolum;
    public byte sinif;
}
class Dortgen
{
 public int En;
public int Boy;
 public int Alan()
    {
 int Alan = En * Boy; return Alan;
    }
public void EnBoyBelirle(int en, int boy)
    {
        En = en; Boy = boy;
    }
 public void Yaz()
    {
        Console.WriteLine("***************");
        Console.WriteLine("En:{0,5}", En);
        Console.WriteLine("Boy:{0,5}", Boy);
        Console.WriteLine("Alan:{0,5}", Alan());
        Console.WriteLine("***************");
    }
    class toplama
    {
        public int x;
        public int y;
        public toplama(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public toplama() : this(-1, -1) { }
        public toplama(int x):this(x,1) { }
        public int islem() { return x + y; }
        public void yaz()
        {
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);
        }
    }
}
