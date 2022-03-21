using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Calisan 1 *****");
            Calisan calisan1 = new Calisan("Ayse", "Kara", 23425634, "İnsan Kaynaklari"); // instance
            calisan1.CalisanBilgileri();
            Console.WriteLine("***** Calisan 2 *****");
            Calisan calisan2 = new Calisan("Deniz", "Arda", 255646789, "Satin Alma");
            calisan2.CalisanBilgileri();
            /*
            Console.WriteLine("***** Calisan 3 *****"); // overload
            Calisan calisan3 = new Calisan("Dilan", "OZER");
            calisan3.CalisanBilgileri();
            */
        }
    }
    
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi:{0}", Ad);
            Console.WriteLine("Calisan Soyadi:{0}", Soyad);
            Console.WriteLine("Calisan Numarasi:{0}", No);
            Console.WriteLine("Calisan Departmani:{0}", Departman);
        }
    }
}
