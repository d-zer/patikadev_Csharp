using System;

namespace if_else_if
{
    class Program
    {
        public static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time >= 6 && time < 11)
                Console.WriteLine("Gunaydin");
            else if(time <= 18)
                Console.WriteLine("İyi Gunler");
            else
                Console.WriteLine("İyi Geceler");
            
            string sonuc = time <= 18 ? "İyi Gunler" : "İyi Geceler";
            
            sonuc = time >= 6 && time < 11 ? "Gunaydin" : time <= 18 ? "İyi Gunler" : "İyi Geceler";
            
            Console.WriteLine(sonuc);
        }
    }
}