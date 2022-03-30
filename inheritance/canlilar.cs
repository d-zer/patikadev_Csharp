using System;

namespace interitance
{   
    public class canlilar // public sealed ... kalitim vermez
    {
        protected void Beslenme() // property
        {
            Console.WriteLine("Canlilar beslenir.");
        }

        protected void Solunum() // property
        {
            Console.WriteLine("Canlilar solunum yapar.");
        }

        protected void Bolastim() // property
        {
            Console.WriteLine("Canlilar bosaltim yapar.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlilar uyaranlara tepki verir.");
        }
    }
    
}