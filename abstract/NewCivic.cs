namespace abstract_ornek
{
    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
           // throw new NotImplementedException();
           return Marka.Honda;
        }

        // override
        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}