using System;
using System.Collections;
// Proje Tanım: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
//              her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama 
//              toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
// Yazar: Dilan ÖZER
namespace odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 tane sayi giriniz");
            ArrayList sayiList = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}. sayiyi giriniz: ", i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayiList.Add(sayi);
            }

            sayiList.Sort(); // kucuk->buyuk
            ArrayList enKucuk3Sayi = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                enKucuk3Sayi.Add(sayiList[i]);
            }

            sayiList.Reverse(); // buyuk->kucuk
            ArrayList enBuyuk3Sayi = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                enBuyuk3Sayi.Add(sayiList[i]);
            }
        
            int buyukToplam = 0;
            foreach (int item in enBuyuk3Sayi)
            {
                buyukToplam += item;
            }
            int buyukOrtalama = buyukToplam/3;
            Console.WriteLine("En buyuk uc sayinin ortalamasi: " + buyukOrtalama);

            int kucukToplam = 0;
            foreach (int item in enKucuk3Sayi)
            {
                kucukToplam += item;
            }
            int kucukOrtalama = kucukToplam/3;
            Console.WriteLine("En kucuk uc sayinin ortalamasi: " + kucukOrtalama);

            Console.WriteLine($"Ortalamalarin toplami: {buyukOrtalama + kucukOrtalama}");
            
        }
    }
}
