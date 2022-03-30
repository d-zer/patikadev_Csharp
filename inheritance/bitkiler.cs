using System;

namespace interitance
{   
    public class bitkiler:canlilar
    {
        protected void FotosentezYapma()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki()
        {
            // base.UyaranlaraTepki(); üst siniftan gelen mesaji almaz
            Console.WriteLine("Bitkiler günese tepki verir.");
        } // ekrana sadece console.writeline yazar
    }

    public class TohumluBitkiler:bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapma(); 
            base.Beslenme(); // nesne olusturuldugunda cagrilmayi saglar
            base.Bolastim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void TohumluCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla cogalir.");
        }
    }
    
    public class TohumsuzBitkiler:bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapma(); 
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla cogalir.");
        }
    }
}