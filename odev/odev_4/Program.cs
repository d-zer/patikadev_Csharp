using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("4. Soru Cozumu");
            Console.WriteLine("Cümle Giriniz: ");
            string cumle = Convert.ToString(Console.ReadLine());

            string[] kelimeler = cumle.Split(" ");
            Console.WriteLine("Cümlede, toplam {0} kelime vardır.",kelimeler.Length);

            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ" + "abcçdefgğhiıjklmnoöprsştuüvyz";
            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Cümlede toplam {0} tane harf vardır.", sayac);
        }
    }
}