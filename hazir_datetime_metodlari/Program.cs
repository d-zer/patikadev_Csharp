using System;

namespace hazir_datetime_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // günün tarihi, saat dahil
            Console.WriteLine(DateTime.Now.Date); // saati 00:00 
            Console.WriteLine(DateTime.Now.Day); 
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); // string seklinde döner
            Console.WriteLine(DateTime.Now.DayOfYear); // yilin kacinci günü

            Console.WriteLine(DateTime.Now.ToLongDateString()); // cuma nisan 23, 2021
            Console.WriteLine(DateTime.Now.ToShortDateString()); // 4/24/2021
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // saat dk sn
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // saat dk

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            Console.WriteLine("***** Math Kütüphanesi");
            // DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // 14
            Console.WriteLine(DateTime.Now.ToString("ddd")); // sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); // saturday

            Console.WriteLine(DateTime.Now.ToString("mm")); // 04
            Console.WriteLine(DateTime.Now.ToString("mmm")); // Apr
            Console.WriteLine(DateTime.Now.ToString("mmmm")); // april

            Console.WriteLine(DateTime.Now.ToString("yy")); // 21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021

            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); // 25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); // 23 -> büyük olana yuvarlar
            Console.WriteLine(Math.Round(22.3)); // 22 -> yuvarlar
            Console.WriteLine(Math.Floor(22.7)); // 22 -> küçük olana yuvarlar

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine(Math.Pow(3, 4)); // 3^4
            Console.WriteLine(Math.Sqrt(9)); // 3
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Exp(3)); // e^3
            Console.WriteLine(Math.Log10(10)); // 10 tabanli loglama
            
        }
    }
}