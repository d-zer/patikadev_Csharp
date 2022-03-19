using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // system.collections.generic
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            
            kullanicilar.Add(10, "ayse yilmaz");
            kullanicilar.Add(12, "ahmet yilmaz");
            // kullanicilar.Add(12, "ahmet yilmaz"); -> varolan keyi ekleyemez run-time hatası verir
            kullanicilar.Add(18, "deniz arda");
            kullanicilar.Add(20, "ozcan cosar");

            // Dizi elemanlarına erişim
            Console.WriteLine("***** Elemanlara Erişim *****");
            Console.WriteLine(kullanicilar[12]); // key belirtirsin
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            // Count
            Console.WriteLine("***** Count *****");
            Console.WriteLine(kullanicilar.Count); // eleman sayisi

            // Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("dilan ozer"));

            // Remove
            Console.WriteLine("***** Remove *****");
            kullanicilar.Remove(12); // 12 keyli elemanı sil
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            // Keys
            Console.WriteLine("***** Keys *****");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }
            // Values
            Console.WriteLine("***** Values *****");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
