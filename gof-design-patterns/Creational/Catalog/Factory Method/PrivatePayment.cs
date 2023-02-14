namespace Creational.Catalog.FactoryMethod
{
    public class PrivatePayment : Finance, IConvertable<PrivatePayment>
    {
        public PrivatePayment Convert(Currency currency)
        {
            if (Currency.Code == "USD")
            {
                return new PrivatePayment(Amount / (Decimal)(CurrencyExtensions.GetCurrencyRate(currency)), currency);
            }
            else
            return new PrivatePayment(Amount * (Decimal)(CurrencyExtensions.GetCurrencyRate(Currency)), currency);
        }



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public PrivatePayment()
        {
            Amount = 0.0m;
            Currency = null;
        }


        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public PrivatePayment(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }
}
