using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar); // Pazar --> string olarak
            Console.WriteLine((int)Gunler.Cumartesi); // 24

            int sicaklik = 32;

            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Disariya cikmak icin havanin biraz daha isinmasini bekle");
            }
            else if (sicaklik >= (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Disariya cikmak icin cok sicak bir gun");
            }
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Hadi disari cik");
            }
        }
    }

    enum Gunler // numerik veriyi anlamli tutma
    {
        Pazartesi = 1, // eleman adini belirtir, index = 0 defaultta
        Sali, // 2
        Carsamba, // 3
        Persembe, // 4
        Cuma = 23,
        Cumartesi, // 24
        Pazar // 25
    };

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}