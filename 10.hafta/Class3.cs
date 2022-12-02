using _10.hafta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.hafta
{
    public class uruntemel
    {
        private int urunkodu;
        private double urunfiyati;
        private string urunbilgisi;
        public uruntemel(int urunkodu, double urunfiyati, string urunbilgisi)
        {
            this.urunkodu = urunkodu;
            this.urunfiyati = urunfiyati;
            this.urunbilgisi = urunbilgisi;
        }
        public int Urunkodu
        {
            get
            {
                return urunkodu;
            }
        }
        public double Birimfiyati
        {
            get { return urunfiyati; }

        }
        public string Uruntanimi { get { return urunbilgisi; } }
    }
    public class Lastik : uruntemel
    {
        private int cap;
        private int genislik;
        private string tip;
        public Lastik(int kod, double fiyat, string bilgi) : base(kod, fiyat, bilgi)
        {

        }
        public int Cap
        {
            get { return cap; }
            set { cap = value; }
        }
        public int Genislik
        {
            get { return genislik; }
            set { genislik = value; }
        }
        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        public override string ToString()
        {
            return Urunkodu.ToString() + " " +
          Birimfiyati.ToString() + " " + Uruntanimi + " "
       + Cap.ToString() + " " + Genislik.ToString() +
       Tip;
        }

    }
    public class Silecek : uruntemel
    {
        private int uzunluk;
        public Silecek(int kodu, double fiyat,
       string bilgi) : base(kodu, fiyat, bilgi)
        {
        }
        public int Uzunluk
        {
            get { return uzunluk; }
            set { uzunluk = value; }
        }
        public override string ToString()
        {
            return Urunkodu.ToString() + " " +
            Birimfiyati.ToString() + " " + Uruntanimi +
            " " + Uzunluk.ToString();
        }
    }
    public class Urunler<T> where T : uruntemel
    {
        private List<T> urunliste;
        public Urunler()
        {
            urunliste = new List<T>();
        }
        public void Ekle(T uye)
        {
            urunliste.Add(uye);
        }
        public void Sil(T uye)
        {
            urunliste.Remove(uye);
        }
        public void Listele()
        {
            foreach (T uye in urunliste)
            {

                Console.WriteLine(uye.ToString());
            }
        }
    }
}
class Ana
 {
 static void Main()
 {
        Urunler<uruntemel> urunler = new
Urunler<uruntemel>();
 Lastik lst = new Lastik(1000, 10,
"Otomobil Lastiği");
 lst.Tip = "Kış Lastiği";
 lst.Cap = 185;
 lst.Genislik = 75;
 Silecek slc = new Silecek(1001, 5,
"On silecek takimi");
 slc.Uzunluk = 60;
 urunler.Ekle(lst);
 urunler.Ekle(slc);
 urunler.Listele();
 }
 }

