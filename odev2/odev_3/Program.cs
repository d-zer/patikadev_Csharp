using System;
// Proje Tanım: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde 
//              saklayan ve dizinin elemanlarını sıralayan programı yazınız.
// Yazar: Dilan ÖZER
namespace odev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cumle = new List<string>();
            string[] unluHarfler = {"a", "e", "i", "o", "u"};
            List<string> cumleUnluHarf = new List<string>();
            Console.WriteLine("Cümle giriniz: ");
            cumle.Add(Console.ReadLine());

            for (int i = 0; i < cumle.Count; i++)
            {
                for (int j = 0; j < unluHarfler.Length; j++)
                {
                    if (cumle[i].Contains(unluHarfler[j]))
                    {
                        cumleUnluHarf.Add(unluHarfler[j]);
                    }
                }
            }

            foreach (string item in cumleUnluHarf)
            {
                Console.WriteLine(item);
            }
            
             
        }
    }
}