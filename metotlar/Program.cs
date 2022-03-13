using System;

namespace metotlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            // erisim_belirteci geri_donus_tipi metot_adi(parametreListesi/arguman)
            //{
                //komutlar;
                // return;
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirveTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2)); // 7
            ornek.EkranaYazdir(Convert.ToString(a + b)); // 7 -> ref olmasaydi 5, ref ile global oldu
        }   

        static int Topla(int deger1, int deger2) // call by value -> kopyasinin degeri degisir
        {
            return (deger1 + deger2);
        }
    } 

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirveTopla(ref int deger1, ref int deger2) // call by referance -> bellekteki karsiligina (orijinal) degisiklik yapar
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }   
}
