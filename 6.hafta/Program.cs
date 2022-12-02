class Zaman
{
 public int Saat; public int Dakika; public int Saniye;
public Zaman(int saat, int dakika, int saniye)
 { Dakika=dakika+saniye/60;
 Saniye=saniye%60;
 Saat=saat+Dakika/60;
 Dakika=Dakika%60;
 }
 public static Zaman operator +(Zaman a, Zaman b)
 {
    int ToplamSaniye = a.Saniye + b.Saniye;
 int ToplamDakika = a.Dakika + b.Dakika;
 int ToplamSaat = a.Saat + b.Saat;
 return new Zaman(ToplamSaat, ToplamDakika, ToplamSaniye);
 }
    public static Zaman operator +(Zaman a, int b)
 { int ToplamSaniye = a.Saniye + b;
 return new Zaman(a.Saat, a.Dakika, ToplamSaniye);
 }
   
    
    public static bool operator ==(Zaman a, Zaman b)
 {
if(a.Saniye==b.Saniye&&a.Dakika==b.Dakika&&a.Saat==b.Saat)
 return true;
 else
 return false;
 }
public static bool operator !=(Zaman a, Zaman b)
 {
 return !(a == b);
 }
    public static bool operator |(Zaman a, Zaman b)
 {
 if(a.Saat>12 || b.Saat>12)
 return true;
 else
return false;
 }
 
}
class yapılar{
struct ogrenci
    {
        public int numara;
        public string ad;
        public string soyad;
    }
}
enum notu : byte { basarisiz, basarili }
 class Program
 {
 static void Main()
 {
 notu a = notu.basarili;
 if (a == (notu)1)
 Console.Write("Başarılısınız");
 else
 Console.Write("Başarısızsınız");
}
}
