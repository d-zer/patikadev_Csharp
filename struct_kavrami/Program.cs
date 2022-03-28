using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(); // new olmazsa olmaz
            dikdortgen.kisaKenar = 3;
            dikdortgen.uzunKenar = 4;
            Console.WriteLine("Class Alan Hesabi: {0}", dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct(3, 4); // new olmadan yaratilabilir
            // Dikdortgen_Struct dikdortgen_struct // initialize degerleri atayamaz --> 16, 17. satir yazilmali
            // dikdortgen_struct.kisaKenar = 3;
            // dikdortgen_struct.uzunKenar = 4;
            Console.WriteLine("Struct Alan Hesabi: {0}", dikdortgen_struct.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;
        public Dikdortgen()
        {
            kisaKenar = 3;
            uzunKenar = 4;
        }
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int kisaKenar;
        public int uzunKenar;
        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            // kisaKenar = 3;
            // uzunKenar = 4;
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        } // parametresi olmayan constructor'i struct icin tanimlayamazsin
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }
}
