using System;

namespace degisken
{
    class Program
    {
        public static void Main(string[] args)
        {
            byte b = 5; // 1 byte - (0, 255)
            sbyte cb = 5; // 1 byte - (-128, 127)

            short s = 5; // 2 byte - (-.., +..) - tamsayı deger
            ushort us = 5; // 2 byte - (0, +..) 

            Int16 i16 = 2; // 2 byte - (-.., +..)
            int i = 2; // 4 byte
            Int32 i32 = 2; // 4 byte - (-.., +..)
            Int64 i64 = 2; // 8 byte - (-.., +..)

            uint ui = 2; // 4 byte
            long l = 4; // 8 byte - buyuk tamsayılar
            ulong ul = 4; // 8 byte - buyuk tamsayılar

            // Reel sayılar
            float f = 5; // 4 byte
            double d = 5; // 8 byte 
            decimal de = 5; // 16 byte 

            char c = '2'; // 2 byte - tek karakter tutma
            string str = "Dilan"; // sınırsız 

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now; // calıstırılan an
            Console.WriteLine(dt);

            // Karmasık Tip
            object o1 = "X";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler
            string str1 = string.Empty;
            str1 = "Dilan OZER";
            string ad = "dilan";
            string soyad = "ozer";
            string tamIsim = ad + " " + soyad;

            // Integer tanımlama sekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean
            bool bool1 = 10 < 2;

            // degisken donusumleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // Cıktı: 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // Cıktı: 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int21); // Cıktı: 40

            // datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            // saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}