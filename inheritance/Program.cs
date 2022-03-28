using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // canlilar -> bitkiler --> tohumlu
            //                      --> tohumsuz
            //          -> hayvanlar --> surungenler
            //                       --> kuslar

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            // tohumluBitki.Beslenme(); // canlilar class
            // tohumluBitki.Solunum();
            // tohumluBitki.Bolastim();
            // tohumluBitki.FotosentezYapma(); // bitkiler class
            // tohumluBitki.TohumluCogalma();
            tohumluBitki.TohumluCogalma();

            Console.WriteLine("*************");

            Kuslar marti = new Kuslar();
            // marti.Solunum();
            // marti.Beslenme();
            // marti.Bolastim();
            // marti.Adaptasyon();
            marti.Ucmak();
        }
    }
}
