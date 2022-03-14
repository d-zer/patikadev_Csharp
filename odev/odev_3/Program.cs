using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
           // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
           // Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
           // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
           Console.WriteLine("3. Soru Cözümü");
           Console.WriteLine("Girilecek kelime adedi: ");
           int n3 = Convert.ToInt32(Console.ReadLine());
           char[] dizi = new char[n3];
           for (int i = 0; i < n3; i++)
           {
               Console.WriteLine("{0}.Kelimeyi Giriniz: ", i + 1);
               dizi[i] = Convert.ToChar(Console.ReadLine());
           }
           Console.WriteLine("*** Girilen kelimelerin ters sırası ***");
           for (int i = n3-1; i >= 0; i--)
            {
                Console.WriteLine(dizi[i]);
            }
        }
    }
}
