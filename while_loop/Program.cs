using System;

namespace while_loop
{
    class Program
    {
        public static void Main(string[] args)
        {
            // While
            Console.WriteLine("***** While *****");
            // 1 den baslayarak konsoldan girilen sayıya kadar ortalama hesaplanıp konsola yazdırma
            Console.Write("Sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri konsola yazdırma
            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            Console.WriteLine("***** ForEach *****");
            string[] arabalar = {"BMV", "Ford", "Toyota", "Nissan"};
            
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}