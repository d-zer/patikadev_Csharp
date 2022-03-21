using System;
using System.Collections;
// Proje Tanım: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
//              (ArrayList sınıfını kullanara yazınız.)
//              Negatif ve numeric olmayan girişleri engelleyin.
//              Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//              Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
// Yazar: Dilan ÖZER
namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("20 tane sayi girmeniz gerekmektedir");
            int[] sayilar = new int[20];
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0}. sayiyi giriniz: ", i);
                int sayi = int.Parse(Console.ReadLine());
                while (sayi < 0)
                {
                    Console.WriteLine("Pozitif sayi giriniz");
                    Console.WriteLine("{0}. sayiyi giriniz: ", i);
                    sayi = int.Parse(Console.ReadLine());
                }
                sayilar[i-1] = sayi;
            }

            ArrayList asalList = new ArrayList();
            ArrayList asalOlmayanList = new ArrayList();

            
            for (int i = 0; i < 20; i++)
            {
                if (sayilar[i] == 1)
                    asalOlmayanList.Add(sayilar[i]);
                else if (sayilar[i] == 2)
                    asalList.Add(sayilar[i]);
                else if (sayilar[i] > 2)
                {
                    int asalKontrol = 0;

                    for (int j = 2; j < sayilar[i]; j++)
                    {
                        if (sayilar[i]%j == 0)
                        {
                            asalKontrol++;
                        } 
                    }

                    if (asalKontrol == 0)
                        asalList.Add(sayilar[i]);
                    else
                        asalOlmayanList.Add(sayilar[i]);
                }
            }
            
            asalList.Sort();
            asalList.Reverse();
            Console.WriteLine("Asal Sayilarin Buyukten Kucuge Siralanisi:");
            foreach (int item1 in asalList)
            {
                Console.WriteLine(item1);
            }

            Console.WriteLine("Asal Eleman Sayisi: " + asalList.Count);
            
            int asalToplam = 0;
            foreach (int asalItem in asalList)
            {
                asalToplam += asalItem;
            }
            Console.WriteLine("Asal sayilarin ortalamasi: " + asalToplam/asalList.Count);
            
            asalOlmayanList.Sort();
            asalOlmayanList.Reverse();
            Console.WriteLine("Asal Olmayan Sayilarin Buyukten Kucuge Siralanisi:");
            foreach (int item2 in asalOlmayanList)
            {
                Console.WriteLine(item2);
            }

            Console.WriteLine("Asal Olmayan Eleman Sayisi: " + asalOlmayanList.Count);
            
            int asalOlmayanToplam = 0;
            foreach (int asalOlmayanItem in asalOlmayanList)
            {
                asalOlmayanToplam += asalOlmayanItem;
            }
            Console.WriteLine("Asal sayilarin ortalamasi: " + asalOlmayanToplam/asalOlmayanList.Count);
        
        }
    }
}
