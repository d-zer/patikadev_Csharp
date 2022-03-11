using System;

namespace for_loop
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.WriteLine("Lütfen bir sayi giriniz: ");
            string s = Console.ReadLine();
            int sayac = int.Parse(s);
            for (int i = 0; i < sayac; i++)
            {
                // komutlar
                if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }

            }

            // 1 ile 1000 arasındaki tek ile çift sayıların kendi içlerindeki toplamı ekrana yazdırma
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Cift Toplam: " + ciftToplam);

            // break, continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;   // dongu sonlandırır
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;   // adım atlar
                }
                Console.WriteLine(i);
            }

            
        }
    }
}
