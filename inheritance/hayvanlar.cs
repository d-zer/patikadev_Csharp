using System;

namespace interitance
{   
    public class hayvanlar:canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki(); // metot, sanal olarak yaratildigi sekilde koyma
            Console.WriteLine("Hayvanlar temasa tepki verir");
        }
    }
    
    public class Surungenler:hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bolastim();
            base.Solunum();
        }
        public void SurunerekHareketEderler()
        {
            Console.WriteLine("Surungenler surunerek hareket eder.");
        }
    }

    public class Kuslar:hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bolastim();
            base.Solunum();
            base.UyaranlaraTepki(); // nesne ilk olusturuldugunda cagrilabilmesi icin
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar.");
        }
    }
}