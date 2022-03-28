using System;

namespace interitance
{   
    public class hayvanlar:canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
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
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bolastim();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar.");
        }
    }
}