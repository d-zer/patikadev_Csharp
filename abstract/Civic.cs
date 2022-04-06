namespace abstract_ornek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
           // throw new NotImplementedException();
           return Marka.Honda;
        }

        public int KacTekerlektenOlusur() // refactor edilebilir
        {
           // throw new NotImplementedException();
           return 4;
        }

        public Renk StandartRengiNe()
        {
           // throw new NotImplementedException();
           return Renk.Gri;
        }
    }
}