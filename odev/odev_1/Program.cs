using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            
            Console.WriteLine("1. Soru Cözümü");
            Console.Write("Girilecek sayi adedi: ");
            int n= Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}.Sayi: ", i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                dizi[i] = sayi;
            }

            Console.WriteLine("*** Girilen Çift Sayılar ***");
            foreach (var item in dizi)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
