using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayse","Yilmaz","IK");
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Deniz","Arda","IK");
            Calisan calisan3 = new Calisan("Dilan","Ozer","IK");
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);

            // Islemler islemler = new Islemler(); // static sinifta, nesneler araciligiyla erisim boyle olmaz
            Console.WriteLine("Toplama islemi sonucu: {0}", Islemler.Topla(100, 200)); // static sinif uyelerine erisim icin => sinifAdi. ile erisirsin
            Console.WriteLine("Cikarma islemi sonucu: {0}", Islemler.Cikar(400, 50));
        }

        // static olmayan class
        class Calisan
        {
            private static int calisanSayisi;

            public static int CalisanSayisi { get => calisanSayisi; } // property

            private string Isim;

            private string Soyisim;

            private string Departman;

            public Calisan(string isim, string soyisim, string departman)
            {
                this.Isim = isim;
                this.Soyisim = soyisim;
                this.Departman = departman;
                calisanSayisi ++;
            } // constructor

            // static constructor
            static Calisan() // erisim belirleyicisi olmaz
            {
                calisanSayisi = 0;

            } // sadece 1 kez calisir, o da ilk erisildiginde
        }

        static class Islemler
        {
            public static long Topla (int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public static long Cikar (int sayi1, int sayi2)
            {
                return sayi1 - sayi2;
            }

        }
    }
}
