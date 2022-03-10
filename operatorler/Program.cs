using System;

namespace operatorler
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***** Atama ve Islemli Atama Operatorler *****");
            int x = 3;
            int y = 3;
            y = y + 2; 
            Console.WriteLine("y: " + y);
            y += 2; // islemli atama
            Console.WriteLine("y: " + y);
            y /= 1;
            Console.WriteLine("y: " + y);
            x *= 2; 
            Console.WriteLine("x: " + x);

            Console.WriteLine("***** Mantiksal Operatörler *****");
            // Mantıksal Operatörler
            // ||, &&, !
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");
            
            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            Console.WriteLine("***** Ilişkisel Operatorler *****");
            // İlişkisel Operatorler
            // <, >, <=, >=, ==, !=
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;

            Console.WriteLine("***** Aritmetik Operatorler *****");
            // aritmetik operatorler
            // /, *, +, -
            int sayi1= 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            // % : mod alır
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);
        }        
    }
}
