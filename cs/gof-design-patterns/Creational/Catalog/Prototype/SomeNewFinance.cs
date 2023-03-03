namespace Creational.Catalog.Prototype
{
    public class SomeNewFinance : Finance
    {

        private string? metaInfo;

        public SomeNewFinance() 
        {
            metaInfo = null;
            Amount = 0;
            Currency = null;
        }


        public string? GetMeta()
        {
            return metaInfo;
        }


        public new object Clone()
        {
            string metaCopy = new string(metaInfo?.ToCharArray());
            SomeNewFinance result = new SomeNewFinance(metaCopy, Amount, (Currency)Currency.Clone());
            return result;
        }


        public SomeNewFinance(string meta, decimal amount, Currency currency)
        {
            metaInfo = meta;
            Amount = amount;
            Currency = currency;
        }
    }
}
