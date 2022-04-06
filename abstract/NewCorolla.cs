namespace abstract_ornek
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
           // throw new NotImplementedException();
           return Marka.Toyota;
        }
    }
}