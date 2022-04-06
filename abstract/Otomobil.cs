namespace abstract_ornek
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public virtual Renk StandartRengiNe()
        {
            return Renk.Beyaz; // default renk
        }

        public abstract Marka HangiMarkaninAraci();

    }
}