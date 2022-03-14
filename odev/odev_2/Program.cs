using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. 
            Console.WriteLine("2. Soru Cözümü");
            Console.WriteLine("Girilecek sayi adedi: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bölen sayiyi giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine("{0}.Sayıyı Giriniz;", i + 1);
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                if ((sayi2 == m) || (sayi2 % m == 0))
                {

                   Console.WriteLine(sayi2 + ", " + m + "e" + " tam bölünüyor");
                }
           }
        }
    }
}
