using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {
            //      [Erisim Belirleyici] [Veri Tipi] OzellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //      {
            //      // Metot Komutları
            //      }
            // }

            // Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected
            Calisan calisan1 = new Calisan(); // instance
            calisan1.Ad = "Ayse";
            calisan1.Soyad = "Kara";
            calisan1.No = 23425634;
            calisan1.Departman = "İnsan Kaynaklari";
            calisan1.CalisanBilgileri();
            Console.WriteLine("******************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 255646789;
            calisan2.Departman = "Satin Alma";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi:{0}", Ad);
            Console.WriteLine("Calisan Soyadi:{0}", Soyad);
            Console.WriteLine("Calisan Numarasi:{0}", No);
            Console.WriteLine("Calisan Departmani:{0}", Departman);
        }
    }
}
