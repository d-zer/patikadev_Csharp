using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("4. Soru Cözümü");
            Console.WriteLine("Bir Cümle Giriniz ");
            string cumle = Convert.ToString(Console.ReadLine());
            string[] kelimeler = cumle.Split(" ");
            char[] harfler = cumle.ToCharArray();

            int harfSayisi = 0;

            Console.WriteLine("Verilen Cümlede {0} Kelime Vardır.",kelimeler.Length);
            for (int i = 0; i < kelimeler.Length; i++)
            {
                 char[] harfdizi = kelimeler[i].ToCharArray();
                harfSayisi += harfdizi.Length;
            }
            Console.WriteLine("Verilen Cümlede {0} Harf Vardır.",harfSayisi);
        }

    }
}