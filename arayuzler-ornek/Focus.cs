namespace arayuzler_ornek
{
    public class Focus:IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
           // throw new NotImplementedException();
           return Marka.Ford;
        }

        public int KacTekerlektenOlusur() // refactor edilebilir
        {
            // throw new NotImplementedException();
            return 4;
        }

        public Renk StandartRengiNe()
        {
            // throw new NotImplementedException();
            return Renk.Beyaz;
        }
    }
}